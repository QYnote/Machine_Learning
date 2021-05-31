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
 * 해야할 목록 목록
 * 1. [버그]Form 활성화 중 DB 연결 해제시 연결해제 안됨
 * 3. [버그]카드 태그시 카드 코드 딜레이가 높음
 */

namespace Solo_Project
{
    public partial class work_RFID_Card_Form : Form
    {
        //card_Form
        bool cardCode_check = false;

        //DB
        string rfid_connStr;
        bool mysql_flag;
        bool ss_flag;

        string rfid_sql = "";  // 물건박스
        //MySQL
        public MySqlConnection MySQL_rfid_conn;
        MySqlCommand MySQL_rfid_cmd;
        MySqlDataReader MySQL_rfid_reader; // 트럭이 가져올 끈
        //SQL Server
        public SqlConnection SS_rfid_conn;
        SqlCommand SS_rfid_cmd;
        SqlDataReader SS_rfid_reader; // 트럭이 가져올 끈

        string tableName_rfid = "Tbl_RFID";
        string tableName_user = "Tbl_User";

        public work_RFID_Card_Form(string connstr, bool MySQL_Flag, bool SS_Flag)
        {
            rfid_connStr = connstr;
            mysql_flag = MySQL_Flag;
            ss_flag = SS_Flag;
            InitializeComponent();
        }

