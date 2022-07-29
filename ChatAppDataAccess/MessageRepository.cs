using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ChatApp_Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDataAccess
{
    public class MessageRepository : Repository, IRepository
    {
        public MessageRepository(List<SqlParameter> parameters) : base(parameters)
        {
        }

        public List<MessageModel> GetMessages(string sp)
        {
            List<MessageModel> output = new List<MessageModel>();
            var data = ReadData(sp);

            while (data.Read())
            {
                output.Add(new MessageModel
                {
                    MessageContent = data["UserMessage"].ToString()
                });
            }

            data.Close();
            return output;
        }

    }
}
