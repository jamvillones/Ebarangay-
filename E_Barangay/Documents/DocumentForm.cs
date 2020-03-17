using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using E_Barangay.Forms;

namespace E_Barangay.Documents
{
    public partial class DocumentForm : Form
    {
        protected List<Control> controls = new List<Control>();
        protected string capt = string.Empty;
        protected Rectangle rect;

        protected void InitBodyRect(PrintPageEventArgs e)
        {
            rect.X = e.PageBounds.Width / 3 - 30;
            rect.Y = e.PageBounds.Height / 3 - 10;
            rect.Width = 550;
            rect.Height = 380;
        }

        public void ShowNotFound()
        {
            MessageBox.Show("Not Found.");
        }
        protected string ToWhom
        {
            get
            {
                return "To whom it may concern";
            }
        }
        protected bool NullCheck(Citizen c)
        {
            if (c == null)
            {
                ShowNotFound();
                return true;
            }
            return false;
        }
        public DocumentForm()
        {
            InitializeComponent();


        }
        public virtual void InitializeControls() { }

        protected void AddControls(params Control[] c)
        {
            foreach (var i in c)
            {
                controls.Add(i);
            }
        }
        void subscribe()
        {
            printing.SubscribeToFields(controls.ToArray());
        }

        public virtual void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.GenericBG, Point.Empty);
            InitBodyRect(e);

        }


        public bool debug = false;
        protected void DrawDebugRecs(Rectangle rec, PrintPageEventArgs e)
        {
            if (debug)
            {
                e.Graphics.DrawRectangle(Printing.pen, rec);
            }
        }

        #region autoAssign
        public virtual void AcceptCitizen(Citizen c)
        {

        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {
            using (var entity = new EBarangayEntities())
            {
                var citizen = entity.Citizens.Find(IDField.Text);
                if (citizen == null)
                {
                    MessageBox.Show("ID not found!");
                    return;
                }

                if (!string.IsNullOrEmpty(citizen.RefRecords))
                {

                    MessageBox.Show("A complaint is associated with this ID. Are you sure you want to continue?");
                }
                AcceptCitizen(citizen);
            }
        }
        #endregion

        #region Clearing
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clearFields(controls.ToArray());
            IDField.Clear();
        }
        void clearFields(params Control[] controls)
        {
            foreach (Control c in controls)
            {
                c.ResetText();
            }
        }

        #endregion

        private void DeathCertificate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                debug = !debug;
                printing.UpdateDocument();
            }
        }

        private void goLoad(object sender, EventArgs e)
        {
            //o = new OfficersForInfoForPrinting();
            InitializeControls();
            subscribe();
            printing.PrintPage += Printing_PrintPage;

        }
    }
}
