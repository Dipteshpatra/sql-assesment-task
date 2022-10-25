
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLconnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionstring = @"Data Source=.;Initial Catalog=CoDb;Integrated Security=True";
            try
            {
                sqlConnection= new SqlConnection(connectionstring);
                sqlConnection.Open();
                Console.WriteLine("Connection established");
                //craete crud
                Console.WriteLine("Enter your name");
                string username=Console.ReadLine();
                Console.WriteLine("Enter Mobile no");
                double usermno=Convert.ToDouble(Console.ReadLine());    
                string insertQuery= "INSERT INTO DETAILS(user_name,user_Mno) VALUES('" + username +"'," + usermno + " )";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("data inserted into the table");
                //READ DATA 
                string displayquery = "select * from details";
                SqlCommand displayCommand = new SqlCommand(displayquery, sqlConnection);
                SqlDataReader dataReader = displayCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine("user_id :" + dataReader.GetValue(0).ToString());
                    Console.WriteLine("user_name :" + dataReader.GetValue(1).ToString());
                    Console.WriteLine("user_Mno :" + dataReader.GetValue(2).ToString());
                }
                dataReader.Close();
                //update query
                int user_id;
                double user_Mno;
                Console.WriteLine("enter to update the details by user id");
                user_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the updated user mobile no");
                user_Mno = Convert.ToDouble(Console.ReadLine());
                string updatequery = "update Details set user_Mno = " + user_Mno + "where user_id = " + user_id;
                SqlCommand updatecommand = new SqlCommand(updatequery, sqlConnection);
                updatecommand.ExecuteNonQuery();
                Console.WriteLine("Data update sucessfully");
                //delete
                int id;
                Console.WriteLine("enter the user id that is to be deleted");
                id = Convert.ToInt32(Console.ReadLine());
                string deletequery = "delete from Details  where user_id = " + user_id;
                SqlCommand deletecommand = new SqlCommand(deletequery, sqlConnection);
                deletecommand.ExecuteNonQuery();
                Console.WriteLine("data succesfull deleted");


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

