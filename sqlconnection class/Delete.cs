using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlconnection_class
{
    public class Delete : create
    {

        public void DeleteData()
        {
            try
            {
                sqlConnection.Open();
                int id;
                Console.WriteLine("enter the user id that is to be deleted");
                id = Convert.ToInt32(Console.ReadLine());
                string deletequery = "delete from Details  where user_id = " + id;
                SqlCommand deletecommand = new SqlCommand(deletequery, sqlConnection);
                deletecommand.ExecuteNonQuery();
                Console.WriteLine("data succesfull deleted");
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
