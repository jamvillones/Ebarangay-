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
    public partial class PasswordForm : Form
    {
        public event EventHandler<bool> OnCorrectPassword;
        User user;
        //public PasswordForm()
        //{
        //    user = Class.UserManager.instance.currentUser;
        //    InitializeComponent();
        //}
        public PasswordForm(string message)
        {
            user = Class.UserManager.instance.currentUser;
            InitializeComponent();
            MessageLabel.Text = "Please re-enter your password " + user.Username;
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
           // User user = Class.UserManager.instance.currentUser;
            if (user == null) return;
            if(PasswordTxt.Text == user.Password)
            {
                OnCorrectPassword?.Invoke(this, true);
                this.Close();
                return;
            }
            OnCorrectPassword?.Invoke(this, false);
            MessageBox.Show("Wrong Password");
            this.Close();
        }
        public void CallerCloseCallback(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
