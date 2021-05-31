using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//User Add
using System.IO.Ports;      //Add for UART communication
using System.Data.SqlClient;    //Add for MySQL, SQL Server
using MySql.Data.MySqlClient;   //Add for MySQL
/*
 * 1. [고려] 다른 폼간 SQL, DB Connect 변수 연결 가능한지 시도
 * 2. [추가] 전체 모니터링 OR Main 화면에
 *              MCU에서 받아오는 printf 값 입력하는 텍스트 박스
 *              모든 기계장치 작동 상황
 *           모니터링 할 수 있는 화면 만들기
 */

//주석 테스트
namespace Solo_Project
{
    public partial class MainForm : Form
    {

        //SQL Data
        public bool DB_Connect_Flag = false;  //Check DB Conn
        string DB_Order;    //DB에 전송할 명령어
        //MySQL
        public string MySQL_connStr = "Server=192.168.56.101;" +
                        "Uid=winuser;" +
                        "Pwd=4321;" +
                        "Database=storage_db;" +
                        "Charset=UTF8";
        public MySqlConnection MySQL_conn; // 교량
        public MySqlCommand MySQL_cmd; // 트럭
        public MySqlDataReader MySQL_reader; // 트럭이 가져올 끈
        bool MySQL_Flag = false;
        //SQL Server
        public string SS_connStr =
                        "Server=127.0.0.1;" +
                        "Uid=winuser;" +
                        "Pwd=4321;" +
                        "Database=storage_db;";
        public SqlConnection SS_conn; // 교량
        public SqlCommand SS_cmd; // 트럭
        public SqlDataReader SS_reader; // 트럭이 가져올 끈
        bool SS_Flag = false;


        int curTmp = 0;
        int curWet = 0;
        int pastTmp = 0;
        int pastWet = 0;

        //UART Data
        public bool UART_Connect_Flag = false;
        string dataIn;  //UART로부터 들어온 data
        string[] inputSensorData;

        //for Other Form
        work_RFID_Card_Form rfidForm;
        public bool rfidForm_Flag = false;
        environment_TmpWet_Form tmpwetForm;
        public bool tmpwetForm_Flag = false;
        work_RFID_workcheck_Form workForm;
        public bool workForm_Flag = false;
        environment_CheckLog_Form log_Form;

        public MainForm()
        {
            InitializeComponent();
        }

        //UI Code
        private void MainForm_Load(object sender, EventArgs e)
        {
            //장치 관리자에 연결 되어있는 포트 받아오기
            string[] port = SerialPort.GetPortNames();
            comboBox_Port.Items.AddRange(port);
            comboBox_BPS.Items.Add("115200");

            //메인제목 위치 조정 - 뻘짓
            int nameX = (panel_MainName.Size.Width - label_MainName.Size.Width) / 2;
            int nameY = (panel_MainName.Size.Height - label_MainName.Size.Height) / 2;
            label_MainName.Location = new Point(nameX, nameY);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Port DisConnect
            if (UART_Connect_Flag)
            {
                serialPort.Close();
                UART_Connect_Flag = false;
            }

            //DB DisConnect
            if (DB_Connect_Flag)
            {
                if (MySQL_Flag)
                {
                    MySQL_conn.Close();
                    MySQL_Flag = true;
                }
                else if (SS_Flag)
                {
                    SS_conn.Close();
                    SS_Flag = true;
                }
                DB_Connect_Flag = false;
            }
        }

        private void BTN_Enabled(Button BTN)
        {
            BTN.Enabled = true;
            BTN.BackColor = Color.FromName("GradientInactiveCaption");
        }
        private void BTNSub_Enabled(Button BTN)
        {
            BTN.Enabled = true;
            BTN.BackColor = Color.Transparent;
        }
        private void BTN_Disabled(Button BTN)
        {
            BTN.Enabled = false;
            BTN.BackColor = Color.Transparent;
        }
        private void BTN_ableCheck()
        {
            if (pictureBox_DB_Status.BackColor == Color.Green && pictureBox_Port_Status.BackColor == Color.Green)
            {
                BTN_Enabled(BTN_Monitoring_Main);
                BTN_Enabled(BTN_Work_Menu);
                BTNSub_Enabled(BTN_Work_RFID);
                BTNSub_Enabled(BTN_Work_Time);
                BTN_Enabled(BTN_Environment_Menu);
                BTNSub_Enabled(BTN_Environment_Tmp);
                BTNSub_Enabled(BTN_Environment_Appliance);
                BTN_Enabled(BTN_Product_Menu);
                BTNSub_Enabled(BTN_Product_PLC);
            }
            else
            {
                BTN_Disabled(BTN_Monitoring_Main);
                BTN_Disabled(BTN_Work_Menu);
                BTN_Disabled(BTN_Work_RFID);
                BTN_Disabled(BTN_Work_Time);
                BTN_Disabled(BTN_Environment_Menu);
                BTN_Disabled(BTN_Environment_Tmp);
                BTN_Disabled(BTN_Environment_Appliance);
                BTN_Disabled(BTN_Product_Menu);
                BTN_Disabled(BTN_Product_PLC);
            }
        }

