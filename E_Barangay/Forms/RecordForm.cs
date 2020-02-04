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
    enum BlotterStatus { Pending, Settled }
    public partial class RecordForm : Form
    {
       // Interface.IRecordAcceptor Regref;

        public event EventHandler<Record> OnSave;
        //public void GetRef(Interface.IRecordAcceptor r)
        //{
        //    Regref = r;
        //}
      
        public RecordForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var yesOrNo = new YesOrNoPrompt("Are you sure you want to save?");
            yesOrNo.onBtnClick += YesOrNo_onBtnClick;
            yesOrNo.Show();
            this.Enabled = false;
           
        }

        private void YesOrNo_onBtnClick(object sender, bool e)
        {
            this.Enabled = true;
            if (!e)
                return;

            Record r = new Record();
            r.ID = Guid.NewGuid().ToString();
            r.Name = TitleField.Text;
            r.Details = DetailsField.Text;
            r.DateIssued = happenedDuring.Value;
            r.DateHappened = recordedOn.Value;
            r.Location = locationTxt.Text;
            r.SettlementDate = settlementSched.Value;
            r.Status = BlotterStatus.Pending.ToString();
            // Regref.AcceptRecord(r);
            OnSave?.Invoke(this, r);
            MessageBox.Show("Successfully Saved");
            ClearValues();
        }

        void ClearValues()
        {
            DetailsField.Clear();
            TitleField.Clear();
            locationTxt.Clear();
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
