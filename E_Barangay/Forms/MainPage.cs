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
        
       //nterface.IAccept currentAccept;
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void QueryBtn_Click(object sender, EventArgs e)
        {
            //currentAccept = QueryPage;
            SetSelectionPanel(QueryBtn);
           //witchAccept(QueryPage);
            SwitchPage(QueryPage);
            QueryPage.BringToFront();
            //is.ActiveControl = QueryPage.getDesiredControl;
        }
        private void DashBtn_Click(object sender, EventArgs e)
        {
            if (Current == DashControl)
                return;

            //itchAccept(DashControl);
            SwitchPage(DashControl);
            SetSelectionPanel(DashBtn);
            DashControl.BringToFront();
            //DashControl.ShowStats();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
          

            SwitchPage(printingFiles);
            SetSelectionPanel(IssueBtn);
            printingFiles.BringToFront();

            //printing = new BarangayClearanceForm();
            //printing.FormClosing += Printing_FormClosing;
            //printing.Show();
            //this.Enabled = false;
            //printing.BringToFront();
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
            //Current.Enabled = false;
            // Current.Visible = false;
            //Current.TabStop = false;
            Current = next;
            //Current.TabStop = true;
           // Current.Enabled = true;
            //Current.Visible = true;

        }

        void SwitchAccept(Interface.IAccept accept)
        {
            //currentAccept = accept;
            //this.AcceptButton = currentAccept.getAcceptButton();
        }







        private void MainPage_Load(object sender, EventArgs e)
        {
            //mainPage = this;
            User curr = UserManager.instance.currentUser;
            UserWelcomeTxt.Text = "Welcome: " + curr.Username;
            //if(curr.canAddUser)
            AddNewLoginBtn.Enabled = curr.canAddUser ? true : false;
            // Class.UserManager.instance = new Class.UserManager();
            Current = DashControl;
            ///rentAccept = DashControl;
            try
            {
                DashControl.ShowStats();
                QueryPage.setUser();
                //QueryPage.showData();
                // RegisterPage.LoadValues();
            }
            catch
            {

            }

            QueryPage.IDEmptySearch += QueryPage_IDEmptySearch;
        }

        private void QueryPage_IDEmptySearch(object sender, string e)
        {
            //SwitchAccept(RegisterPage);
            // SwitchPage(RegisterPage);
            // RegisterPage.BringToFront();
            //SetSelectionPanel(RegisterBtn);
            // RegisterPage.AcceptNewUser(sender, e);
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
        //public static MainPage mainPage { get; private set; }



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
            //cl.BringToFront();

        }

        private void Cl_FormClosed(object sender, FormClosedEventArgs e)
        {
            cl = null;
            this.Enabled = true;
            // throw new NotImplementedException();
        }

        BarangayBussClearance bussincessClearance;
        private void button2_Click_1(object sender, EventArgs e)
        {
            bussincessClearance = new BarangayBussClearance();
            bussincessClearance.FormClosing += (s, en) => { this.Enabled = true; };
            bussincessClearance.Show();
            this.Enabled = false;
        }


    }
}
