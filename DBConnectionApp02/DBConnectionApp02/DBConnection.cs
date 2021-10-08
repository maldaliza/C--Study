using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Npgsql;

namespace DBConnectionApp02
{
    class DBConnection
    {
        /*
         * 데이터베이스 정보 조회
         */
        public void SelectData(DataTable table, int offset)
        {
            table.Rows.Clear();     // DataGridView의 기존 데이터 삭제

            using (var conn = new NpgsqlConnection("Host=localhost; Username=postgres; Password=1111; Database=Exercise"))
            {
                try
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM member OFFSET @offset LIMIT 30", conn);
                    cmd.Parameters.AddWithValue("offset", offset);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string[] data = new string[]
                            {
                                reader["id"].ToString(), 
                                reader["name"].ToString(), 
                                reader["phoneNumber"].ToString(), 
                                reader["address"].ToString()
                            };

                            table.Rows.Add(data);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("============== Error ==============");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /*
         * 데이터베이스 정보 Total 조회
         */
        public Int64 CountTotal()
        {
            using (var conn = new NpgsqlConnection("Host=localhost; Username=postgres; Password=1111; Database=Exercise"))
            {
                try
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT count(*) FROM member", conn);

                    Int64 totalCount = (Int64)cmd.ExecuteScalar();
                    return totalCount;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("============== Error ==============");
                    Console.WriteLine(ex.Message);

                    return 0;
                }
            }
        }
    }
}
