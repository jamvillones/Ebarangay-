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

        public PasswordForm(string message)
        {
            user = Class.UserManager.instance.currentUser;
            InitializeComponent();
            MessageLabel.Text = "Please re-enter your password " + user.Username;
        }
        bool correctPass
        {
            get
            {
                return PasswordTxt.Text == user.Password;
            }
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (user == null) return;
            //if(PasswordTxt.Text == user.Password)
            //{
            //    this.Close();
            //    OnCorrectPassword?.Invoke(this, true);
            //    return;
            //}

            OnCorrectPassword?.Invoke(this, correctPass);

            if (!correctPass)
                MessageBox.Show("Wrong password");
            else
                this.Close();

        }
        //public void CallerCloseCallback(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}
