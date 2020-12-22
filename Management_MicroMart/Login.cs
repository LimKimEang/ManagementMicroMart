using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_MicroMart
{
    public partial class Login : Form
    {
        private string _UserName;
        private string _Password;

        public Login()
        {
            InitializeComponent();
        }
        public string login_Username
        {
            get { return this._UserName; }
            set { this._UserName = value; }
        }
        public string login_Password
        {
            get { return this._Password; }
            set { this._Password = value; }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtUserName.Text = login_Username;
            txtPassword.Text = login_Password;     
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (login_Password != "1234" || login_Username !="Staff")
            {
                MessageBox.Show("Please try again!");
            }
            else
            {
                MessageBox.Show("Login Successful");
            }
        }
    }
}
