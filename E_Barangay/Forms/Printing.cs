using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace E_Barangay.Forms
{
    public partial class Printing : UserControl
    {
        private PrintDocument document { get { return printDocument; } }
        public Button getUpdateBtn
        {
            get { return UpdateBtn; }
        }
        public event PrintPageEventHandler PrintPage
        {
            add { document.PrintPage += value; }
            remove { document.PrintPage -= value; }
        }


        public Printing()
        {
            InitializeComponent();
            //document.PrintPage
        }

        private void Printing_Load(object sender, EventArgs e)
        {


        }

        public static Pen pen = new Pen(Color.Black);
        public static Font font = new Font("Arial Narrow", 12, FontStyle.Regular);
        public static Font fontBold = new Font("Arial Narrow", 12, FontStyle.Bold);
        public static string Indention { get { return "        "; } }
        public static string LineSpace { get { return "\n\n\n"; } }

        public static string MrOrMrs(string sex)
        {
            if (sex == "")
                return "(BLANK)";

            return sex == "Male" ? "Mr." : "Ms.";
        }
        public static string HisOrHer(string sex)
        {
            return sex == string.Empty ? "BLANK" : (sex == "Male" ? "his" : "her");
        }

        public static string IfControlEmpty(Control c)
        {
            return string.IsNullOrEmpty(c.Text) ? "(BLANK)" : c.Text;
        }

        #region Edit
        bool editMade = false;
        void ToggleEdit()
        {
            if (editMade)
            {
                UpdateDocument();
            }
        }
        public void UpdateDocument()
        {
            printPreviewControl.Document = document;
            /// disable update button 
            UpdateBtn.Enabled = false;
            /// set editmade to false
            editMade = false;
        }
        /// <summary>
        /// callback for when fields are changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCallback(object sender, EventArgs e)
        {
            editMade = true;
            UpdateBtn.Enabled = true;
        }
        /// <summary>
        /// this allows the printing to detect changes based on subscribed controls
        /// </summary>
        /// <param name="c"></param>
        public void SubscribeToFields(params Control[] c)
        {
            foreach (Control cont in c)
                cont.TextChanged += EditCallback;
        }
        #endregion


        #region buttons Callback
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ToggleEdit();
        }
        //private void PrintPreviewBtn_Click(object sender, EventArgs e)
        //{
        //    ToggleEdit();
        //    printPreviewDialog.Document = document;
        //    printPreviewDialog.ShowDialog();
        //}

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            printDialog.Document = document;
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                document.Print();
            }
        }
        #endregion
    }
}
