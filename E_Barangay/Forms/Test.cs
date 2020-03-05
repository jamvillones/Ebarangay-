using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Class;

namespace E_Barangay.Forms
{
    public partial class Test : Form
    {
        int firstCharOnPage;
        public Test()
        {
            InitializeComponent();
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Start at the beginning of the text
            firstCharOnPage = 0;
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Clean up cached information
            //rt.FormatRangeDone();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.BarangayClearance_tmp, Point.Empty);
            Rectangle bodyRect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 - 45, 548, 330);
            rt.Print(e, bodyRect);

            // e.Graphics.DrawRectangle(new Pen(Brushes.Black), bodyRect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Print the contents here
            printDocument1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Document = printDocument1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            rt.SelectionFont = Printing.fontBoldUnderline;

        }
    }
}
