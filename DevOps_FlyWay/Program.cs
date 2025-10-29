using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Data.SqlClient;



namespace DevOps_FlyWay
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            if (string.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("❌ No connection string found in environment variables!");
                return;
            }


            var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                Console.WriteLine("✅ Database connection successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Connection failed: " + ex.Message);
            }
        }
    }
}
