using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace sqlconnection_class
{
    public class Read_data :create
    {
       
        public void Readdata()
        {
            try
            {
                sqlConnection.Open();
                string displayquery = "select * from details";
                SqlCommand displayCommand = new SqlCommand(displayquery, sqlConnection);
                SqlDataReader dataReader = displayCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine("user_id :" + dataReader.GetValue(0).ToString());
                    Console.WriteLine("user_name :" + dataReader.GetValue(1).ToString());
                    Console.WriteLine("user_Mno :" + dataReader.GetValue(2).ToString());
                }  
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
