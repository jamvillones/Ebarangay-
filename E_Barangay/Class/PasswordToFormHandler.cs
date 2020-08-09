using E_Barangay.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Barangay.Class
{
    public class PasswordToFormHandler<T> where T : Form, new()
    {
        public T form { get; private set; }
        private bool correctPass;
        public event EventHandler<T> InitNextForm;
        public PasswordToFormHandler()
        {

           
        }
        public void Start()
        {
            form = new T();
            correctPass = false;

            using (var passwordForm = new PasswordForm("Please re enter you password to continue."))
            {
                passwordForm.OnCorrectPassword += PasswordForm_OnCorrectPassword;
                passwordForm.Disposed += PasswordForm_Disposed;
                passwordForm.ShowDialog();
            }
        }

        private void PasswordForm_Disposed(object sender, EventArgs e)
        {
            if (!correctPass)
                return;

            using (form)
            {
                InitNextForm?.Invoke(this,form);
                form.ShowDialog();
            }
        }

        private void PasswordForm_OnCorrectPassword(object sender, bool e)
        {
            correctPass = e;
        }
    }
}
