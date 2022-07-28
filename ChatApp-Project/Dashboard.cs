using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Guna.UI2.WinForms;

namespace ChatApp_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            MessageDashboard messageDashboard = new MessageDashboard();
            MessageForm message = new MessageForm();
            wrapper.Controls.Add(message);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
