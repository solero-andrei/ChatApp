using ChatApp_Controller;
using ChatApp_Controller.Interface;
using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_Project
{
    public partial class MessageForm : UserControl, IUsersView
    {
        UserController controller;
        public MessageForm()
        {
            InitializeComponent();
            controller = new UserController(this);
        }

        public int UserID { get; set; } = 1000;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<User> UserFriend { get; set; }

        public MessageModel UserMessage { get; set; }

        public List<MessageModel> GetMessages()
        {
            throw new NotImplementedException();
        }

        public void OpenFriends()
        {
            throw new NotImplementedException();
        }

        public void OpenMessage()
        {
            throw new NotImplementedException();
        }

        public void RefreshMessages()
        {
            throw new NotImplementedException();
        }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.SendMessage();
        }
    }
}
