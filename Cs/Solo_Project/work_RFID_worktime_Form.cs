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
    public partial class work_RFID_workcheck_Form : Form
    {
        //DB
        string work_connStr;
        public MySqlConnection work_conn;
        MySqlCommand work_cmd;
        String work_sql = "";  // 물건박스
        MySqlDataReader work_reader; // 트럭이 가져올 끈

        public work_RFID_workcheck_Form()
        {
            InitializeComponent();
        }
        private void work_RFID_workcheck_Form_Load(object sender, EventArgs e)
        {
            work_conn = new MySqlConnection(work_connStr);
            work_conn.Open();
            work_cmd = new MySqlCommand("", work_conn);
        }
        private void work_RFID_workcheck_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            work_conn.Close();
        }

        private void label_CardCode_TextChanged(object sender, EventArgs e)
        {
            if (label_CardCode.Text != "Card Code" || label_CardCode.Text != "-")
            {
                /*
                 * 1. Card Code가 등록된 카드인가?
                 * 2. Card Code가 사용중에 있는가?
                 * 3. 해당 CardCode를 사용중인 유저는 누구인가
                 * 4. 유저가 이미 출근 하였는가?
                 * 5. 유저가 이미 퇴근 하였는가?
                 */

                bool card_check = false;    //1. 등록된 카드인가
                bool b_card_able = false;   //2. 유저가 이 카드를 사용중인가
                bool work_check = false;    //4. 유저가 출근 하였는가
                bool workout_check = false; //5. 유저가 퇴근 하였는가

                //1. Card Code가 등록된 카드인가?
                string tableName_user = "Tbl_RFID";
                //SELECT rf_code FROM tbl_rfid WHERE rf_code = 'aa aa ac aa aa'
                work_cmd.CommandText = "SELECT rf_able" +
                                            " FROM " + tableName_user + 
                                            " WHERE rf_code = '" + label_CardCode.Text + "'";
                work_reader = work_cmd.ExecuteReader();

                work_reader.Close();

                string card_able = "";
                if (work_reader.Read()) //카드 존재 체크
                {
                    card_check = true;
                    card_able = work_reader["rf_able"].ToString();

                    //2. Card Code가 사용중에 있는가?
                    if (card_able == "사용중") //카드 사용중 체크
                    {
                        //3. 해당 CardCode를 사용중인 유저는 누구인가
                        tableName_user = "Tbl_User";
                        //SELECT u_code, u_name, u_position, u_department FROM tbl_rfid WHERE rf_code = 'aa aa ac aa aa'
                        work_cmd.CommandText = "SELECT u_code, u_name, u_position, u_department" +
                                                    " FROM " + tableName_user +
                                                    " WHERE u_rfid_code = '" + label_CardCode.Text + "'";
                        work_reader = work_cmd.ExecuteReader();

                        int u_code;
                        string u_name, u_position, u_department;
                        while (work_reader.Read())
                        {
                            u_code = Convert.ToInt32(work_reader["u_code"]);
                            u_name = (string)work_reader["u_name"];
                            u_position = (string)work_reader["u_position"];
                            u_department = (string)work_reader["u_department"];

                            label_UserCode.Text = u_code.ToString();
                            label_UserName.Text = u_name;
                            label_UserPosition.Text = u_position;
                            label_UserDepartment.Text = u_department;
                        }

                        work_reader.Close();

                        // 4.유저가 이미 출근 하였는가 ?
                        tableName_user = "Tbl_worktime";
                        //SELECT wt_start FROM Tbl_worktime WHERE wt_u_code = 1
                        work_cmd.CommandText = "SELECT wt_start" +
                                                    " FROM " + tableName_user +
                                                    " WHERE wt_u_code = " + label_UserCode.Text;
                        work_reader = work_cmd.ExecuteReader();


                        if (work_reader.Read()) //출근 했으면
                        {   //출근 했으면
                            work_reader.Close();
                            //DB 퇴근 시키기
                            tableName_user = "Tbl_worktime";
                            //UPDATE Tbl_worktime SET wt_status = '퇴근', wt_end = '2021-05-21 17:00:00' WHERE wt_u_code = 2
                            work_cmd.CommandText = "UPDATE " + tableName_user +
                                                        " SET wt_status = '퇴근', " +
                                                             "wt_end = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +
                                                        "' WHERE wt_u_code = " + label_UserCode.Text;
                            work_reader = work_cmd.ExecuteReader();

                            work_reader.Close();
                            label_UserStatus.Text = "퇴근";
                            workout_check = true;

                            //5. 유저가 이미 퇴근 하였는가?
                            if (workout_check)
                            {
                                tableName_user = "Tbl_worktime";
                                //SELECT wt_end FROM Tbl_worktime WHERE wt_u_code = 1
                                work_cmd.CommandText = "SELECT wt_end" +
                                                            " FROM " + tableName_user +
                                                            " WHERE wt_u_code = " + label_UserCode.Text;
                                work_reader = work_cmd.ExecuteReader();

                                if (work_reader.Read()) //퇴근 했으면
                                    label_UserStatus.Text = "퇴근(이미 처리됨)";

                                work_reader.Close();
                            }

                        }
                        else
                        {   //출근 안했으면
                            work_reader.Close();
                            //DB 출근 시키기
                            tableName_user = "Tbl_worktime";
                            //INSERT INTO Tbl_worktime(wt_start, wt_status, wt_u_code) VALUES('2021-05-21 09:00:00', '출근', 2)
                            work_cmd.CommandText = "INSERT INTO " + tableName_user + "(wt_start, wt_status, wt_u_code)" +
                                                        " VALUES('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '출근', " +
                                                                     label_UserCode.Text + ")";
                            work_reader = work_cmd.ExecuteReader();

                            work_reader.Close();
                            label_UserStatus.Text = "출근";
                        }
                    }
                    else
                    {
                        MessageBox.Show("사용중인 카드가 아닙니다..");
                    }
                }
                else
                {
                    MessageBox.Show("카드가 존재하지 않습니다.");
                }

            }
        }
    }
}
