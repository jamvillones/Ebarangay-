using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using E_Barangay.Class;
using E_Barangay.Forms;

namespace E_Barangay.Documents
{
    public partial class DocumentForm : Base
    {
        public DocumentForm()
        {
            InitializeComponent();
        }

        protected string capt = string.Empty;

        public void ShowNotFound()
        {
            MessageBox.Show("Not Found.");
        }
        public override void InitializeControls()
        {
            base.InitializeControls();
            controls.AddRange(FieldsPanel.GetContainedControls<TextBox>());
            controls.AddRange(FieldsPanel.GetContainedControls<ComboBox>());
            controls.AddRange(FieldsPanel.GetContainedControls<DateTimePicker>());
            controls.AddRange(FieldsPanel.GetContainedControls<NumericUpDown>());
            controls.AddRange(FieldsPanel.GetContainedControls<CheckBox>());
            controls.Remove(idField);
            //AddControls(FieldsPanel.GetContainedControls<TextBox>().ToArray());
        }
        public void CustomHeaderCert(PrintPageEventArgs e, string header)
        {
            e.Graphics.DrawImage(Properties.Resources.NoHeader, Point.Empty);
            Rectangle r = new Rectangle(e.PageBounds.Width / 3 - 30,
                                      e.PageBounds.Height / 5 + 20,
                                      550, 100);
            StringFormat s = new StringFormat();
            s.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(header, Printing.headerFont, Brushes.Red, r, s);
            DrawDebugRecs(r, e);

        }
        protected override void SaveToDatabase()
        {
            using(var eb = new EBarangayEntities())
            {
                var citizen = eb.Citizens.FirstOrDefault(x => x.IdNumber == idField.Text);
                if(citizen == null)
                {
                    MessageBox.Show("Document not saved in citizen");
                    return;
                }

                var newDocument = new Document();
                newDocument.Citizen = citizen;
                newDocument.DocumentTitle = this.Text;
                newDocument.DateIssued = DateTime.Now;
                newDocument.ControlNumber = Guid.NewGuid().ToString();
                eb.Documents.Add(newDocument);
                eb.SaveChanges();
            }
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



        #region autoAssign
        public virtual void AcceptCitizen(Citizen c)
        {

        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {
            using (var entity = new EBarangayEntities())
            {
                var citizen = entity.Citizens.FirstOrDefault(x => x.IdNumber == idField.Text);
                if (citizen == null)
                {
                    MessageBox.Show("ID not found!");
                    return;
                }

                //if (!string.IsNullOrEmpty(citizen.RefRecords))
                //{

                //    MessageBox.Show("A complaint is associated with this ID. Are you sure you want to continue?");
                //}
                AcceptCitizen(citizen);
            }
        }
        #endregion

        #region Clearing
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clearFields(controls.ToArray());
            idField.Clear();
        }

        void clearFields(params Control[] controls)
        {
            foreach (Control c in controls)
            {
                if (c is NumericUpDown)
                {
                    var n = (NumericUpDown)c;
                    n.Value = n.Minimum;
                }
                else
                    c.ResetText();
            }
        }
        #endregion
        private OfficerInfo info;
        protected OfficerInfo getOfficerInfo
        {
            get
            {
                if(UserManager.instance == null)
                {
                    info = new OfficerInfo();
                }

                info = UserManager.instance.Officers;
                return info;
            }
        }
        
       
    }
}
