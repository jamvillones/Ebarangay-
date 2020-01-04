using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Barangay.Forms
{
    public partial class RecordForm : Form
    {
        Interface.IRecordAcceptor Regref;
        public void GetRef(Interface.IRecordAcceptor r)
        {
            Regref = r;
        }
      
        public RecordForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Record r = new Record();
            r.ID = Guid.NewGuid().ToString();
            r.Name = TitleField.Text;
            r.Details = DetailsField.Text;
            r.DateIssued = DatePicker.Value;
            Regref.AcceptRecord(r);
            MessageBox.Show("Successfully Saved");
            ClearValues();
        }
        void ClearValues()
        {
            DetailsField.Clear();
            TitleField.Clear();
            this.ActiveControl = TitleField;
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {

        }
        bool ValidSave()
        {
            return DetailsField.Text != string.Empty && TitleField.Text != string.Empty;
        }
        private void DetailsField_TextChanged(object sender, EventArgs e)
        {
            SaveBtn.Enabled = ValidSave() ? true : false;
        }
        private void TitleField_TextChanged(object sender, EventArgs e)
        {
            SaveBtn.Enabled = ValidSave() ? true : false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