        private void pictureBox_DB_Status_BackColorChanged(object sender, EventArgs e)
        {
            //DB, Port 둘다 연결 됬는지 확인
            BTN_ableCheck();
        }

        private void pictureBox_Port_Status_BackColorChanged(object sender, EventArgs e)
        {
            BTN_ableCheck();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        //Port 연결
        private void BTN_Port_Conn_Click(object sender, EventArgs e)
        {
            progressBar_Conn_Status.Value = 0;
            try
            {
                if (comboBox_Port.Text == "" || comboBox_BPS.Text == "")
                {
                    MessageBox.Show("UART Com Port Select" + Environment.NewLine);
                }
                else
                {
                    
                    //Port 연결
                    serialPort.PortName = comboBox_Port.Text;
                    //serialPort.BaudRate = Convert.ToInt32(comboBox_BPS.Text);
                    serialPort.Open(); //예외처리 넣기
                    progressBar_Conn_Status.Value += progressBar_Conn_Status.Maximum / 2;
                    

                    //UI 상태 변경
                    BTN_Port_Conn.Enabled = false;
                    BTN_Port_DisConn.Enabled = true;
                    pictureBox_Port_Status.BackColor = Color.Green;
                    UART_Connect_Flag = true;

                    progressBar_Conn_Status.Value = progressBar_Conn_Status.Maximum;
                }
            }
            catch (UnauthorizedAccessException)  //에러 나면
            {
                MessageBox.Show("UART Open Exception Error" + Environment.NewLine);
            }
        }

        private void BTN_Port_DisConn_Click(object sender, EventArgs e)
        {
            serialPort.Close();

            BTN_Port_Conn.Enabled = true;
            BTN_Port_DisConn.Enabled = false;
            pictureBox_Port_Status.BackColor = Color.Red;
            progressBar_Conn_Status.Value = 0;

            UART_Connect_Flag = false;

        }

        //DB 연결
        private void BTN_DB_Conn_Click(object sender, EventArgs e)
        {
            progressBar_Conn_Status.Value = 0;
            try
            {   //SQL Connect
                if (comboBox_DB.Text == "MySQL")
                {
                    progressBar_Conn_Status.Value += progressBar_Conn_Status.Maximum / 3;
                    MySQL_conn = new MySqlConnection(MySQL_connStr);
                    progressBar_Conn_Status.Value += progressBar_Conn_Status.Maximum / 3;
                    MySQL_conn.Open();
                    progressBar_Conn_Status.Value += progressBar_Conn_Status.Maximum / 3;
                    MySQL_cmd = new MySqlCommand("", MySQL_conn);

                }
                else if (comboBox_DB.Text == "SQL Server")
                {
                    progressBar_Conn_Status.Value += progressBar_Conn_Status.Maximum / 3;
                    SS_conn = new SqlConnection(SS_connStr);
                    progressBar_Conn_Status.Value += progressBar_Conn_Status.Maximum / 3;
                    SS_conn.Open();
                    progressBar_Conn_Status.Value += progressBar_Conn_Status.Maximum / 3;
                    SS_cmd = new SqlCommand("", SS_conn);
                }
                else
                    MessageBox.Show("DB서버를 선택해 주세요.");

                
                

                //UI 상태 변경
                BTN_DB_Conn.Enabled = false;
                BTN_DB_DisConn.Enabled = true;
                pictureBox_DB_Status.BackColor = Color.Green;
                DB_Connect_Flag = true;

                progressBar_Conn_Status.Value = progressBar_Conn_Status.Maximum;
            }
            catch (MySqlException)
            {
                MessageBox.Show("DB Open Exception Error" + Environment.NewLine);
            }
        }

        private void BTN_DB_DisConn_Click(object sender, EventArgs e)
        {
            if (MySQL_Flag)
            {
                MySQL_conn.Close();
                MySQL_Flag = true;
            }
            else if (SS_Flag)
            {
                SS_conn.Close();
                SS_Flag = true;
            }

            BTN_DB_Conn.Enabled = true;
            BTN_DB_DisConn.Enabled = false;
            pictureBox_DB_Status.BackColor = Color.Red;
            progressBar_Conn_Status.Value = 0;
            DB_Connect_Flag = false;
        }

        //Menu Code
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
                subMenu.Visible = true;
            else
                subMenu.Visible = false;
        }
        private void hideMenu(Panel subMenu)
        {   //if subMenu on -> Close subMenu
            if (subMenu.Visible)
                subMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            hideMenu(panel_Work_SubMenu);
            hideMenu(panel_Environment_SubMenu);
            hideMenu(panel_Product_SubMenu);
        }

