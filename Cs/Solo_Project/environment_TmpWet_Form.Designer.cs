
namespace Solo_Project
{
    partial class environment_TmpWet_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Control = new System.Windows.Forms.TabPage();
            this.BTN_Setting_Change = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Setting_Room1_curWet = new System.Windows.Forms.Label();
            this.label_Setting_Room1_desWet = new System.Windows.Forms.Label();
            this.label_Setting_Room1_curTmp = new System.Windows.Forms.Label();
            this.label_Setting_Room1_desTmp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox_Setting_Room1_FAN = new System.Windows.Forms.PictureBox();
            this.pictureBox_Setting_Room1_Machine = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_Setting_Desire = new System.Windows.Forms.TextBox();
            this.label_Setting_Desire = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Setting_Fuction = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Setting_Location = new System.Windows.Forms.ComboBox();
            this.tabPage_Room1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_Room1 = new System.Windows.Forms.ListView();
            this.columnHeader_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Tmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Wet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chart_Room1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Room1_Wet = new System.Windows.Forms.Label();
            this.label_Room1_Tmp = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_Control.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Setting_Room1_FAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Setting_Room1_Machine)).BeginInit();
            this.tabPage_Room1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Room1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Control);
            this.tabControl1.Controls.Add(this.tabPage_Room1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Control
            // 
            this.tabPage_Control.Controls.Add(this.BTN_Setting_Change);
            this.tabPage_Control.Controls.Add(this.panel2);
            this.tabPage_Control.Controls.Add(this.TB_Setting_Desire);
            this.tabPage_Control.Controls.Add(this.label_Setting_Desire);
            this.tabPage_Control.Controls.Add(this.label6);
            this.tabPage_Control.Controls.Add(this.comboBox_Setting_Fuction);
            this.tabPage_Control.Controls.Add(this.label5);
            this.tabPage_Control.Controls.Add(this.comboBox_Setting_Location);
            this.tabPage_Control.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Control.Name = "tabPage_Control";
            this.tabPage_Control.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Control.Size = new System.Drawing.Size(792, 471);
            this.tabPage_Control.TabIndex = 2;
            this.tabPage_Control.Text = "설정";
            this.tabPage_Control.UseVisualStyleBackColor = true;
            // 
            // BTN_Setting_Change
            // 
            this.BTN_Setting_Change.Font = new System.Drawing.Font("굴림", 11F);
            this.BTN_Setting_Change.Location = new System.Drawing.Point(131, 305);
            this.BTN_Setting_Change.Name = "BTN_Setting_Change";
            this.BTN_Setting_Change.Size = new System.Drawing.Size(75, 32);
            this.BTN_Setting_Change.TabIndex = 10;
            this.BTN_Setting_Change.Text = "수정";
            this.BTN_Setting_Change.UseVisualStyleBackColor = true;
            this.BTN_Setting_Change.Click += new System.EventHandler(this.BTN_Setting_Change_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(422, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 465);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Setting_Room1_curWet);
            this.panel1.Controls.Add(this.label_Setting_Room1_desWet);
            this.panel1.Controls.Add(this.label_Setting_Room1_curTmp);
            this.panel1.Controls.Add(this.label_Setting_Room1_desTmp);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.pictureBox_Setting_Room1_FAN);
            this.panel1.Controls.Add(this.pictureBox_Setting_Room1_Machine);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 216);
            this.panel1.TabIndex = 8;
            // 
            // label_Setting_Room1_curWet
            // 
            this.label_Setting_Room1_curWet.Font = new System.Drawing.Font("굴림", 11F);
            this.label_Setting_Room1_curWet.Location = new System.Drawing.Point(30, 163);
            this.label_Setting_Room1_curWet.Name = "label_Setting_Room1_curWet";
            this.label_Setting_Room1_curWet.Size = new System.Drawing.Size(91, 20);
            this.label_Setting_Room1_curWet.TabIndex = 23;
            this.label_Setting_Room1_curWet.Text = "curWet";
            this.label_Setting_Room1_curWet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Setting_Room1_desWet
            // 
            this.label_Setting_Room1_desWet.Font = new System.Drawing.Font("굴림", 11F);
            this.label_Setting_Room1_desWet.Location = new System.Drawing.Point(127, 163);
            this.label_Setting_Room1_desWet.Name = "label_Setting_Room1_desWet";
            this.label_Setting_Room1_desWet.Size = new System.Drawing.Size(91, 20);
            this.label_Setting_Room1_desWet.TabIndex = 22;
            this.label_Setting_Room1_desWet.Text = "desWet";
            this.label_Setting_Room1_desWet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Setting_Room1_curTmp
            // 
            this.label_Setting_Room1_curTmp.Font = new System.Drawing.Font("굴림", 11F);
            this.label_Setting_Room1_curTmp.Location = new System.Drawing.Point(30, 88);
            this.label_Setting_Room1_curTmp.Name = "label_Setting_Room1_curTmp";
            this.label_Setting_Room1_curTmp.Size = new System.Drawing.Size(91, 20);
            this.label_Setting_Room1_curTmp.TabIndex = 21;
            this.label_Setting_Room1_curTmp.Text = "curTmp";
            this.label_Setting_Room1_curTmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Setting_Room1_desTmp
            // 
            this.label_Setting_Room1_desTmp.Font = new System.Drawing.Font("굴림", 11F);
            this.label_Setting_Room1_desTmp.Location = new System.Drawing.Point(127, 88);
            this.label_Setting_Room1_desTmp.Name = "label_Setting_Room1_desTmp";
            this.label_Setting_Room1_desTmp.Size = new System.Drawing.Size(91, 20);
            this.label_Setting_Room1_desTmp.TabIndex = 20;
            this.label_Setting_Room1_desTmp.Text = "desTmp";
            this.label_Setting_Room1_desTmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 11F);
            this.label12.Location = new System.Drawing.Point(30, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "현재 습도";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 11F);
            this.label13.Location = new System.Drawing.Point(127, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 19);
            this.label13.TabIndex = 18;
            this.label13.Text = "희망 습도";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 11F);
            this.label8.Location = new System.Drawing.Point(30, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "현재 온도";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11F);
            this.label7.Location = new System.Drawing.Point(127, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "희망 온도";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 11F);
            this.label19.Location = new System.Drawing.Point(30, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 19);
            this.label19.TabIndex = 15;
            this.label19.Text = "Room1";
            // 
            // pictureBox_Setting_Room1_FAN
            // 
            this.pictureBox_Setting_Room1_FAN.Location = new System.Drawing.Point(263, 158);
            this.pictureBox_Setting_Room1_FAN.Name = "pictureBox_Setting_Room1_FAN";
            this.pictureBox_Setting_Room1_FAN.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Setting_Room1_FAN.TabIndex = 14;
            this.pictureBox_Setting_Room1_FAN.TabStop = false;
            this.pictureBox_Setting_Room1_FAN.BackColorChanged += new System.EventHandler(this.pictureBox_Setting_Room1_FAN_BackColorChanged);
            // 
            // pictureBox_Setting_Room1_Machine
            // 
            this.pictureBox_Setting_Room1_Machine.Location = new System.Drawing.Point(263, 83);
            this.pictureBox_Setting_Room1_Machine.Name = "pictureBox_Setting_Room1_Machine";
            this.pictureBox_Setting_Room1_Machine.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Setting_Room1_Machine.TabIndex = 13;
            this.pictureBox_Setting_Room1_Machine.TabStop = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("굴림", 11F);
            this.label11.Location = new System.Drawing.Point(253, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "FAN";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 11F);
            this.label10.Location = new System.Drawing.Point(253, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "작동";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Setting_Desire
            // 
            this.TB_Setting_Desire.Enabled = false;
            this.TB_Setting_Desire.Font = new System.Drawing.Font("굴림", 11F);
            this.TB_Setting_Desire.Location = new System.Drawing.Point(186, 238);
            this.TB_Setting_Desire.Name = "TB_Setting_Desire";
            this.TB_Setting_Desire.Size = new System.Drawing.Size(100, 29);
            this.TB_Setting_Desire.TabIndex = 5;
            // 
            // label_Setting_Desire
            // 
            this.label_Setting_Desire.Font = new System.Drawing.Font("굴림", 11F);
            this.label_Setting_Desire.Location = new System.Drawing.Point(61, 248);
            this.label_Setting_Desire.Name = "label_Setting_Desire";
            this.label_Setting_Desire.Size = new System.Drawing.Size(91, 19);
            this.label_Setting_Desire.TabIndex = 4;
            this.label_Setting_Desire.Text = "희망";
            this.label_Setting_Desire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("굴림", 11F);
            this.label6.Location = new System.Drawing.Point(61, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "기능";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Setting_Fuction
            // 
            this.comboBox_Setting_Fuction.Enabled = false;
            this.comboBox_Setting_Fuction.Font = new System.Drawing.Font("굴림", 11F);
            this.comboBox_Setting_Fuction.FormattingEnabled = true;
            this.comboBox_Setting_Fuction.Location = new System.Drawing.Point(186, 193);
            this.comboBox_Setting_Fuction.Name = "comboBox_Setting_Fuction";
            this.comboBox_Setting_Fuction.Size = new System.Drawing.Size(121, 26);
            this.comboBox_Setting_Fuction.TabIndex = 2;
            this.comboBox_Setting_Fuction.SelectedIndexChanged += new System.EventHandler(this.comboBox_Setting_Fuction_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 11F);
            this.label5.Location = new System.Drawing.Point(61, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "구역";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Setting_Location
            // 
            this.comboBox_Setting_Location.Font = new System.Drawing.Font("굴림", 11F);
            this.comboBox_Setting_Location.FormattingEnabled = true;
            this.comboBox_Setting_Location.Items.AddRange(new object[] {
            "Room1",
            "Room2"});
            this.comboBox_Setting_Location.Location = new System.Drawing.Point(186, 148);
            this.comboBox_Setting_Location.Name = "comboBox_Setting_Location";
            this.comboBox_Setting_Location.Size = new System.Drawing.Size(121, 26);
            this.comboBox_Setting_Location.TabIndex = 0;
            this.comboBox_Setting_Location.SelectedIndexChanged += new System.EventHandler(this.comboBox_Setting_Location_SelectedIndexChanged);
            // 
            // tabPage_Room1
            // 
            this.tabPage_Room1.Controls.Add(this.panel4);
            this.tabPage_Room1.Controls.Add(this.label1);
            this.tabPage_Room1.Controls.Add(this.listView_Room1);
            this.tabPage_Room1.Controls.Add(this.chart_Room1);
            this.tabPage_Room1.Controls.Add(this.label3);
            this.tabPage_Room1.Controls.Add(this.label4);
            this.tabPage_Room1.Controls.Add(this.label_Room1_Wet);
            this.tabPage_Room1.Controls.Add(this.label_Room1_Tmp);
            this.tabPage_Room1.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Room1.Name = "tabPage_Room1";
            this.tabPage_Room1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Room1.Size = new System.Drawing.Size(792, 471);
            this.tabPage_Room1.TabIndex = 0;
            this.tabPage_Room1.Text = "Room1";
            this.tabPage_Room1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(786, 56);
            this.panel4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 20F);
            this.label2.Location = new System.Drawing.Point(218, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Room1 온,습도 현황";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(390, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "/";
            // 
            // listView_Room1
            // 
            this.listView_Room1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_No,
            this.columnHeader_Time,
            this.columnHeader_Tmp,
            this.columnHeader_Wet});
            this.listView_Room1.HideSelection = false;
            this.listView_Room1.Location = new System.Drawing.Point(470, 110);
            this.listView_Room1.Name = "listView_Room1";
            this.listView_Room1.Size = new System.Drawing.Size(310, 350);
            this.listView_Room1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView_Room1.TabIndex = 5;
            this.listView_Room1.UseCompatibleStateImageBehavior = false;
            this.listView_Room1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_No
            // 
            this.columnHeader_No.Text = "No.";
            this.columnHeader_No.Width = 1;
            // 
            // columnHeader_Time
            // 
            this.columnHeader_Time.Text = "시간";
            this.columnHeader_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Time.Width = 170;
            // 
            // columnHeader_Tmp
            // 
            this.columnHeader_Tmp.Text = "온도";
            this.columnHeader_Tmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Tmp.Width = 40;
            // 
            // columnHeader_Wet
            // 
            this.columnHeader_Wet.Text = "습도";
            this.columnHeader_Wet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Wet.Width = 40;
            // 
            // chart_Room1
            // 
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.Name = "ChartArea1";
            this.chart_Room1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_Room1.Legends.Add(legend5);
            this.chart_Room1.Location = new System.Drawing.Point(3, 110);
            this.chart_Room1.Name = "chart_Room1";
            series9.BorderWidth = 4;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Orange;
            series9.Legend = "Legend1";
            series9.Name = "온도";
            series10.BorderColor = System.Drawing.Color.SkyBlue;
            series10.BorderWidth = 4;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "습도";
            this.chart_Room1.Series.Add(series9);
            this.chart_Room1.Series.Add(series10);
            this.chart_Room1.Size = new System.Drawing.Size(470, 357);
            this.chart_Room1.TabIndex = 4;
            this.chart_Room1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20F);
            this.label3.Location = new System.Drawing.Point(425, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "습도";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 20F);
            this.label4.Location = new System.Drawing.Point(185, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 34);
            this.label4.TabIndex = 2;
            this.label4.Text = "온도";
            // 
            // label_Room1_Wet
            // 
            this.label_Room1_Wet.AutoSize = true;
            this.label_Room1_Wet.Font = new System.Drawing.Font("굴림", 20F);
            this.label_Room1_Wet.Location = new System.Drawing.Point(514, 62);
            this.label_Room1_Wet.Name = "label_Room1_Wet";
            this.label_Room1_Wet.Size = new System.Drawing.Size(75, 34);
            this.label_Room1_Wet.TabIndex = 1;
            this.label_Room1_Wet.Text = "Wet";
            // 
            // label_Room1_Tmp
            // 
            this.label_Room1_Tmp.AutoSize = true;
            this.label_Room1_Tmp.Font = new System.Drawing.Font("굴림", 20F);
            this.label_Room1_Tmp.Location = new System.Drawing.Point(286, 62);
            this.label_Room1_Tmp.Name = "label_Room1_Tmp";
            this.label_Room1_Tmp.Size = new System.Drawing.Size(85, 34);
            this.label_Room1_Tmp.TabIndex = 0;
            this.label_Room1_Tmp.Text = "Tmp";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // environment_TmpWet_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "environment_TmpWet_Form";
            this.Text = "environment_TmpWet_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.environment_TmpWet_Form_FormClosed);
            this.Load += new System.EventHandler(this.environment_TmpWet_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Control.ResumeLayout(false);
            this.tabPage_Control.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Setting_Room1_FAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Setting_Room1_Machine)).EndInit();
            this.tabPage_Room1.ResumeLayout(false);
            this.tabPage_Room1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Room1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Room1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView_Room1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Room1;
        private System.Windows.Forms.ColumnHeader columnHeader_No;
        private System.Windows.Forms.ColumnHeader columnHeader_Tmp;
        private System.Windows.Forms.ColumnHeader columnHeader_Wet;
        private System.Windows.Forms.ColumnHeader columnHeader_Time;
        private System.Windows.Forms.TabPage tabPage_Control;
        private System.Windows.Forms.Button BTN_Setting_Change;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_Setting_Desire;
        private System.Windows.Forms.Label label_Setting_Desire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Setting_Fuction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Setting_Location;
        private System.Windows.Forms.PictureBox pictureBox_Setting_Room1_FAN;
        private System.Windows.Forms.PictureBox pictureBox_Setting_Room1_Machine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label_Room1_Wet;
        public System.Windows.Forms.Label label_Room1_Tmp;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_Setting_Room1_curWet;
        private System.Windows.Forms.Label label_Setting_Room1_desWet;
        private System.Windows.Forms.Label label_Setting_Room1_curTmp;
        private System.Windows.Forms.Label label_Setting_Room1_desTmp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}