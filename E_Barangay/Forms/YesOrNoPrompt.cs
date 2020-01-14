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
    public partial class YesOrNoPrompt : Form
    {
        public event EventHandler<bool> onBtnClick;
        public YesOrNoPrompt()
        {
            InitializeComponent();
        }
        public YesOrNoPrompt(string Message)
        {
            InitializeComponent();
            MessageTxt.Text = Message;

        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            onBtnClick?.Invoke(this, true);
            this.Close();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            onBtnClick?.Invoke(this, false);
            this.Close();
        }

        private void YesOrNoPrompt_Load(object sender, EventArgs e)
        {
            FormClosed += YesOrNoPrompt_FormClosed;
        }

        private void YesOrNoPrompt_FormClosed(object sender, FormClosedEventArgs e)
        {
            onBtnClick?.Invoke(this, false);
           // throw new NotImplementedException();
        }
    }
}
