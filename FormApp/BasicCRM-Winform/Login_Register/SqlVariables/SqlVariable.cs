using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login_Register.SqlVariables
{
    public class SqlVariable
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DSIGTHM\\SQLEXPRESS;Initial Catalog=UserList;Integrated Security=True");

        
        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State==ConnectionState.Closed)
            {
                tempConnection.Open();
            }
            else
            {

            }
            
        }
    }
}
