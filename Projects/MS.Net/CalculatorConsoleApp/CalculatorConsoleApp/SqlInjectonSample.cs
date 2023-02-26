using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    public class SqlInjectonSample
    {
        public object UnsafeQuery(string connection, string name, string password)
        {
            SqlConnection someConnection = new SqlConnection(connection);
            SqlCommand someCommand = new SqlCommand();
            someCommand.Connection = someConnection;

            someCommand.CommandText = "SELECT AccountNumber FROM Users " +
               "WHERE Username='" + name +
               "' AND Password='" + password + "'";

            someConnection.Open();
            object accountNumber = someCommand.ExecuteScalar();
            someConnection.Close();
            return accountNumber;
        }
    }
}
