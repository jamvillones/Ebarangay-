using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Barangay.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!canLogin())
            {
                MessageBox.Show("Invalid Login");
                return;
            }

        }
        bool canLogin()
        {
            if ((UsernameTxt.Text != string.Empty && UsernameTxt.Text != "Username") &&
                (PasswordTxt.Text != string.Empty && PasswordTxt.Text != "Password"))
            {
                return true;
            }
            return false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            PasswordTxt.PasswordChar = '*';
        }
    }
}
