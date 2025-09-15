using Microsoft.Data.SqlClient;
using System;
using System.Data;

class Day2Task
{
    static void Main(string[] args)
    {
        string connstr = "Server=RINSHAD\\SQLEXPRESS; Database=ADO_DOTNET; Integrated Security=True; TrustServerCertificate=True;";

        using(SqlConnection conn = new SqlConnection(connstr))
        {
            SqlDataAdapter da = new SqlDataAdapter("Select StudentID,FirstName,Age From Students", conn);

            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Students");

            Console.WriteLine("Original Data :");
            foreach (DataRow Row in ds.Tables["Students"].Rows)
            {
                Console.WriteLine($"{Row["StudentId"]},{Row["FirstName"]},{Row["Age"]}");
            }

            ds.Tables["Students"].Rows[0]["Age"] = 28;
            ds.Tables["Students"].Rows[0]["FirstName"] = "Rinshad Updated";
          
            da.Update(ds, "Students");
            Console.WriteLine("\n DataBase Updated With new Ages and FirstName!!");

            DataView dv = new DataView(ds.Tables["Students"]);
            dv.RowFilter = "Age > 21";

            Console.WriteLine("\nFiltered Students (Age > 25):");
            foreach (DataRowView row in dv)
            {
                Console.WriteLine($"{row["StudentId"]} - {row["FirstName"]}  - {row["Age"]}");
            }
        }
    }
}