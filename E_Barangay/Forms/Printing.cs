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
            // printPreviewControl.Document = printDocument;

        }
        public static void DrawValidityOr(PrintPageEventArgs e, string orNo, DateTime orIssue, DateTime vdt)
        {
            string validity = vdt.ToString("MMMM dd, yyyy");
            string issuedOn = orIssue.ToString("MMMM dd, yyyy");
            string text = "Note: Valid until: " + validity + "\n" +
                          "Paid under Or No.: " + orNo + "\n" +
                          "Issued on: " + issuedOn;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;

            SizeF s = e.Graphics.MeasureString(text, Printing.font);
            Rectangle r = new Rectangle(e.PageBounds.Width / 3 - 30,
                                        e.PageBounds.Height * 4 / 5 - 15,
                                        (int)s.Width + 1, (int)s.Height);

            e.Graphics.DrawString(text, Printing.font, Brushes.Black, r);

        }
        public static void DrawSpecimenSignature(PrintPageEventArgs e, string nnn)
        {
            string name = string.IsNullOrEmpty(nnn.Trim(' ')) ? "BLANK" : nnn;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            SizeF n = e.Graphics.MeasureString(name.ToUpper(), Printing.fontBoldUnderline);
            SizeF titleBoxSize = e.Graphics.MeasureString("Specimen Signature of Applicant", Printing.font);

            Rectangle nameRec = new Rectangle(e.PageBounds.Width / 3 - 30,
                                              e.PageBounds.Height * 2 / 3 + 40,
                                              n.Width < titleBoxSize.Width ? (int)titleBoxSize.Width + 1 : (int)n.Width, (int)n.Height);

            e.Graphics.DrawString(name.ToUpper(), Printing.fontBold, Brushes.Black, nameRec, format);


            Rectangle titleRec = new Rectangle(e.PageBounds.Width / 3 - 30,
                                               nameRec.Bottom,
                                               nameRec.Width, (int)titleBoxSize.Height * 2);

            e.Graphics.DrawString("Specimen Signature of Applicant", Printing.font, Brushes.Black, titleRec, format);

        }
        public static void DrawCapSb(PrintPageEventArgs e, string cap, string sb)
        {
            SizeF capBoxSize = e.Graphics.MeasureString(cap, Printing.fontBold);
            SizeF titleBoxSize = e.Graphics.MeasureString(cap, Printing.font);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            Rectangle captRec = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, e.PageBounds.Height * 2 / 3 + 40, 270, (int)capBoxSize.Height);
            e.Graphics.DrawString(cap.ToUpper(), Printing.fontBold, Brushes.Black, captRec, format);
            //DrawDebugRecs(captRec, e);

            Rectangle capRecTitle = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, captRec.Top + (int)capBoxSize.Height, 270, (int)titleBoxSize.Height * 2);
            e.Graphics.DrawString("Punong Barangay", Printing.font, Brushes.Black, capRecTitle, format);
            //DrawDebugRecs(capRecTitle, e);

            Rectangle sbRect = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, capRecTitle.Bottom + 30, 270, (int)capBoxSize.Height);
            e.Graphics.DrawString((string.IsNullOrEmpty(sb) ? "BLANK" : sb.ToUpper()), Printing.fontBold, Brushes.Black, sbRect, format);
            // DrawDebugRecs(sbRect, e);

            Rectangle sbRectTitle = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, sbRect.Top + (int)capBoxSize.Height, 270, (int)titleBoxSize.Height * 2);
            e.Graphics.DrawString("Sangguniang Barangay Member Officer of the Day", Printing.font, Brushes.Black, sbRectTitle, format);
            //DrawDebugRecs(sbRectTitle, e);
        }
        public static void DrawCap(PrintPageEventArgs e, string cap)
        {
            SizeF capBoxSize = e.Graphics.MeasureString(cap, Printing.fontBold);
            SizeF titleBoxSize = e.Graphics.MeasureString(cap, Printing.font);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            Rectangle captRec = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, e.PageBounds.Height * 2 / 3 + 40, 270, (int)capBoxSize.Height);
            e.Graphics.DrawString(cap.ToUpper(), Printing.fontBold, Brushes.Black, captRec, format);
            //DrawDebugRecs(captRec, e);

            Rectangle capRecTitle = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, captRec.Top + (int)capBoxSize.Height, 270, (int)titleBoxSize.Height * 2);
            e.Graphics.DrawString("Punong Barangay", Printing.font, Brushes.Black, capRecTitle, format);
            //DrawDebugRecs(capRecTitle, e);

            //Rectangle sbRect = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, capRecTitle.Bottom + 30, 270, (int)capBoxSize.Height);
            //e.Graphics.DrawString((string.IsNullOrEmpty(sb) ? "BLANK" : sb.ToUpper()), Printing.fontBold, Brushes.Black, sbRect, format);
            //// DrawDebugRecs(sbRect, e);

            //Rectangle sbRectTitle = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, sbRect.Top + (int)capBoxSize.Height, 270, (int)titleBoxSize.Height * 2);
            //e.Graphics.DrawString("Sangguniang Barangay Member Officer of the Day", Printing.font, Brushes.Black, sbRectTitle, format);
            ////DrawDebugRecs(sbRectTitle, e);
        }
        public static string GetFullName(Control f, Control m, Control l, Control e)
        {
            return f.Text + " " + m.Text + " " + l.Text + " " + (string.IsNullOrEmpty(e.Text) ? "" : " " + e.Text);
        }
        public static string GetName(Control f, Control m, Control l, Control e)
        {
            return f.Text + " " + (string.IsNullOrEmpty(m.Text) ? "" : m.Text[0].ToString().ToUpper() + ".") + " " + l.Text + " " + (string.IsNullOrEmpty(e.Text) ? "" : " " + e.Text);
        }
        public static Pen pen = new Pen(Color.Black);
        public static Font font = new Font("Arial Narrow", 12, FontStyle.Regular);
        public static Font headerFont = new Font("Arial Narrow", 22, FontStyle.Bold | FontStyle.Italic);
        public static Font fontBold = new Font("Arial Narrow", 12, FontStyle.Bold);
        public static Font fontBoldUnderline = new Font("Arial Narrow", 12, FontStyle.Bold | FontStyle.Underline);
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
        public static string HimOrHer(string sex)
        {
            return sex == string.Empty ? "BLANK" : (sex == "Male" ? "him" : "her");
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
