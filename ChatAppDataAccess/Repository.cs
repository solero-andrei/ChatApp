using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChatAppDataAccess
{
    public class Repository : IRepository
    {
        public List<SqlParameter> parameters { get; set; }
        public Repository(List<SqlParameter> parameters)
        {
            this.parameters = parameters;
        }

        public void InsertData(string sp)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString.Connection))
            using (SqlCommand command = new SqlCommand())
            {
                cn.Open();
                command.Connection = cn;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = sp;
                command.Parameters.AddRange(parameters.ToArray());

                command.ExecuteNonQuery();
            }
        }

        public SqlDataReader ReadData(string sp)
        {
            SqlConnection cn = new SqlConnection(ConnectionString.Connection);
            SqlCommand command = new SqlCommand();

            cn.Open();
            command.Connection = cn;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = sp;
            command.Parameters.AddRange(parameters.ToArray());
            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }
    }
}
