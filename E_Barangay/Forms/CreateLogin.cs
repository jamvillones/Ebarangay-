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
            using (var eb = new EB_LoginsEntities())
            {
                var u = eb.Users.FirstOrDefault(x => x.Username == UsernameTxt.Text);
                if (u != null)
                {
                    MessageBox.Show("Username already taken.");
                    return;
                }
            }
            if (!SamePassword)
            {
                ActiveControl = PasswordTxt;
                MessageBox.Show("Password does not match");
                PasswordTxt.Clear();
                ConfirmPassTxt.Clear();
                return;
            }
            using (var a = new EB_LoginsEntities())
            {
                var user = new User();
                user.Id = Guid.NewGuid().ToString();
                user.Username = UsernameTxt.Text;
                user.Password = PasswordTxt.Text;

                user.AddLogin = CanAddUser.Checked;
                user.Rec_Delete = CanDelete.Checked;
                user.Rec_Edit = CanEdit.Checked;
                user.Rec_Create = CanReg.Checked;
                user.Comp_Create = Comp_Reg_cb.Checked;
                user.Comp_Edit = Comp_Edit_cb.Checked;
                user.IssueDocument = Issue_Doc_cb.Checked;

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
