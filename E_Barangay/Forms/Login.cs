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
using E_Barangay.Class;

namespace E_Barangay.Forms
{
    public partial class Login : Form
    {
        //string username, password;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            #region connectiontest
            try
            {
                using (var context = new EBarangayEntities())
                {
                    context.Database.Connection.Open();
                    context.Database.Connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            #endregion

            if (!canLogin())
            {
                MessageBox.Show("Invalid Login");
                return;
            }

            using (var t = new EB_LoginsEntities())
            {
                var u = from user in t.Users
                        where user.Username == UsernameTxt.Text && user.Password == PasswordTxt.Text
                        select user;
                if (u.Count() == 0)
                {
                    MessageBox.Show("User Not Found");
                    return;
                }
                UserManager.instance.currentUser = u.First();
            }

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

        private void RevealBtn_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordTxt.PasswordChar = '\0';
        }

        private void RevealBtn_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordTxt.PasswordChar = '*';
        }
    }
}
