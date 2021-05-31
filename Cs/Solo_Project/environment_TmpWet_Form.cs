using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//user Add
using System.Data.SqlClient;    //Add for MySQL
using MySql.Data.MySqlClient;   //Add for MySQL

/*
 * 해야할 목록
 * 1. [버그] Port 연결 중간에 끊으면 마지막 데이터 계속 받아옴
 */

namespace Solo_Project
{
    public delegate void dataEventHandler(string data);

    public partial class environment_TmpWet_Form : Form
    {
        public dataEventHandler dataSendEvent;
        //DB
        string tmpwet_connStr;
        string tmpwet_sql = "";  // 물건박스
        bool mysql_flag;
        bool ss_flag;

        //MySQL
        public MySqlConnection MySQL_tmpwet_conn;
        MySqlCommand MySQL_tmpwet_cmd;
        MySqlDataReader MySQL_tmpwet_reader; // 트럭이 가져올 끈
        //SQL Server
        public MySqlConnection SS_tmpwet_conn;
        MySqlCommand SS_tmpwet_cmd;
        MySqlDataReader SS_tmpwet_reader; // 트럭이 가져올 끈

        string tableName_desTmpWet = "Tbl_desTmpWet";

        //App Data
        int[] temperAry_Room1 = new int[30];
        int[] wetAry_Room1 = new int[30];

        public environment_TmpWet_Form(string connstr, bool MySQL_Flag, bool SS_Flag)
        {
            tmpwet_connStr = connstr;
            mysql_flag = MySQL_Flag;
            ss_flag = SS_Flag;

            InitializeComponent();
        }
        private void environment_TmpWet_Form_Load(object sender, EventArgs e)
        {
            //DB connect
            //MySQL
            if (mysql_flag)
            {
                MySQL_tmpwet_conn = new MySqlConnection(tmpwet_connStr);
                MySQL_tmpwet_conn.Open();
                MySQL_tmpwet_cmd = new MySqlCommand("", MySQL_tmpwet_conn);

                //실행시 희망온습도 불러오기
                //SELECT * FROM Tbl_desTmpWet ORDER BY des_time DESC LIMIT 1
                MySQL_tmpwet_cmd.CommandText = "SELECT * FROM " + tableName_desTmpWet +
                    " ORDER BY des_time DESC LIMIT 1";
                MySQL_tmpwet_reader = MySQL_tmpwet_cmd.ExecuteReader();
                while (MySQL_tmpwet_reader.Read())
                {
                    int des_tmp = Convert.ToInt32(MySQL_tmpwet_reader["des_tmp"]);
                    int des_wet = Convert.ToInt32(MySQL_tmpwet_reader["des_wet"]);

                    label_Setting_Room1_desTmp.Text = des_tmp.ToString();
                    label_Setting_Room1_desWet.Text = des_wet.ToString();
                }

                MySQL_tmpwet_reader.Close();
            }
            else if (ss_flag)
            {
                SS_tmpwet_conn = new MySqlConnection(tmpwet_connStr);
                SS_tmpwet_conn.Open();
                SS_tmpwet_cmd = new MySqlCommand("", SS_tmpwet_conn);

                //실행시 희망온습도 불러오기
                //SELECT * FROM Tbl_desTmpWet ORDER BY des_time DESC LIMIT 1
                SS_tmpwet_cmd.CommandText = "SELECT * FROM " + tableName_desTmpWet +
                    " ORDER BY des_time DESC LIMIT 1";
                SS_tmpwet_reader = SS_tmpwet_cmd.ExecuteReader();
                while (SS_tmpwet_reader.Read())
                {
                    int des_tmp = Convert.ToInt32(SS_tmpwet_reader["des_tmp"]);
                    int des_wet = Convert.ToInt32(SS_tmpwet_reader["des_wet"]);

                    label_Setting_Room1_desTmp.Text = des_tmp.ToString();
                    label_Setting_Room1_desWet.Text = des_wet.ToString();
                }

                SS_tmpwet_reader.Close();
            }
        }
        private void environment_TmpWet_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int curTmp, curWet;
            try
            {
                curTmp = Convert.ToInt32(label_Room1_Tmp.Text);
                curWet = Convert.ToInt32(label_Room1_Wet.Text);
            }
            catch { curTmp = curWet = 0; }

            //Main
            //상태창 Start
            label_Setting_Room1_curTmp.Text = curTmp.ToString();
            label_Setting_Room1_curWet.Text = curWet.ToString();
            //상태창 End

            //Room1
            //그래프 Start
            //실시간 불러왔을때 가장 오래된 데이터 지우고 새로 받을 준비
            for (int i = 0; i < temperAry_Room1.Length - 1; i++)
            {
                temperAry_Room1[i] = temperAry_Room1[i + 1];
                wetAry_Room1[i] = wetAry_Room1[i + 1];
            }
            //배열 마지막에 최신데이터 삽입

