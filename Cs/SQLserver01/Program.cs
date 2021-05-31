using System;
using System.Data.SqlClient; // NuGet에서 설치 하기...

namespace SQLserver01
{
    class Program
    {
        static void Main(string[] args)
        {
            // <1> 데이터베이스 연결 --> 교량 건설
            String connStr = 
                "Server=127.0.0.1;" +
                "Uid=winuser;" +
                "Pwd=4321;" +
                "Database=sqlDB;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            // <2> 짐(SQL)을 실어서 나를 트럭을 준비
            SqlCommand cmd = new SqlCommand("", conn);

            // <3(반복)> 짐(SQL)을 트럭에 실어서 다리 건너 부어 넣기
            // 짐 준비
            String sql = "UPDATE user_table SET u_addr='제주도 한라읍 꼭대기' WHERE u_id='hong'";
            // 트럭에 짐 싣기
            cmd.CommandText = sql;
            // 교량 건너서 부어 넣기
            cmd.ExecuteNonQuery();

            //<4> 데이터베이스 해제 --> 교량 철거
            conn.Close();
            Console.WriteLine("잘 마쳤음...");
        }
    }
}
