using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SIS
{
    class StudentFormDb
    {

        //connect to database
         SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-S6KAUUS;Initial Catalog=StudentInfo;Integrated Security=True");
         //get connection 
         public SqlConnection getConnection
        {
            get
            {
                return sqlConnection;
            }
               
           
        }
        //openConnection
        public void openConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
    } 
}
