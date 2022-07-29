using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Model
{
    public class User
    {
        public int UserID { get; set; }        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<User> UserFriend { get; set; }

        /// <summary>
        /// Set basic details of User
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="FirstName"></param>
        /// <param name="MiddleName"></param>
        /// <param name="LastName"></param>
        /// <param name="UserFriend"></param>
        public User(int UserID, string FirstName, string MiddleName, string LastName)
        {
            this.UserID = UserID;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
        }

        public User()
        {

        }
    }
}
