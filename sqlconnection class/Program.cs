using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlconnection_class
{
    internal class program
    {
        static void Main(string[] args)
        {
            //create Create = new create();
            //Create.Createuser();
            Read_data read_Data = new Read_data();
            read_Data.Readdata();
            //update Update=new update();
            //Update.updatedata();
            //Delete delete=new Delete();
            //delete.DeleteData();

        }
    }
}
