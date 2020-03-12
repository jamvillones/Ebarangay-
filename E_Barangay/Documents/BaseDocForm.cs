using E_Barangay.Class;
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
using E_Barangay.Interface;


namespace E_Barangay.Forms
{
    public partial class BaseDocForm : Form
    {
        protected List<Control> controls = new List<Control>();
        protected OfficersForInfoForPrinting o;


        public BaseDocForm()
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

        public virtual void Printing_PrintPage(object sender, PrintPageEventArgs e) { }

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
            o = new OfficersForInfoForPrinting();
            InitializeControls();
            subscribe();
            printing.PrintPage += Printing_PrintPage;

        }

        //void ICitizenAcceptor.AcceptCitizen(Citizen citizen)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
