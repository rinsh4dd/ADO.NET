using System;
using Microsoft.Data.SqlClient;


class Program
{
    static void Main(string[] args)
    {
        string connstr = "Server=RINSHAD\\SQLEXPRESS; Database=ADO_DOTNET; Integrated Security=True; TrustServerCertificate=True;";

        using (SqlConnection conn = new SqlConnection(connstr))
        {
            conn.Open();
            Console.WriteLine("Connect ADO.NET To Data Source Successfully");

            String sql = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader["Id"]}, {reader["Name"]}");
            }
        }
    }
}