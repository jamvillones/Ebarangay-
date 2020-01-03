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
    public partial class MainPage : Form
    {
        UserControl Current;
        Interface.IAccept currentAccept;
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// sets selection bar position according to button feed
        /// </summary>
        /// <param name="b"></param>
        /// 
        void SetSelectionPanel(Button b)
        {
            SelectionPanel.Height = b.Height;
            SelectionPanel.Top = b.Top;
        }
        void SwitchPage(UserControl next)
        {
            if (Current == next)
                return;
            Current.Enabled = false;
            Current.Visible = false;
            Current = next;
            Current.Enabled = true;
            Current.Visible = true;
            
        }
        void SwitchAccept(Interface.IAccept accept)
        {
            currentAccept = accept;
            this.AcceptButton = currentAccept.getAcceptButton();
        }
        private void DashBtn_Click(object sender, EventArgs e)
        {
            if (Current == DashControl)
                return;

            SwitchAccept(DashControl);
            SwitchPage(DashControl);
            SetSelectionPanel(DashBtn);
            DashControl.BringToFront();
            DashControl.ShowStats();
        }
       

        private void QueryBtn_Click(object sender, EventArgs e)
        {
            //currentAccept = QueryPage;
            SwitchAccept(QueryPage);

            SwitchPage(QueryPage);
            QueryPage.BringToFront();
            SetSelectionPanel(QueryBtn);
            this.ActiveControl = QueryPage.getDesiredControl;
        }


        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //currentAccept = RegisterPage;
            SwitchAccept(RegisterPage);
            SwitchPage(RegisterPage);
            RegisterPage.BringToFront();
            SetSelectionPanel(RegisterBtn);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // Class.UserManager.instance = new Class.UserManager();
            Current = DashControl;
            currentAccept = DashControl;
            try
            {
                DashControl.ShowStats();
                QueryPage.showData();
                RegisterPage.LoadValues();
            }
            catch
            {

            }

            QueryPage.Enabled = false;
            RegisterPage.Enabled = false;

            QueryPage.IDEmptySearch += QueryPage_IDEmptySearch;
        }

        private void QueryPage_IDEmptySearch(object sender, string e)
        {
            SwitchAccept(RegisterPage);
            SwitchPage(RegisterPage);
            RegisterPage.BringToFront();
            SetSelectionPanel(RegisterBtn);
            RegisterPage.AcceptNewUser(sender, e);
        }

        private void SelectionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QueryPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
           /// MaximizeBtn.Text = this.WindowState == FormWindowState.Maximized ? "Minimize" : "Maximize";
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        BarangayClearanceForm printing;
        private void button1_Click_1(object sender, EventArgs e)
        {
            printing = new BarangayClearanceForm();
            printing.FormClosing += Printing_FormClosing;
            printing.Show();
            this.Enabled = false;
            //printing.BringToFront();
        }

        private void Printing_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
            //throw new NotImplementedException();
        }
    }
}
