using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adodemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection con = new SqlConnection("Data Source=HARSH;Initial Catalog=sample;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM student", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    Console.WriteLine("S_NO" + " S_Name" + " s_address");
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + " " + dr[1] );
                    }
                }
                catch(Exception e)
                {
                    Console.Write("Connection Fail");
                }
                Console.Read();
            }

        }
    }
}
