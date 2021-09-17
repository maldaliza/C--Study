using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;

namespace DBConnectionApp01
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            using (var conn = new NpgsqlConnection("Host=localhost; Username=postgres; Password=1111; Database=Exercise"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM member";

                        using (var reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine("Table Column 수 = {0}개", reader.FieldCount);

                            while (reader.Read())
                            {
                                var data = new string[]
                                {
                                    reader["id"].ToString(), 
                                    reader["name"].ToString(),
                                    reader["phonenumber"].ToString(), 
                                    reader["address"].ToString()
                                };

                                foreach (var x in data)
                                {
                                    Console.WriteLine(x);
                                    Console.WriteLine("======================");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("============== Error ==============");
                    Console.WriteLine(ex.Message);
                }
            }
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
