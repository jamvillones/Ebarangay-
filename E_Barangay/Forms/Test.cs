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
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            //var sb = new StringBuilder();
            //sb.Append(@"hello neighbor");
            //rt.Rtf = sb.ToString();

            rt.Font = Printing.font;
        }
        RichTextBoxPrintCtrl rt = new RichTextBoxPrintCtrl();

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle rect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 + 50, 548, 320);
            rt.Clear();
            rt.AppendText("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Tortor pretium ");
            AddUnderlinedBoldString(rt, "viverra".ToUpper());
            rt.AppendText(" suspendisse potenti nullam ac. In iaculis nunc sed augue lacus viverra vitae congue eu. At urna condimentum mattis pellentesque id nibh tortor. In aliquam sem fringilla ut.");
            //e.Graphics.DrawRectangle(Pens.Black, rect);
            rt.Print(e, rect);
        }
        void AddUnderlinedBoldString(RichTextBoxPrintCtrl r, string s)
        {
            rt.SelectionFont = Printing.fontBoldUnderline;
            rt.AppendText(s);
            rt.SelectionFont = Printing.font;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }
        //Font f = new Font("Times New Roman", 11, FontStyle.Bold | FontStyle.Underline);
        private void button2_Click(object sender, EventArgs e)
        {
            rt.SelectionFont = Printing.fontBoldUnderline;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Document = printDocument1;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
