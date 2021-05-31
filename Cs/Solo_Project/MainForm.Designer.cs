
namespace Solo_Project
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_MainName = new System.Windows.Forms.Panel();
            this.label_MainName = new System.Windows.Forms.Label();
            this.panel_SideMenu = new System.Windows.Forms.Panel();
            this.panel_Product_SubMenu = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BTN_Product_PLC = new System.Windows.Forms.Button();
            this.BTN_Product_Menu = new System.Windows.Forms.Button();
            this.panel_Environment_SubMenu = new System.Windows.Forms.Panel();
            this.BTN_Environment_Appliance = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BTN_Environment_Tmp = new System.Windows.Forms.Button();
            this.BTN_Environment_Menu = new System.Windows.Forms.Button();
            this.panel_Work_SubMenu = new System.Windows.Forms.Panel();
            this.BTN_Work_Time = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Work_RFID = new System.Windows.Forms.Button();
            this.BTN_Work_Menu = new System.Windows.Forms.Button();
            this.BTN_Monitoring_Main = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox_DB_Status = new System.Windows.Forms.PictureBox();
            this.pictureBox_Port_Status = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.BTN_DB_DisConn = new System.Windows.Forms.Button();
            this.BTN_DB_Conn = new System.Windows.Forms.Button();
            this.progressBar_Conn_Status = new System.Windows.Forms.ProgressBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BTN_Port_DisConn = new System.Windows.Forms.Button();
            this.BTN_Port_Conn = new System.Windows.Forms.Button();
            this.comboBox_BPS = new System.Windows.Forms.ComboBox();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer_DB = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBox_DB = new System.Windows.Forms.ComboBox();
            this.panel_MainName.SuspendLayout();
            this.panel_SideMenu.SuspendLayout();
            this.panel_Product_SubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_Environment_SubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_Work_SubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DB_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Port_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MainName
            // 
            this.panel_MainName.Controls.Add(this.label_MainName);
            this.panel_MainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_MainName.Location = new System.Drawing.Point(0, 0);
            this.panel_MainName.Name = "panel_MainName";
            this.panel_MainName.Size = new System.Drawing.Size(1000, 50);
            this.panel_MainName.TabIndex = 0;
            // 
            // label_MainName
            // 
            this.label_MainName.AutoSize = true;
            this.label_MainName.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.label_MainName.Location = new System.Drawing.Point(399, 9);
            this.label_MainName.Name = "label_MainName";
            this.label_MainName.Size = new System.Drawing.Size(202, 34);
            this.label_MainName.TabIndex = 15;
            this.label_MainName.Text = "관리 시스템";
            // 
            // panel_SideMenu
            // 
            this.panel_SideMenu.Controls.Add(this.panel_Product_SubMenu);
            this.panel_SideMenu.Controls.Add(this.BTN_Product_Menu);
            this.panel_SideMenu.Controls.Add(this.panel_Environment_SubMenu);
            this.panel_SideMenu.Controls.Add(this.BTN_Environment_Menu);
            this.panel_SideMenu.Controls.Add(this.panel_Work_SubMenu);
            this.panel_SideMenu.Controls.Add(this.BTN_Work_Menu);
            this.panel_SideMenu.Controls.Add(this.BTN_Monitoring_Main);
            this.panel_SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SideMenu.Location = new System.Drawing.Point(0, 50);
            this.panel_SideMenu.Name = "panel_SideMenu";
            this.panel_SideMenu.Size = new System.Drawing.Size(200, 610);
            this.panel_SideMenu.TabIndex = 1;
            // 
            // panel_Product_SubMenu
            // 
            this.panel_Product_SubMenu.Controls.Add(this.pictureBox3);
            this.panel_Product_SubMenu.Controls.Add(this.BTN_Product_PLC);
            this.panel_Product_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Product_SubMenu.Location = new System.Drawing.Point(0, 420);
            this.panel_Product_SubMenu.Name = "panel_Product_SubMenu";
            this.panel_Product_SubMenu.Size = new System.Drawing.Size(200, 60);
            this.panel_Product_SubMenu.TabIndex = 6;
            this.panel_Product_SubMenu.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Location = new System.Drawing.Point(0, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 10);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // BTN_Product_PLC
            // 
            this.BTN_Product_PLC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_Product_PLC.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Product_PLC.Location = new System.Drawing.Point(0, 0);
            this.BTN_Product_PLC.Name = "BTN_Product_PLC";
            this.BTN_Product_PLC.Size = new System.Drawing.Size(200, 50);
            this.BTN_Product_PLC.TabIndex = 3;
            this.BTN_Product_PLC.Text = "PLC모니터링";
            this.BTN_Product_PLC.UseVisualStyleBackColor = false;
            this.BTN_Product_PLC.Click += new System.EventHandler(this.BTN_Product_PLC_Click);
            // 
            // BTN_Product_Menu
            // 
            this.BTN_Product_Menu.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Product_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Product_Menu.Enabled = false;
            this.BTN_Product_Menu.Location = new System.Drawing.Point(0, 370);
            this.BTN_Product_Menu.Name = "BTN_Product_Menu";
            this.BTN_Product_Menu.Size = new System.Drawing.Size(200, 50);
            this.BTN_Product_Menu.TabIndex = 6;
            this.BTN_Product_Menu.Text = "생산관리";
            this.BTN_Product_Menu.UseVisualStyleBackColor = false;
            this.BTN_Product_Menu.Click += new System.EventHandler(this.BTN_Product_Menu_Click);
            // 
            // panel_Environment_SubMenu
            // 
            this.panel_Environment_SubMenu.Controls.Add(this.BTN_Environment_Appliance);
            this.panel_Environment_SubMenu.Controls.Add(this.pictureBox2);
            this.panel_Environment_SubMenu.Controls.Add(this.BTN_Environment_Tmp);
            this.panel_Environment_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Environment_SubMenu.Location = new System.Drawing.Point(0, 260);
            this.panel_Environment_SubMenu.Name = "panel_Environment_SubMenu";
            this.panel_Environment_SubMenu.Size = new System.Drawing.Size(200, 110);
            this.panel_Environment_SubMenu.TabIndex = 5;
            this.panel_Environment_SubMenu.Visible = false;
            // 
            // BTN_Environment_Appliance
            // 
            this.BTN_Environment_Appliance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_Environment_Appliance.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Environment_Appliance.Location = new System.Drawing.Point(0, 50);
            this.BTN_Environment_Appliance.Name = "BTN_Environment_Appliance";
            this.BTN_Environment_Appliance.Size = new System.Drawing.Size(200, 50);
            this.BTN_Environment_Appliance.TabIndex = 5;
            this.BTN_Environment_Appliance.Text = "로그 확인";
            this.BTN_Environment_Appliance.UseVisualStyleBackColor = false;
            this.BTN_Environment_Appliance.Click += new System.EventHandler(this.BTN_Environment_Appliance_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 10);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // BTN_Environment_Tmp
            // 
            this.BTN_Environment_Tmp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_Environment_Tmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Environment_Tmp.Location = new System.Drawing.Point(0, 0);
            this.BTN_Environment_Tmp.Name = "BTN_Environment_Tmp";
            this.BTN_Environment_Tmp.Size = new System.Drawing.Size(200, 50);
            this.BTN_Environment_Tmp.TabIndex = 3;
            this.BTN_Environment_Tmp.Text = "온습도관리";
            this.BTN_Environment_Tmp.UseVisualStyleBackColor = false;
            this.BTN_Environment_Tmp.Click += new System.EventHandler(this.BTN_Environment_Tmp_Click);
            // 
            // BTN_Environment_Menu
            // 
            this.BTN_Environment_Menu.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Environment_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Environment_Menu.Enabled = false;
            this.BTN_Environment_Menu.Location = new System.Drawing.Point(0, 210);
            this.BTN_Environment_Menu.Name = "BTN_Environment_Menu";
            this.BTN_Environment_Menu.Size = new System.Drawing.Size(200, 50);
            this.BTN_Environment_Menu.TabIndex = 3;
            this.BTN_Environment_Menu.Text = "환경관리";
            this.BTN_Environment_Menu.UseVisualStyleBackColor = false;
            this.BTN_Environment_Menu.Click += new System.EventHandler(this.BTN_Environment_Menu_Click);
            // 
            // panel_Work_SubMenu
            // 
            this.panel_Work_SubMenu.Controls.Add(this.BTN_Work_Time);
            this.panel_Work_SubMenu.Controls.Add(this.pictureBox1);
            this.panel_Work_SubMenu.Controls.Add(this.BTN_Work_RFID);
            this.panel_Work_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Work_SubMenu.Location = new System.Drawing.Point(0, 100);
            this.panel_Work_SubMenu.Name = "panel_Work_SubMenu";
            this.panel_Work_SubMenu.Size = new System.Drawing.Size(200, 110);
            this.panel_Work_SubMenu.TabIndex = 2;
            this.panel_Work_SubMenu.Visible = false;
            // 
            // BTN_Work_Time
            // 
            this.BTN_Work_Time.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_Work_Time.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Work_Time.Location = new System.Drawing.Point(0, 50);
            this.BTN_Work_Time.Name = "BTN_Work_Time";
            this.BTN_Work_Time.Size = new System.Drawing.Size(200, 50);
            this.BTN_Work_Time.TabIndex = 5;
            this.BTN_Work_Time.Text = "근무시간 모니터링";
            this.BTN_Work_Time.UseVisualStyleBackColor = false;
            this.BTN_Work_Time.Click += new System.EventHandler(this.BTN_Work_Time_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 10);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Work_RFID
            // 
            this.BTN_Work_RFID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_Work_RFID.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Work_RFID.Location = new System.Drawing.Point(0, 0);
            this.BTN_Work_RFID.Name = "BTN_Work_RFID";
            this.BTN_Work_RFID.Size = new System.Drawing.Size(200, 50);
            this.BTN_Work_RFID.TabIndex = 3;
            this.BTN_Work_RFID.Text = "RFID카드 관리";
            this.BTN_Work_RFID.UseVisualStyleBackColor = false;
            this.BTN_Work_RFID.Click += new System.EventHandler(this.BTN_Work_RFID_Click);
            // 
            // BTN_Work_Menu
            // 
            this.BTN_Work_Menu.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Work_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Work_Menu.Enabled = false;
            this.BTN_Work_Menu.Location = new System.Drawing.Point(0, 50);
            this.BTN_Work_Menu.Name = "BTN_Work_Menu";
            this.BTN_Work_Menu.Size = new System.Drawing.Size(200, 50);
            this.BTN_Work_Menu.TabIndex = 1;
            this.BTN_Work_Menu.Text = "근태관리";
            this.BTN_Work_Menu.UseVisualStyleBackColor = false;
            this.BTN_Work_Menu.Click += new System.EventHandler(this.BTN_Work_Menu_Click);
            // 
            // BTN_Monitoring_Main
            // 
            this.BTN_Monitoring_Main.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Monitoring_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Monitoring_Main.Enabled = false;
            this.BTN_Monitoring_Main.Location = new System.Drawing.Point(0, 0);
            this.BTN_Monitoring_Main.Name = "BTN_Monitoring_Main";
            this.BTN_Monitoring_Main.Size = new System.Drawing.Size(200, 50);
            this.BTN_Monitoring_Main.TabIndex = 0;
            this.BTN_Monitoring_Main.Text = "전체 모니터링";
            this.BTN_Monitoring_Main.UseVisualStyleBackColor = false;
            this.BTN_Monitoring_Main.Click += new System.EventHandler(this.BTN_Monitoring_Main_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox_DB);
            this.panel3.Controls.Add(this.pictureBox_DB_Status);
            this.panel3.Controls.Add(this.pictureBox_Port_Status);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.BTN_DB_DisConn);
            this.panel3.Controls.Add(this.BTN_DB_Conn);
            this.panel3.Controls.Add(this.progressBar_Conn_Status);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.BTN_Port_DisConn);
            this.panel3.Controls.Add(this.BTN_Port_Conn);
            this.panel3.Controls.Add(this.comboBox_BPS);
            this.panel3.Controls.Add(this.comboBox_Port);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 110);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox_DB_Status
            // 
            this.pictureBox_DB_Status.BackColor = System.Drawing.Color.Red;
            this.pictureBox_DB_Status.Location = new System.Drawing.Point(746, 51);
            this.pictureBox_DB_Status.Name = "pictureBox_DB_Status";
            this.pictureBox_DB_Status.Size = new System.Drawing.Size(31, 30);
            this.pictureBox_DB_Status.TabIndex = 14;
            this.pictureBox_DB_Status.TabStop = false;
            this.pictureBox_DB_Status.BackColorChanged += new System.EventHandler(this.pictureBox_DB_Status_BackColorChanged);
            // 
            // pictureBox_Port_Status
            // 
            this.pictureBox_Port_Status.BackColor = System.Drawing.Color.Red;
            this.pictureBox_Port_Status.Location = new System.Drawing.Point(746, 8);
            this.pictureBox_Port_Status.Name = "pictureBox_Port_Status";
            this.pictureBox_Port_Status.Size = new System.Drawing.Size(31, 30);
            this.pictureBox_Port_Status.TabIndex = 13;
            this.pictureBox_Port_Status.TabStop = false;
            this.pictureBox_Port_Status.BackColorChanged += new System.EventHandler(this.pictureBox_Port_Status_BackColorChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(688, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "DB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(683, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Port";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox5.Location = new System.Drawing.Point(647, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 90);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // BTN_DB_DisConn
            // 
            this.BTN_DB_DisConn.Enabled = false;
            this.BTN_DB_DisConn.Font = new System.Drawing.Font("굴림", 11F);
            this.BTN_DB_DisConn.Location = new System.Drawing.Point(542, 11);
            this.BTN_DB_DisConn.Name = "BTN_DB_DisConn";
            this.BTN_DB_DisConn.Size = new System.Drawing.Size(99, 64);
            this.BTN_DB_DisConn.TabIndex = 9;
            this.BTN_DB_DisConn.Text = "DB\r\n연결해제";
            this.BTN_DB_DisConn.UseVisualStyleBackColor = true;
            this.BTN_DB_DisConn.Click += new System.EventHandler(this.BTN_DB_DisConn_Click);
            // 
            // BTN_DB_Conn
            // 
            this.BTN_DB_Conn.Font = new System.Drawing.Font("굴림", 11F);
            this.BTN_DB_Conn.Location = new System.Drawing.Point(437, 43);
            this.BTN_DB_Conn.Name = "BTN_DB_Conn";
            this.BTN_DB_Conn.Size = new System.Drawing.Size(99, 32);
            this.BTN_DB_Conn.TabIndex = 8;
            this.BTN_DB_Conn.Text = "DB\r\n연결";
            this.BTN_DB_Conn.UseVisualStyleBackColor = true;
            this.BTN_DB_Conn.Click += new System.EventHandler(this.BTN_DB_Conn_Click);
            // 
            // progressBar_Conn_Status
            // 
            this.progressBar_Conn_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_Conn_Status.Location = new System.Drawing.Point(0, 90);
            this.progressBar_Conn_Status.Name = "progressBar_Conn_Status";
            this.progressBar_Conn_Status.Size = new System.Drawing.Size(800, 20);
            this.progressBar_Conn_Status.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox4.Location = new System.Drawing.Point(421, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 90);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // BTN_Port_DisConn
            // 
            this.BTN_Port_DisConn.Enabled = false;
            this.BTN_Port_DisConn.Font = new System.Drawing.Font("굴림", 11F);
            this.BTN_Port_DisConn.Location = new System.Drawing.Point(313, 11);
            this.BTN_Port_DisConn.Name = "BTN_Port_DisConn";
            this.BTN_Port_DisConn.Size = new System.Drawing.Size(99, 64);
            this.BTN_Port_DisConn.TabIndex = 5;
            this.BTN_Port_DisConn.Text = "Port\r\n연결해제";
            this.BTN_Port_DisConn.UseVisualStyleBackColor = true;
            this.BTN_Port_DisConn.Click += new System.EventHandler(this.BTN_Port_DisConn_Click);
            // 
            // BTN_Port_Conn
            // 
            this.BTN_Port_Conn.Font = new System.Drawing.Font("굴림", 11F);
            this.BTN_Port_Conn.Location = new System.Drawing.Point(208, 11);
            this.BTN_Port_Conn.Name = "BTN_Port_Conn";
            this.BTN_Port_Conn.Size = new System.Drawing.Size(99, 64);
            this.BTN_Port_Conn.TabIndex = 4;
            this.BTN_Port_Conn.Text = "Port\r\n연결";
            this.BTN_Port_Conn.UseVisualStyleBackColor = true;
            this.BTN_Port_Conn.Click += new System.EventHandler(this.BTN_Port_Conn_Click);
            // 
            // comboBox_BPS
            // 
            this.comboBox_BPS.Font = new System.Drawing.Font("굴림", 12F);
            this.comboBox_BPS.FormattingEnabled = true;
            this.comboBox_BPS.Location = new System.Drawing.Point(81, 48);
            this.comboBox_BPS.Name = "comboBox_BPS";
            this.comboBox_BPS.Size = new System.Drawing.Size(121, 28);
            this.comboBox_BPS.TabIndex = 3;
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.Font = new System.Drawing.Font("굴림", 12F);
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(81, 10);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Port.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BPS :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port :";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.textBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 160);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(800, 500);
            this.panelChildForm.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(628, 360);
            this.textBox1.TabIndex = 0;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived_1);
            // 
            // timer_DB
            // 
            this.timer_DB.Enabled = true;
            this.timer_DB.Interval = 1000;
            this.timer_DB.Tick += new System.EventHandler(this.timer_DB_Tick);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(200, 634);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 26);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(117, 20);
            this.toolStripStatusLabel.Text = "from_otherForm";
            this.toolStripStatusLabel.TextChanged += new System.EventHandler(this.toolStripStatusLabel_TextChanged);
            // 
            // comboBox_DB
            // 
            this.comboBox_DB.Font = new System.Drawing.Font("굴림", 12F);
            this.comboBox_DB.FormattingEnabled = true;
            this.comboBox_DB.Items.AddRange(new object[] {
            "MySQL",
            "SQL Server"});
            this.comboBox_DB.Location = new System.Drawing.Point(437, 11);
            this.comboBox_DB.Name = "comboBox_DB";
            this.comboBox_DB.Size = new System.Drawing.Size(99, 28);
            this.comboBox_DB.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_SideMenu);
            this.Controls.Add(this.panel_MainName);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_MainName.ResumeLayout(false);
            this.panel_MainName.PerformLayout();
            this.panel_SideMenu.ResumeLayout(false);
            this.panel_Product_SubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_Environment_SubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_Work_SubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DB_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Port_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_MainName;
        private System.Windows.Forms.Panel panel_SideMenu;
        private System.Windows.Forms.Panel panel_Product_SubMenu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BTN_Product_PLC;
        private System.Windows.Forms.Button BTN_Product_Menu;
        private System.Windows.Forms.Panel panel_Environment_SubMenu;
        private System.Windows.Forms.Button BTN_Environment_Appliance;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BTN_Environment_Tmp;
        private System.Windows.Forms.Button BTN_Environment_Menu;
        private System.Windows.Forms.Panel panel_Work_SubMenu;
        private System.Windows.Forms.Button BTN_Work_Time;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Work_RFID;
        private System.Windows.Forms.Button BTN_Work_Menu;
        private System.Windows.Forms.Button BTN_Monitoring_Main;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button BTN_DB_DisConn;
        private System.Windows.Forms.Button BTN_DB_Conn;
        private System.Windows.Forms.ProgressBar progressBar_Conn_Status;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BTN_Port_DisConn;
        private System.Windows.Forms.Button BTN_Port_Conn;
        private System.Windows.Forms.ComboBox comboBox_BPS;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_MainName;
        public System.Windows.Forms.PictureBox pictureBox_DB_Status;
        public System.Windows.Forms.PictureBox pictureBox_Port_Status;
        private System.Windows.Forms.Timer timer_DB;
        public System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox_DB;
    }
}

