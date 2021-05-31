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

namespace Solo_Project
{
    public partial class environment_CheckLog_Form : Form
    {
        //DB
        string select_connStr;
        bool mysql_flag;
        bool ss_flag;
        //MySQL
        public MySqlConnection MySQL_select_conn;
        MySqlCommand MySQL_select_cmd;
        MySqlDataReader MySQL_select_reader; // 트럭이 가져올 끈
        //SQL Server
        public SqlConnection SS_select_conn;
        SqlCommand SS_select_cmd;
        SqlDataReader SS_select_reader; // 트럭이 가져올 끈


        public environment_CheckLog_Form(string connStr, bool MySQL_Flag, bool SS_Flag)
        {
            select_connStr = connStr;
            mysql_flag = MySQL_Flag;
            ss_flag = SS_Flag;
            InitializeComponent();
        }

        private void environment_CheckLog_Form_Load(object sender, EventArgs e)
        {
            if (mysql_flag)
            {
                MySQL_select_conn = new MySqlConnection(select_connStr);
                MySQL_select_conn.Open();
                MySQL_select_cmd = new MySqlCommand("", MySQL_select_conn);
            }
            else if (ss_flag)
            {
                SS_select_conn = new SqlConnection(select_connStr);
                SS_select_conn.Open();
                SS_select_cmd = new SqlCommand("", SS_select_conn);
            }
        }
        private void BTN_Select_Click(object sender, EventArgs e)
        {
            /*
             * 온습도
             * 희망 온습도
             * 출입문
             */
            if (mysql_flag)
            {
                if (comboBox_LogList.Text == "온습도")
                {
                    string tableName_curTmpWet = "Tbl_TmpWet";
                    string cri_curTmpWet = "tw_time";

                    //SELECT * FROM tbl_tmpwet ORDER BY tw_time DESC;
                    MySQL_select_cmd.CommandText = "SELECT * FROM " + tableName_curTmpWet +
                                                     " ORDER BY " + cri_curTmpWet + " DESC;";
                    MySQL_select_reader = MySQL_select_cmd.ExecuteReader();

                    //표 Columns 설정 Start
                    List_Clear();   //리스트 초기화
                    listView_Log.Columns.Add("시간");
                    listView_Log.Columns.Add("온도");
                    listView_Log.Columns.Add("습도");
                    //표 Columns 설정 End
                    //표에 Data 삽입 Start
                    /*
                     * tw_time DATETIME NOT NULL PRIMARY KEY,
                     * tw_tmp INT NOT NULL,
                     * tw_wet INT NOT NULL
                     */
                    string tw_time, tw_tmp, tw_wet;

                    while (MySQL_select_reader.Read())
                    {
                        tw_time = MySQL_select_reader["tw_time"].ToString();
                        tw_tmp = MySQL_select_reader["tw_tmp"].ToString();
                        tw_wet = MySQL_select_reader["tw_wet"].ToString();

                        ListViewItem item = new ListViewItem(tw_time.ToString());
                        item.SubItems.Add(tw_tmp);
                        item.SubItems.Add(tw_wet);

                        listView_Log.Items.Add(item);
                    }
                    //표에 Data 삽입 End

                    List_Setting();
                    MySQL_select_reader.Close();
                }
                else if (comboBox_LogList.Text == "희망 온습도")
                {
                    string tableName_desTempWet = "Tbl_desTmpWet";
                    string cri_desTmpWet = "des_time";

                    //SELECT * FROM Tbl_desTmpWet ORDER BY des_time DESC;
                    MySQL_select_cmd.CommandText = "SELECT * FROM " + tableName_desTempWet +
                                                     " ORDER BY " + cri_desTmpWet + " DESC;";
                    MySQL_select_reader = MySQL_select_cmd.ExecuteReader();

                    //표 Columns 설정 Start
                    List_Clear();   //리스트 초기화

                    listView_Log.Columns.Add("시간");
                    listView_Log.Columns.Add("온도");
                    listView_Log.Columns.Add("습도");
                    //표 Columns 설정 End
                    //표에 Data 삽입 Start
                    /*
                     * des_time DATETIME NOT NULL PRIMARY KEY,
                     * des_tmp INT NOT NULL,
                     * des_wet INT NOT NULL
                     */
                    string des_time, des_tmp, des_wet;

                    while (MySQL_select_reader.Read())
                    {
                        des_time = MySQL_select_reader["des_time"].ToString();
                        des_tmp = MySQL_select_reader["des_tmp"].ToString();
                        des_wet = MySQL_select_reader["des_wet"].ToString();

                        ListViewItem item = new ListViewItem(des_time.ToString());
                        item.SubItems.Add(des_tmp);
                        item.SubItems.Add(des_wet);

                        listView_Log.Items.Add(item);
                    }
                    //표에 Data 삽입 End

                    List_Setting();
                    MySQL_select_reader.Close();
                }
                else if (comboBox_LogList.Text == "출입문")
                {
                    string tableName_door = "Tbl_door";
                    string cri_door = "d_openTime";

                    //SELECT * FROM tableName_door ORDER BY cri_door DESC;
                    MySQL_select_cmd.CommandText = "SELECT * FROM " + tableName_door +
                                                     " ORDER BY " + cri_door + " DESC;";
                    MySQL_select_reader = MySQL_select_cmd.ExecuteReader();

                    //표 Columns 설정 Start
                    List_Clear();   //리스트 초기화

                    listView_Log.Columns.Add("작동 횟수");
                    listView_Log.Columns.Add("열린 시간");
                    listView_Log.Columns.Add("닫힌 시간");
                    //표 Columns 설정 End
                    //표에 Data 삽입 Start
                    /*
                     * d_op INT  NOT NULL AUTO_INCREMENT PRIMARY KEY,
                     * d_openTime DATETIME NOT NULL,
                     * d_closeTime DATETIME
                     */
                    string d_op, d_openTime, d_closeTime;

                    while (MySQL_select_reader.Read())
                    {
                        d_op = MySQL_select_reader["d_op"].ToString();
                        d_openTime = MySQL_select_reader["d_openTime"].ToString();
                        d_closeTime = MySQL_select_reader["d_closeTime"].ToString();

                        ListViewItem item = new ListViewItem(d_op.ToString());
                        item.SubItems.Add(d_openTime);
                        item.SubItems.Add(d_closeTime);

                        listView_Log.Items.Add(item);
                    }
                    //표에 Data 삽입 End

                    List_Setting();
                    MySQL_select_reader.Close();
                }
            }
            else if (ss_flag)
            {
                if (comboBox_LogList.Text == "온습도")
                {
                    string tableName_curTmpWet = "Tbl_TmpWet";
                    string cri_curTmpWet = "tw_time";

                    //SELECT * FROM tbl_tmpwet ORDER BY tw_time DESC;
                    SS_select_cmd.CommandText = "SELECT * FROM " + tableName_curTmpWet +
                                                     " ORDER BY " + cri_curTmpWet + " DESC;";
                    SS_select_reader = SS_select_cmd.ExecuteReader();

                    //표 Columns 설정 Start
                    List_Clear();   //리스트 초기화
                    listView_Log.Columns.Add("시간");
                    listView_Log.Columns.Add("온도");
                    listView_Log.Columns.Add("습도");
                    //표 Columns 설정 End
                    //표에 Data 삽입 Start
                    /*
                     * tw_time DATETIME NOT NULL PRIMARY KEY,
                     * tw_tmp INT NOT NULL,
                     * tw_wet INT NOT NULL
                     */
                    string tw_time, tw_tmp, tw_wet;

                    while (SS_select_reader.Read())
                    {
                        tw_time = SS_select_reader["tw_time"].ToString();
                        tw_tmp = SS_select_reader["tw_tmp"].ToString();
                        tw_wet = SS_select_reader["tw_wet"].ToString();

                        ListViewItem item = new ListViewItem(tw_time.ToString());
                        item.SubItems.Add(tw_tmp);
                        item.SubItems.Add(tw_wet);

                        listView_Log.Items.Add(item);
                    }
                    //표에 Data 삽입 End

                    List_Setting();
                    SS_select_reader.Close();
                }
                else if (comboBox_LogList.Text == "희망 온습도")
                {
                    string tableName_desTempWet = "Tbl_desTmpWet";
                    string cri_desTmpWet = "des_time";

                    //SELECT * FROM Tbl_desTmpWet ORDER BY des_time DESC;
                    SS_select_cmd.CommandText = "SELECT * FROM " + tableName_desTempWet +
                                                     " ORDER BY " + cri_desTmpWet + " DESC;";
                    SS_select_reader = SS_select_cmd.ExecuteReader();

                    //표 Columns 설정 Start
                    List_Clear();   //리스트 초기화

                    listView_Log.Columns.Add("시간");
                    listView_Log.Columns.Add("온도");
                    listView_Log.Columns.Add("습도");
                    //표 Columns 설정 End
                    //표에 Data 삽입 Start
                    /*
                     * des_time DATETIME NOT NULL PRIMARY KEY,
                     * des_tmp INT NOT NULL,
                     * des_wet INT NOT NULL
                     */
                    string des_time, des_tmp, des_wet;

                    while (SS_select_reader.Read())
                    {
                        des_time = SS_select_reader["des_time"].ToString();
                        des_tmp = SS_select_reader["des_tmp"].ToString();
                        des_wet = SS_select_reader["des_wet"].ToString();

                        ListViewItem item = new ListViewItem(des_time.ToString());
                        item.SubItems.Add(des_tmp);
                        item.SubItems.Add(des_wet);

                        listView_Log.Items.Add(item);
                    }
                    //표에 Data 삽입 End

                    List_Setting();
                    SS_select_reader.Close();
                }
                else if (comboBox_LogList.Text == "출입문")
                {
                    string tableName_door = "Tbl_door";
                    string cri_door = "d_openTime";

                    //SELECT * FROM tableName_door ORDER BY cri_door DESC;
                    SS_select_cmd.CommandText = "SELECT * FROM " + tableName_door +
                                                     " ORDER BY " + cri_door + " DESC;";
                    SS_select_reader = SS_select_cmd.ExecuteReader();

                    //표 Columns 설정 Start
                    List_Clear();   //리스트 초기화

                    listView_Log.Columns.Add("작동 횟수");
                    listView_Log.Columns.Add("열린 시간");
                    listView_Log.Columns.Add("닫힌 시간");
                    //표 Columns 설정 End
                    //표에 Data 삽입 Start
                    /*
                     * d_op INT  NOT NULL AUTO_INCREMENT PRIMARY KEY,
                     * d_openTime DATETIME NOT NULL,
                     * d_closeTime DATETIME
                     */
                    string d_op, d_openTime, d_closeTime;

                    while (SS_select_reader.Read())
                    {
                        d_op = SS_select_reader["d_op"].ToString();
                        d_openTime = SS_select_reader["d_openTime"].ToString();
                        d_closeTime = SS_select_reader["d_closeTime"].ToString();

                        ListViewItem item = new ListViewItem(d_op.ToString());
                        item.SubItems.Add(d_openTime);
                        item.SubItems.Add(d_closeTime);

                        listView_Log.Items.Add(item);
                    }
                    //표에 Data 삽입 End

                    List_Setting();
                    SS_select_reader.Close();
                }
            }
        }
        private void checkBox_Allday_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Allday.Checked == true)
            {
                comboBox_StartTime.Enabled = false;
                comboBox_EndTime.Enabled = false;
            }
            else
            {
                comboBox_StartTime.Enabled = true;
                comboBox_EndTime.Enabled = true;
            }
        }
        //User Code Start
        private void List_Setting()
        {
            for (int i = 0; i < listView_Log.Columns.Count; i++)
            {
                listView_Log.Columns[i].TextAlign = HorizontalAlignment.Center;
                listView_Log.Columns[i].Width = -2;
            }
        }

        private void List_Clear()
        {
            listView_Log.Items.Clear();
            listView_Log.Columns.Clear();
        }
        //User Code End
    }
}