        //User Code
        private void work_RFID_Card_Form_Load(object sender, EventArgs e)
        {
            //main

            //DB connect
            if (mysql_flag)
            {
                MySQL_rfid_conn = new MySqlConnection(rfid_connStr);
                MySQL_rfid_conn.Open();
                MySQL_rfid_cmd = new MySqlCommand("", MySQL_rfid_conn);
            }
            else if (ss_flag)
            {
                SS_rfid_conn = new SqlConnection(rfid_connStr);
                SS_rfid_conn.Open();
                SS_rfid_cmd = new SqlCommand("", SS_rfid_conn);
            }
            get_user_info();
            get_RFID_info();
        }
        private void work_RFID_Card_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mysql_flag)
                MySQL_rfid_conn.Close();
            else if (ss_flag)
                SS_rfid_conn.Close();
        }

        //직원 관리
        private void get_user_info()
        {   //DB에서 유저 목록 가져오기
            if (mysql_flag)
            {
                MySQL_rfid_cmd.CommandText = "SELECT * FROM " + tableName_user;
                MySQL_rfid_reader = MySQL_rfid_cmd.ExecuteReader();

                /*
                 u_code INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
                 u_name VARCHAR(10) NOT NULL,
                 u_position VARCHAR(8)NOT NULL ,
                 u_department VARCHAR(16)NOT NULL ,
                 u_rfid_code VARCHAR(14),
                 */

                int u_code;
                string u_name, u_position, u_department, u_rfid_code;

                while (MySQL_rfid_reader.Read())
                {
                    u_code = Convert.ToInt32(MySQL_rfid_reader["u_code"]);
                    u_name = (string)MySQL_rfid_reader["u_name"];
                    u_position = (string)MySQL_rfid_reader["u_position"];
                    u_department = (string)MySQL_rfid_reader["u_department"];
                    try
                    {
                        u_rfid_code = (string)MySQL_rfid_reader["u_rfid_code"];
                    }
                    catch
                    {
                        u_rfid_code = "";
                    }

                    ListViewItem item = new ListViewItem(u_code.ToString());
                    item.SubItems.Add(u_name);
                    item.SubItems.Add(u_position);
                    item.SubItems.Add(u_department);
                    item.SubItems.Add("");
                    item.SubItems.Add(u_rfid_code);

                    listView_UserSet.Items.Add(item);
                }

                MySQL_rfid_reader.Close();
            }
            else if(ss_flag)
            {
                SS_rfid_cmd.CommandText = "SELECT * FROM " + tableName_user;
                SS_rfid_reader = SS_rfid_cmd.ExecuteReader();

                /*
                 u_code INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
                 u_name VARCHAR(10) NOT NULL,
                 u_position VARCHAR(8)NOT NULL ,
                 u_department VARCHAR(16)NOT NULL ,
                 u_rfid_code VARCHAR(14),
                 */

                int u_code;
                string u_name, u_position, u_department, u_rfid_code;

                while (SS_rfid_reader.Read())
                {
                    u_code = Convert.ToInt32(SS_rfid_reader["u_code"]);
                    u_name = (string)SS_rfid_reader["u_name"];
                    u_position = (string)SS_rfid_reader["u_position"];
                    u_department = (string)SS_rfid_reader["u_department"];
                    try
                    {
                        u_rfid_code = (string)SS_rfid_reader["u_rfid_code"];
                    }
                    catch
                    {
                        u_rfid_code = "";
                    }

                    ListViewItem item = new ListViewItem(u_code.ToString());
                    item.SubItems.Add(u_name);
                    item.SubItems.Add(u_position);
                    item.SubItems.Add(u_department);
                    item.SubItems.Add("");
                    item.SubItems.Add(u_rfid_code);

                    listView_UserSet.Items.Add(item);
                }

                SS_rfid_reader.Close();
            }
        }
        
        private void listView_UserSet_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TB_UserSet_UserCode.Text = listView_UserSet.FocusedItem.SubItems[0].Text;
            TB_UserSet_Name.Text = listView_UserSet.FocusedItem.SubItems[1].Text;
            TB_UserSet_Position.Text = listView_UserSet.FocusedItem.SubItems[2].Text;
            TB_UserSet_Department.Text = listView_UserSet.FocusedItem.SubItems[3].Text;
            TB_UserSet_CardCode.Text = listView_UserSet.FocusedItem.SubItems[4].Text;
        }
        private void listView_UserSet_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
                return;

            listView_UserSet.Columns[e.Column].Text = listView_UserSet.Columns[e.Column].Text.Replace(" ▼", "");
            listView_UserSet.Columns[e.Column].Text = listView_UserSet.Columns[e.Column].Text.Replace(" ▲", "");

            if (listView_UserSet.Sorting == System.Windows.Forms.SortOrder.Ascending || listView_UserSet.Sorting == System.Windows.Forms.SortOrder.None)
            {
                listView_UserSet.Sorting = System.Windows.Forms.SortOrder.Descending;
                listView_UserSet.Columns[e.Column].Text += " ▼";
            }
            else
            {
                listView_UserSet.Sorting = System.Windows.Forms.SortOrder.Ascending;
                listView_UserSet.Columns[e.Column].Text += " ▲";
            }

        }
        private bool listview_user_flag()
        {
            for (int i = 0; i < listView_UserSet.Items.Count; i++)
            {
                if (listView_UserSet.Items[i].SubItems[0].Text == TB_UserSet_UserCode.Text)
                    return true;
            }
            return false;
        }

        private void DB_Insert_Update(string DB_Order)
        {
            if (mysql_flag)
            {
                MySQL_rfid_cmd.CommandText = DB_Order;
                MySQL_rfid_reader = MySQL_rfid_cmd.ExecuteReader();
                MySQL_rfid_reader.Close();
            }
            else if (ss_flag)
            {
                SS_rfid_cmd.CommandText = DB_Order;
                SS_rfid_reader = SS_rfid_cmd.ExecuteReader();
                SS_rfid_reader.Close();
            }
        }

        private void BTN_UserSet_Insert_Click(object sender, EventArgs e)
        {   //유저 등록
            //등록
            string u_name = TB_UserSet_Name.Text;
            string u_position = TB_UserSet_Position.Text;
            string u_department = TB_UserSet_Department.Text;
            bool blank_flag = false;
            blank_flag = (u_name == "" || u_position == "" || u_department == "");

            if (!blank_flag)
            {
                //INSERT INTO tbl_User(u_name, u_position, u_department) VALUES('name', 'position', 'derpartment')
                rfid_sql = "INSERT INTO " + tableName_user + "(u_name, u_position, u_department) VALUES('";
                rfid_sql += u_name + "', '" + u_position + "', '" + u_department + "')";

                DB_Insert_Update(rfid_sql);
            }
            

            //Listview 초기화
            listView_UserSet.Items.Clear();
            get_user_info();
        }

        private void BTN_UserSet_Change_Click(object sender, EventArgs e)
        {   //유저 수정

            if (listview_user_flag())//유저 코드가 존재하는지 확인
            {
                string u_code = TB_UserSet_UserCode.Text;
                string u_name = TB_UserSet_Name.Text;
                string u_position = TB_UserSet_Position.Text;
                string u_department = TB_UserSet_Department.Text;

                //유저 정보 변경
                //UPDATE tbl_user SET u_position = '대리' WHERE u_code = 2
                rfid_sql = "UPDATE " + tableName_user + " SET " +
                    "u_name = '" + u_name + "', " +
                    "u_position = '" + u_position + "', " +
                    "u_department = '" + u_department + "' " +
                    "WHERE u_code = " + u_code;

                DB_Insert_Update(rfid_sql);
                //RFID 할당
                if (listview_RFID_flag())
                {
                    string u_rfid_code = TB_UserSet_CardCode.Text;
                    bool rfid_use_check = false;

                    for (int i = 0; i < listView_CardSet.Items.Count; i++)
                    {
                        if (listView_CardSet.Items[i].SubItems[1].Text == u_rfid_code)
                        {
                            if (listView_CardSet.Items[i].SubItems[2].Text == "미사용")
                            {
                                rfid_use_check = true;
                            }
                        }
                    }

                    if (rfid_use_check)
                    {
                        rfid_sql = "UPDATE " + tableName_user + " SET " +
                            "u_rfid_code = '" + u_rfid_code + "' " +
                            "WHERE u_code = " + u_code;

                        DB_Insert_Update(rfid_sql);

                        //DB RFID 사용여부 변경
                        rfid_sql = "UPDATE " + tableName_rfid + " SET " +
                            "rf_able = '" + "사용중" + "' " +
                            "WHERE rf_code = '" + u_rfid_code + "'";

                        DB_Insert_Update(rfid_sql);
                    }
                    else
                    {
                        MessageBox.Show("사용중인 카드 입니다.");
                    }
                }
                else
                {
                    MessageBox.Show("등록하지 않은 카드 입니다.");
                }
            }
            else
            {
                MessageBox.Show("유저를 먼저 등록해주세요");
            }

            //Listview 초기화
            listView_UserSet.Items.Clear();
            get_user_info();
            listView_CardSet.Items.Clear();
            get_RFID_info();
        }

        private void BTN_UserSet_Delete_Click(object sender, EventArgs e)
        {   //유저 삭제
            string u_code = TB_UserSet_UserCode.Text;
            string u_name = TB_UserSet_Name.Text;
            string u_position = TB_UserSet_Position.Text;
            string u_department = TB_UserSet_Department.Text;

            if (listview_user_flag())//유저 코드가 존재하는지 확인
            {
                //DELETE from Tbl_User WHERE u_code = 3
                rfid_sql = "DELETE from " + tableName_user + 
                    " WHERE u_code = " + u_code;

                DB_Insert_Update(rfid_sql);
            }

            //Listview 초기화
            listView_UserSet.Items.Clear();
            get_user_info();
        }
        //카드 관리
        private void get_RFID_info()
        {   //카드 목록 가져오기
            //DB에서 검색
            if (mysql_flag)
            {
                MySQL_rfid_cmd.CommandText = "SELECT * FROM " + tableName_rfid;
                MySQL_rfid_reader = MySQL_rfid_cmd.ExecuteReader();

                /*
                 rf_code VARCHAR(14) NOT NULL PRIMARY KEY,
                 rf_able VARCHAR(6) NOT NULL
                 */
                string rf_code, rf_able;

                while (MySQL_rfid_reader.Read())
                {
                    rf_code = (string)MySQL_rfid_reader["rf_code"];
                    rf_able = (string)MySQL_rfid_reader["rf_able"];

                    ListViewItem item = new ListViewItem("");
                    item.SubItems.Add(rf_code);
                    item.SubItems.Add(rf_able);

                    listView_CardSet.Items.Add(item);
                }

                MySQL_rfid_reader.Close();
            }
            else if (ss_flag)
            {
                SS_rfid_cmd.CommandText = "SELECT * FROM " + tableName_rfid;
                SS_rfid_reader = SS_rfid_cmd.ExecuteReader();

                /*
                 rf_code VARCHAR(14) NOT NULL PRIMARY KEY,
                 rf_able VARCHAR(6) NOT NULL
                 */
                string rf_code, rf_able;

                while (SS_rfid_reader.Read())
                {
                    rf_code = (string)SS_rfid_reader["rf_code"];
                    rf_able = (string)SS_rfid_reader["rf_able"];

                    ListViewItem item = new ListViewItem("");
                    item.SubItems.Add(rf_code);
                    item.SubItems.Add(rf_able);

                    listView_CardSet.Items.Add(item);
                }

                SS_rfid_reader.Close();
            }
        }
        private bool listview_RFID_flag()
        {
            for (int i = 0; i < listView_CardSet.Items.Count; i++)
            {
                if (listView_CardSet.Items[i].SubItems[1].Text == label_Card_CardCode.Text)
                    return true;
            }
            return false;
        }
        private void label_Card_CardCode_TextChanged(object sender, EventArgs e)
        {   //카드 태그시 카드 상황 가져오기
            cardCode_check = (label_Card_CardCode.Text != "입력할 카드를 대주세요");

            if (cardCode_check)
            {
                if (listview_RFID_flag())
                {
                    for (int i = 0; i < listView_CardSet.Items.Count; i++)
                    {
                        label_Card_Status.Text = listView_CardSet.Items[i].SubItems[2].Text;
                    }
                }
                else
                {
                    label_Card_Status.Text = "미등록 카드";
                }
            }
        }
        private void listView_CardSet_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label_Card_CardCode.Text = listView_CardSet.FocusedItem.SubItems[1].Text;
            label_Card_Status.Text = listView_CardSet.FocusedItem.SubItems[2].Text;
        }

        private void BTN_Card_Insert_Click(object sender, EventArgs e)
        {   //카드 등록

            //등록
            string rf_code = label_Card_CardCode.Text;
            string rf_able = "미사용";
            if (cardCode_check)
            {
                if (label_Card_Status.Text == "미등록 카드")
                {
                    //INSERT INTO Tbl_RFID(rf_code, rf_able) VALUES('aa aa aa aa aa', '테스트')
                    rfid_sql = "INSERT INTO " + tableName_rfid + "(rf_code, rf_able) VALUES('";
                    rfid_sql += rf_code + "', '" + rf_able + "')";

                    DB_Insert_Update(rfid_sql);

                    label_Card_Status.Text = rf_able;
                }

            }

            //Listview 초기화
            listView_CardSet.Items.Clear();
            get_RFID_info();
        }

        private void BTN_Card_Broke_Click(object sender, EventArgs e)
        {   //카드 불량 등록
            if (listview_RFID_flag())
            {
                string rf_code = label_Card_CardCode.Text;

                //UPDATE Tbl_RFID SET rf_able = '변경중'  WHERE rf_code = 'aa aa aa aa aa'
                rfid_sql = "UPDATE " + tableName_rfid + 
                    " SET rf_able = '" + "불량" + 
                    "'  WHERE rf_code = '" + rf_code + "'";

                DB_Insert_Update(rfid_sql);

                label_Card_Status.Text = "불량";
            }
            //Listview 초기화
            listView_CardSet.Items.Clear();
            get_RFID_info();
        }
    }
}
