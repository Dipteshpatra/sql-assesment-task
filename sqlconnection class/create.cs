using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlconnection_class
{
    public class create
    {
        public SqlConnection sqlConnection;
        public string connectionstring = @"Data Source=.;Initial Catalog=CoDb;Integrated Security=True";

        public void Createuser()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionstring);
                sqlConnection.Open();
                Console.WriteLine("Connection established");
                //craete crud
                Console.WriteLine("Enter your name");
                string username = Console.ReadLine();
                Console.WriteLine("Enter Mobile no");
                double usermno = Convert.ToDouble(Console.ReadLine());
                string insertQuery = "INSERT INTO DETAILS(user_name,user_Mno) VALUES('" + username + "'," + usermno + " )";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("data inserted into the table");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
