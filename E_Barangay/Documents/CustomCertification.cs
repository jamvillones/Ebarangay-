using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Forms;

namespace E_Barangay.Documents
{
    public partial class CustomCertification : Base
    {
        Class.OfficerInfo o = new Class.OfficerInfo();
        public CustomCertification()
        {
            InitializeComponent();
        }
        public override void InitializeControls()
        {
            AddControls(body,officerInfo,specimen);
            o.InitDropdowns(officerInfo);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);
            rect.Height += 6;
            string text = body.Text;
            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            if (!string.IsNullOrEmpty(specimen.Text))
            {
                Printing.DrawSpecimenSignature(e,specimen.Text);
            }
            if (!string.IsNullOrEmpty(officerInfo.Text))
            {
                Printing.DrawCapSb(e, o.captName, officerInfo.Text);
                return;
            }
            Printing.DrawCap(e, o.captName);
           
        }

        private void body_TextChanged(object sender, EventArgs e)
        {
            wordNum.Text = body.TextLength.ToString();
        }
    }
}
