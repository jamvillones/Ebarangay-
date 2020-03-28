using E_Barangay.Forms;
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

namespace E_Barangay.Documents
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }
        protected Rectangle rect;

        protected void InitBodyRect(PrintPageEventArgs e)
        {
            rect.X = e.PageBounds.Width / 3 - 30;
            rect.Y = e.PageBounds.Height / 3 - 10;
            rect.Width = 550;
            rect.Height = 380;
        }

        private void keydown_Callback(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                Console.WriteLine("f4");
                debug = !debug;
                printing.UpdateDocument();
            }
        }

        private void goLoad(object sender, EventArgs e)
        {
            InitializeControls();
            Subscribe();
            printing.PrintPage += Printing_PrintPage;

        }
        protected List<Control> controls = new List<Control>();
        protected void AddControls(params Control[] c)
        {
            foreach (var i in c)
            {
                controls.Add(i);
            }
        }
        protected void Subscribe()
        {
            printing.SubscribeToFields(controls.ToArray());
        }

        #region overridables
        public virtual void InitializeControls()
        {

        }
        public virtual void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.GenericBG, Point.Empty);
            InitBodyRect(e);
            //DrawDebugRecs(rect, e);
        }
        #endregion

        #region debugs
        protected bool debug = false;
        protected void DrawDebugRecs(Rectangle rec, PrintPageEventArgs e)
        {
            if (debug)
            {
                e.Graphics.DrawRectangle(Printing.pen, rec);
            }
        }
        #endregion
    }
}