        private void BTN_Work_Menu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(panel_Work_SubMenu);
        }

        private void BTN_Environment_Menu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(panel_Environment_SubMenu);
        }

        private void BTN_Product_Menu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(panel_Product_SubMenu);
        }

        private void BTN_Monitoring_Main_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (activeForm != null)
                activeForm.Close();
        }

        private void BTN_Work_RFID_Click(object sender, EventArgs e)
        {
            if(MySQL_Flag)
                rfidForm = new work_RFID_Card_Form(MySQL_connStr, MySQL_Flag, SS_Flag);
            else if(SS_Flag)
                rfidForm = new work_RFID_Card_Form(SS_connStr, MySQL_Flag, SS_Flag);

            openChildForm(rfidForm);
            rfidForm_Flag = true;
        }

        private void BTN_Work_Time_Click(object sender, EventArgs e)
        {
            workForm = new work_RFID_workcheck_Form();
            workForm_Flag = true;
            openChildForm(workForm);
        }

        private void BTN_Environment_Tmp_Click(object sender, EventArgs e)
        {
            if (MySQL_Flag)
                tmpwetForm = new environment_TmpWet_Form(MySQL_connStr, MySQL_Flag, SS_Flag);
            else if (SS_Flag)
                tmpwetForm = new environment_TmpWet_Form(SS_connStr, MySQL_Flag, SS_Flag);

            tmpwetForm.dataSendEvent += new dataEventHandler(this.formDataGet);
            openChildForm(tmpwetForm);
            tmpwetForm_Flag = true;
        }

        private void BTN_Environment_Appliance_Click(object sender, EventArgs e)
        {
            if (MySQL_Flag)
                log_Form = new environment_CheckLog_Form(MySQL_connStr, MySQL_Flag, SS_Flag);
            else if (SS_Flag)
                log_Form = new environment_CheckLog_Form(SS_connStr, MySQL_Flag, SS_Flag);

            openChildForm(log_Form);
        }

        private void BTN_Product_PLC_Click(object sender, EventArgs e)
        {

        }

        //User Code
        private void formDataGet(string item)
        {
            toolStripStatusLabel.Text = item;
        }
        private void serialPort_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            //dataIn = serialPort1.ReadExisting();    //STM32로부터 들어온 data 전부 read
            dataIn = serialPort.ReadLine();        //\n을 만날때까지 읽어들인다.
                                                   //readLine이 readExisting보다 안정적
                                                   //주의!!! 현재 BPS값(115200)으로 설정 해 놓은 상태
                                                   // 이 경우 1char당 0.1ms정도 소요되니 시간 over가 되지 않도록 프로그램작성에 유의

            this.Invoke(new EventHandler(showdata));
        }
        private void DB_Insert_Update()
        {
            if (MySQL_Flag)
            {
                MySQL_cmd.CommandText = DB_Order;
                MySQL_reader = MySQL_cmd.ExecuteReader();
                MySQL_reader.Close();
            }
            else if (SS_Flag)
            {
                SS_cmd.CommandText = DB_Order;
                SS_reader = SS_cmd.ExecuteReader();
                SS_reader.Close();
            }
        }

        int count = 0;
        private void showdata(object sender, EventArgs e)
        {
            textBox1.Text += dataIn + Environment.NewLine;
            if(count++ > 22)
            {
                textBox1.Text = "";
                count = 0;
            }

            if (dataIn.Contains("[RFID]") == true) //()안에 값이 들어왔느냐
            {   //ex. [RFID]da+d7+34+b4+8d+
                inputSensorData = dataIn.Split(']');
                //카드 코드 추출
                string[] tmpRFID = new string[5];
                string rfidResult = "";

                tmpRFID = inputSensorData[1].Split('+');
                rfidResult = tmpRFID[0] + " " + tmpRFID[1] + " " + tmpRFID[2] + " " + tmpRFID[3] + " " + tmpRFID[4];

                if (rfidForm_Flag)  //rfidForm이 켜져있는지 체크
                {   
                    rfidForm.label_Card_CardCode.Text = rfidResult;
                    rfidForm.TB_UserSet_CardCode.Text = rfidResult;
                }
                if (workForm_Flag)
                {
                    workForm.label_CardCode.Text = rfidResult;
                }

                //사용중인 카드인지 체크
                //SELECT rf_able FROM tbl_rfid WHERE rf_code = 'aa aa ac aa aa'
                DB_Order = "SELECT rf_able FROM tbl_rfid WHERE rf_code = '" + rfidResult + "'";
                
                string rf_able = "";
                if (MySQL_Flag)
                {
                    MySQL_cmd.CommandText = DB_Order;
                    MySQL_reader = MySQL_cmd.ExecuteReader();

                    /*
                     rf_code VARCHAR(14) NOT NULL PRIMARY KEY,
                     rf_able VARCHAR(6) NOT NULL
                     */
                    

                    while (MySQL_reader.Read())
                    {
                        rf_able = (string)MySQL_reader["rf_able"];
                    }

                    MySQL_reader.Close();
                }
                else if(SS_Flag)
                {
                    SS_cmd.CommandText = DB_Order;
                    SS_reader = SS_cmd.ExecuteReader();

                    /*
                     rf_code VARCHAR(14) NOT NULL PRIMARY KEY,
                     rf_able VARCHAR(6) NOT NULL
                     */


                    while (SS_reader.Read())
                    {
                        rf_able = (string)SS_reader["rf_able"];
                    }

                    SS_reader.Close();
                }
                if(rf_able == "사용중")
                {
                    toolStripStatusLabel.Text = "<Door>Open";
                }
            }
            if (dataIn.Contains("[Tmp]") == true)
            {
                //[Tmp]00
                inputSensorData = dataIn.Split(']');

                if (tmpwetForm_Flag)
                {   //다른 폼에 온도 전송
                    tmpwetForm.label_Room1_Tmp.Text = inputSensorData[1];
                }

                //DB에 온도 전송 준비
                try
                {
                    curTmp = Convert.ToInt32(inputSensorData[1]);
                }
                catch { }

            }
            if (dataIn.Contains("[Wet]") == true)
            {
                //[Wet]00
                inputSensorData = dataIn.Split(']');

                if (tmpwetForm_Flag)
                {   //다른폼에 습도 전송
                    tmpwetForm.label_Room1_Wet.Text = inputSensorData[1];
                }

                //DB에 습도 전송 준비
                try
                {
                    curWet = Convert.ToInt32(inputSensorData[1]);
                }
                catch { }
            }
            if (dataIn.Contains("[Door]") == true)
            {
                /*
                 * [Door]Close+MySQL_cmd
                 * [Door]Close+time
                 * [Door]Open
                 */
                inputSensorData = dataIn.Split(']');

                if (inputSensorData[1].Contains("+"))
                {   //Door Close
                    string[] doorData = inputSensorData[1].Split('+');

                    if(doorData[1] == "asdfasdfcmd")
                    {   //수동 닫기 시
                    }
                    else if(doorData[1] == "time")
                    {   //시간초과 닫기 시

                        //UPDATE Tbl_door SET d_closeTime = '2021-05-16 12:00:10' WHERE d_closeTime IS NULL
                        DB_Order = "UPDATE Tbl_door SET d_closeTime = '" +
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE d_closeTime IS NULL";

                        DB_Insert_Update();
                    }
                }
                else //Door Open
                {
                    //INSERT INTO Tbl_door(d_openTime) VALUES('2021-05-16 12:00:00')
                    DB_Order = "INSERT INTO Tbl_door(d_openTime) VALUES('" +
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

                    DB_Insert_Update();
                }
            }
            if (dataIn.Contains("[FAN]") == true)
            {
                //[FAN]On

            }

        }
        private void insert_tmpwet()
        {
            //INSERT INTO Tbl_TmpWet VALUES ('2021-05-13 12:00:00', 22, 33)
            DB_Order = "INSERT INTO Tbl_TmpWet VALUES ('" +
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', " +  //2021-05-13 12:00:00
                curTmp + ", " +
                curWet + ")";

            DB_Insert_Update();
        }
        private void timer_DB_Tick(object sender, EventArgs e)
        {
            if (DB_Connect_Flag)
                if (curTmp != 0 && curWet != 0)
                {
                    if (DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
                    {   //정각 전송
                        insert_tmpwet();
                    }
                    else if (pastTmp != 0 && pastWet != 0)
                    {
                        if (pastTmp != curTmp || pastWet != curWet)
                        {   //온습도 변화시 전송
                            insert_tmpwet();
                        }
                    }

                    pastTmp = curTmp;
                    pastWet = curWet;
                }
        }

        private void toolStripStatusLabel_TextChanged(object sender, EventArgs e)
        {
            if (toolStripStatusLabel.Text == "<FAN>on") 
                serialPort.WriteLine("FAN_on" + Environment.NewLine);
            else if(toolStripStatusLabel.Text == "<FAN>off")
                serialPort.WriteLine("FAN_off" + Environment.NewLine);
            else if(toolStripStatusLabel.Text == "<Door>Open")
                serialPort.WriteLine("servo_on" + Environment.NewLine);

            toolStripStatusLabel.Text = "waiting";

        }
    }
}
