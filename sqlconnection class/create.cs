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
        public string connectionstring = "@Data Source=.;Initial Catalog=MOBACK;Integrated Security=True";

        public void Createuser()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionstring);
                sqlConnection.Open();
                Console.WriteLine("Connection established");
                //craete crud

                string insertQuery = "EXEC InsertData";
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
        public void Readdata()
        {
            try
            {
                sqlConnection.Open();
                string displayquery = "select * from Display";
                SqlCommand displayCommand = new SqlCommand(displayquery, sqlConnection);
                SqlDataReader dataReader = displayCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine("Employee.emp_id" + dataReader.GetValue(0).ToString());
                    Console.WriteLine("Deperment.dept_name" + dataReader.GetValue(1).ToString());
                    Console.WriteLine("Employee.emp_name " + dataReader.GetValue(2).ToString());
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
            public void updatedata()
            {
                try
                {
                    sqlConnection.Open();

                    string updatequery = "EXEC updtdemployee";
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

            public void DeleteData()
            {
                try
                {
                    sqlConnection.Open();
                    string deletequery = "Exec SP_DeleteEmploye";
                    SqlCommand deletecommand = new SqlCommand(deletequery, sqlConnection);
                    deletecommand.ExecuteNonQuery();
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
}
