using E_Barangay.Class;
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

        public MainPage()
        {
            InitializeComponent();
        }

        private void QueryBtn_Click(object sender, EventArgs e)
        {
            SetSelectionPanel(QueryBtn);
            SwitchPage(QueryPage);
            QueryPage.BringToFront();
        }
        private void DashBtn_Click(object sender, EventArgs e)
        {
            if (Current == DashControl)
                return;

            SwitchPage(DashControl);
            SetSelectionPanel(DashBtn);
            DashControl.BringToFront();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SwitchPage(printingFiles);
            SetSelectionPanel(IssueBtn);
            printingFiles.BringToFront();
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
            Current.TabStop = false;
            Current = next;
            Current.TabStop = true;
            ///this is lazy load
            ActiveControl = Current;
        }

        void SwitchAccept(Interface.IAccept accept)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            User curr = UserManager.instance.currentUser;
            UserWelcomeTxt.Text = "Welcome: " + curr.Username;
            Current = DashControl;
            printingFiles.OpeningForm += (x, y) => { Enabled = !y; };
            try
            {
                DashControl.InitValues();
                QueryPage.setUser();
                complaintPage.LoadValues();
            }
            catch
            {

            }
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

        Form cl;
        private void button2_Click(object sender, EventArgs e)
        {
            if (cl == null)
            {
                cl = new SettingsForm();
                cl.FormClosed += Cl_FormClosed;
                cl.Show();
                this.Enabled = false;
                return;
            }
        }

        private void Cl_FormClosed(object sender, FormClosedEventArgs e)
        {
            cl = null;
            this.Enabled = true;
            // throw new NotImplementedException();
        }

        BussinessClearance bussincessClearance;
        private void button2_Click_1(object sender, EventArgs e)
        {
            bussincessClearance = new BussinessClearance();
            bussincessClearance.FormClosing += (s, en) => { this.Enabled = true; };
            bussincessClearance.Show();
            this.Enabled = false;
        }

        private void MainPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                OpenCreateLogin();
            }
            if (e.KeyCode == Keys.F2)
            {
                OpenStats();
            }
            if (e.KeyCode == Keys.F3)
                this.WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            if (e.KeyCode == Keys.F5)
            {
                refresh();
            }
            if (e.KeyCode == Keys.F4)
                this.FormBorderStyle = this.FormBorderStyle == FormBorderStyle.None ? FormBorderStyle.Sizable : FormBorderStyle.None;
        }
        void refresh()
        {
            DashControl.InitValues();
            QueryPage.showData();
        }
        void OpenCreateLogin()
        {
            this.Enabled = false;
            CreateLogin createLogin = new CreateLogin();
            createLogin.FormClosed += (s, eventdetails) => { Enabled = true; };
            createLogin.Show();
        }
        void OpenStats()
        {
            this.Enabled = false;
            StatForm statForm = new StatForm();
            statForm.FormClosed += (a, b) => { Enabled = true; };
            statForm.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenStats();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            OpenCreateLogin();
        }

        private void complaintsBtn_Click(object sender, EventArgs e)
        {
            SetSelectionPanel(complaintsBtn);
            SwitchPage(complaintPage);
            complaintPage.BringToFront();
        }
    }
}
