using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    public class Request
    {
        private int _RequestID;
        public Request(int requestID)
        {
            _RequestID = requestID;
        }
        public int RequestID
        {
            get { return _RequestID; }
        }
    }
    class DB
    {
        SqlConnection connection = new SqlConnection("Data Source=LIM;Initial Catalog=IOOPAssignment;Integrated Security=True");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
