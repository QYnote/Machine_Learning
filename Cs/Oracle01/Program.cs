using System;

//Nuget : Oracle.ManagedDataAccess 설치
using Oracle.ManagedDataAccess.Client;

namespace Oracle01
{
    class Program
    {
        static void Main(string[] args)
        {
            // <1> 데이터베이스 연결 --> 교량 건설
            String connStr = "Data Source=" +
                                "(DESCRIPTION=" +
                                    "(ADDRESS_LIST=" +
                                        "(ADDRESS=" +
                                            "(PROTOCOL=TCP)" +
                                            "(HOST=localhost)" +  //호스트 확인
                                            "(PORT=1521)" +
                                        ")" +
                                    ")" +
                                    "(CONNECT_DATA=" +
                                        "(SERVER=DEDICATED)" +
                                        "(SERVICE_NAME=XE)" +
                                    ")" +
                                ");" +
                            "User Id=sqlsdb;" +
                            "Password=1234;";
            OracleConnection conn = new OracleConnection(connStr);
            conn.Open();
            // <2> 짐(SQL)을 실어서 나를 트럭을 준비
            OracleCommand cmd = new OracleCommand("", conn);

            // <3(반복)> 짐(SQL)을 트럭에 실어서 다리 건너 부어 넣기
            // 짐 준비
            String sql = "UPDATE userTbl SET addr='제주' WHERE userID='BBK'";
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
