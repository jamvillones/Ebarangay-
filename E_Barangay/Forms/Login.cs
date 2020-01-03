using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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

            // //this.Close();
            // MainPage m = new MainPage();
            // //m.Load += M_Load1;
            // m.ShowDialog();
            // this.Close();
            //// this.Hide();
            UserSuccessfullyAuthenticated = true;
            Close();



        }
        public bool UserSuccessfullyAuthenticated { get; private set; }
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
           // PasswordLabel.Text = string.Empty;
        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {
            //UsernameLabel.Text = string.Empty;
        }

        private void PasswordTxt_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("hey");
            //PasswordTxt.Clear();
            //PasswordTxt.SelectAll();
        }

        private void PasswordTxt_Leave(object sender, EventArgs e)
        {
            if(PasswordTxt.Text == string.Empty)
            {
               // PasswordTxt.PasswordChar = Convert.ToChar("");
               // PasswordTxt.Text = "Password";
            }
        }
    }
}
