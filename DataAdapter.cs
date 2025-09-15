//using Microsoft.Data.SqlClient;
//using System;
//using System.Data;
//using System.Data.SqlTypes;



//class DataAdapter
//{
//    static void Main(string[] args)
//    {
//        string connStr = "Server=RINSHAD\\SQLEXPRESS; Database=ADO_DOTNET; Integrated Security=True; TrustServerCertificate=True";

//        using (SqlConnection conn = new SqlConnection(connStr))
//        {

//            SqlDataAdapter da = new SqlDataAdapter("SELECT StudentId, FirstName, Age FROM Students", c onn);

//            // Step 2: Create DataSet
//            DataSet ds = new DataSet();

//            // Step 3: Fill DataSet (Students table)
//            da.Fill(ds, "Students");

//            // Step 4: Display data
//            Console.WriteLine("Students (From Database):");
//            foreach (DataRow row in ds.Tables["Students"].Rows)
//            {
//                Console.WriteLine($"{row["StudentId"]} - {row["FirstName"]} - {row["Age"]}");
//            }
//        }
//    }
//}