            temperAry_Room1[temperAry_Room1.Length - 1] = curTmp;
            wetAry_Room1[wetAry_Room1.Length - 1] = curWet;

            //초기화   1
            chart_Room1.Series[0].Points.Clear();
            chart_Room1.Series[1].Points.Clear();

            //그리기
            for (int i = 0; i < temperAry_Room1.Length - 1; i++)
            {
                chart_Room1.Series[0].Points.AddXY(i, temperAry_Room1[i]);
                chart_Room1.Series[1].Points.AddXY(i, wetAry_Room1[i]);
            }
            //그래프 End

            //표 Start
            ListViewItem item;

            if (listView_Room1.Items.Count > 30)
            {   //30개만 출력
                listView_Room1.Items.RemoveAt(0);
            }

            item = new ListViewItem();
            item.SubItems.Add(DateTime.Now.ToString());
            item.SubItems.Add(label_Room1_Tmp.Text);
            item.SubItems.Add(label_Room1_Wet.Text);

            listView_Room1.Items.Add(item);
            //표 End

            //기계 작동 상태 변경 Start
            int desTmp, desWet;
            try
            {
                desTmp = Convert.ToInt32(label_Setting_Room1_desTmp.Text);
                desWet = Convert.ToInt32(label_Setting_Room1_desWet.Text);
            }
            catch { desTmp = desWet = 0; }

            if(curTmp < desTmp) //온도
                pictureBox_Setting_Room1_Machine.BackColor = Color.Red;
            else if (curTmp > desTmp)
                pictureBox_Setting_Room1_Machine.BackColor = Color.Blue;
            else
                pictureBox_Setting_Room1_Machine.BackColor = Color.Transparent;

            if (curWet > desWet) //습도
                pictureBox_Setting_Room1_FAN.BackColor = Color.Green;
            else
                pictureBox_Setting_Room1_FAN.BackColor = Color.Transparent;
            //상태 End
        }

        private void comboBox_Setting_Location_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Setting_Location.Text == "Room1")
            {
                comboBox_Setting_Fuction.Items.Add("온도");
                comboBox_Setting_Fuction.Items.Add("습도");
            }

            comboBox_Setting_Fuction.Enabled = true;
        }
        private void comboBox_Setting_Fuction_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_Setting_Desire.Enabled = true;

            if (comboBox_Setting_Fuction.Text == "습도")
            {
                label_Setting_Desire.Text = "희망 습도";
            }
            else if (comboBox_Setting_Fuction.Text == "온도")
            {
                label_Setting_Desire.Text = "희망 온도";
            }
        }

        private void BTN_Setting_Change_Click(object sender, EventArgs e)
        {
            bool check_value = false;  //정상 값 입력 확인
            if (comboBox_Setting_Location.Text == "Room1")
            {
                try
                {
                    int tmpint = Convert.ToInt32(label_Setting_Room1_desTmp.Text);
                    check_value = true;
                }
                catch
                {
                    check_value = false;
                    MessageBox.Show("숫자만 입력하세요");
                }
                if (check_value)
                {
                    if (comboBox_Setting_Fuction.Text == "온도")
                    {
                        label_Setting_Room1_desTmp.Text = TB_Setting_Desire.Text;
                    }
                    else if (comboBox_Setting_Fuction.Text == "습도")
                    {
                        label_Setting_Room1_desWet.Text = TB_Setting_Desire.Text;
                    }

                    //INSERT INTO Tbl_desTmpWet VALUES ('2021-05-13 15:00:02', 22, 33)
                    tmpwet_sql = "INSERT INTO " + tableName_desTmpWet + 
                        " VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + 
                        "', " + label_Setting_Room1_desTmp.Text + 
                        ", " + label_Setting_Room1_desWet.Text + ")";

                    if (mysql_flag)
                    {
                        MySQL_tmpwet_cmd.CommandText = tmpwet_sql;
                        MySQL_tmpwet_reader = MySQL_tmpwet_cmd.ExecuteReader();
                        MySQL_tmpwet_reader.Close();
                    }
                    else if (ss_flag)
                    {
                        SS_tmpwet_cmd.CommandText = tmpwet_sql;
                        SS_tmpwet_reader = SS_tmpwet_cmd.ExecuteReader();
                        SS_tmpwet_reader.Close();
                    }
                }
            }
        }
        private void pictureBox_Setting_Room1_FAN_BackColorChanged(object sender, EventArgs e)
        {
            if (pictureBox_Setting_Room1_FAN.BackColor == Color.Green)
                dataSendEvent("<FAN>on");
            else
                dataSendEvent("<FAN>off");

        }
    }
}
