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
            if(UsernameTxt.Text == string.Empty || PasswordTxt.Text == string.Empty)
            {
                MessageBox.Show("fields must not be empty!");
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
    }
}
