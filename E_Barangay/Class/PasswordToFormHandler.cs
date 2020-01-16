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
        private PasswordForm passwordForm;

        public event EventHandler OnExit;
        //  public EventHandler OnSuccess;

        public PasswordToFormHandler()
        {
            //form =  Initialize<T>() 
            //form = new T where T: Form;
            form = new T();
            form.FormClosed += Form_FormClosed;

            passwordForm = new PasswordForm("Please re enter your password to continue");
            passwordForm.FormClosing += PasswordForm_FormClosing;
            passwordForm.OnCorrectPassword += PasswordForm_OnCorrectPassword;
            passwordForm.Show();
        }

        private void PasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
            OnExit?.Invoke(this, new EventArgs());
        }

        private void PasswordForm_OnCorrectPassword(object sender, bool e)
        {
            if (e)
                form.Show();
            else
            {
                OnExit?.Invoke(this, new EventArgs());
            }
            // throw new NotImplementedException();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnExit?.Invoke(this, new EventArgs());
        }
    }
}
