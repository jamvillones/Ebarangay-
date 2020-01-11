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
    public partial class CreateLogin : Form
    {
        public CreateLogin()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == string.Empty || PasswordTxt.Text == string.Empty)
            {
                MessageBox.Show("fields must not be empty!");
                return;
            }
            if (!SamePassword)
            {
                ActiveControl = PasswordTxt;
                MessageBox.Show("Password does not match");
                PasswordTxt.Clear();
                ConfirmPassTxt.Clear();
                return;
            }
            using (var a = new EBarangayEntities())
            {
                var user = new User();
                user.ID = Guid.NewGuid().ToString();
                user.Username = UsernameTxt.Text;
                user.Password = PasswordTxt.Text;
                user.canAddUser = CanAddUser.Checked;
                user.canDelete = CanDelete.Checked;
                user.canEdit = CanEdit.Checked;
                user.canRegister = CanReg.Checked;
                a.Users.Add(user);
                a.SaveChanges();
            }
            MessageBox.Show("Successfully added");
            this.Close();
        }
        /// <summary>
        /// checks if the password match
        /// </summary>
        bool SamePassword
        {
            get
            {
                return PasswordTxt.Text == ConfirmPassTxt.Text;
            }
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == string.Empty) return;
            checkImage.Visible = SamePassword ? true : false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (ConfirmPassTxt.Text == string.Empty) return;
            checkImage.Visible = SamePassword ? true : false;
        }
    }
}
