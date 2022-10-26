using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlconnection_class
{
    public class update:create
    {
        public void updatedata()
        {
            try
            {
                sqlConnection.Open();
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
