using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
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
    }
}
