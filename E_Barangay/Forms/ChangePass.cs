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
    public partial class ChangePass : Form
    {
        User currentUser;
        public ChangePass()
        {
            InitializeComponent();

            newPassword.Validated += Helper.TextBoxTrimSpaces;
            confirmPassword.Validated += Helper.TextBoxTrimSpaces;
            currPassword.Validated += Helper.TextBoxTrimSpaces;
        }
        public void SetUser(string u)
        {
            using (var eb = new EB_LoginsEntities())
            {
                var user = eb.Users.FirstOrDefault(x => x.Username == u);
                currentUser = user;
                currUser.Text = user.Username;
            }
        }
        bool canSave()
        {
            if(currPassword.Text != currentUser.Password)
            {
                MessageBox.Show("Current password is not correct.");
                return false;
            }
            if (newPassword.Text != confirmPassword.Text)
            {
                MessageBox.Show("New password and confirm password does not match");
                return false;
            }
            return currPassword.Text != string.Empty || newPassword.Text != string.Empty || confirmPassword.Text != string.Empty;
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (!canSave())
                return;

            using (var eb = new EB_LoginsEntities())
            {
                var u = eb.Users.FirstOrDefault(x => x.Username == currentUser.Username);
                if (u != null)
                {
                    u.Password = newPassword.Text;
                }
                eb.SaveChanges();
                MessageBox.Show("Password successfully changed.");
                this.Close();
            }
        }
    }
}
