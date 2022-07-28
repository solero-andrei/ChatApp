using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDataAccess
{
    internal class ConnectionString
    {
        public static string Connection 
        { 
            get
            {
                return "Data Source=DESKTOP-VKKUBR7;Initial Catalog=ChatApp;Integrated Security=True;";
            }
        }
    }
}
