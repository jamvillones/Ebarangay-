using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Class;
using System.Threading;

namespace E_Barangay.Forms
{
    public partial class QueryControl : UserControl
    {
        public event EventHandler IDEmptySearch;
        public QueryControl()
        {
            InitializeComponent();


        }
        public void setUser()
        {
            if (UserManager.instance.currentUser == null)
                return;
            user = UserManager.instance.currentUser;
            CreateBtn.Enabled = user.Rec_Create ? true : false;
            ModifyBtn.Enabled = user.Rec_Edit ? true : false;
            //DeleteBtn.Enabled = u.canDelete ? true : false;
        }


        System.Linq.IQueryable<Citizen> SearchedElements;
        public void PerformQuery()
        {
            if (SearchBox.Text == string.Empty)
            {
                MessageBox.Show("Search bar is empty!");
                showData();
                return;
            }

            DataTable.Rows.Clear();

            using (var context = new EBarangayEntities())
            {
                SearchedElements = context.Citizens.Where(x => (x.FirstName + x.MiddleName + x.LastName + x.Extension).Contains(SearchBox.Text));
                //if(true)
                //{
                //    SearchedElements = SearchedElements.Where(x => x.Indigent == true);
                //    PopulateTable(SearchedElements.ToArray());
                //}
                if (SearchedElements.Count() > 0)
                {
                    PopulateTable(SearchedElements.ToArray());
                    return;
                }
                else
                {
                    SearchedElements = context.Citizens.Where(x => x.Address.Contains(SearchBox.Text));
                    if (SearchedElements.Count() > 0)
                    {
                        PopulateTable(SearchedElements.ToArray());
                        return;
                    }
                }

                //if(!UserManager.instance.currentUser.canRegister)
                //{
                //    MessageBox.Show("User not found");
                //    return;
                //}

                Citizen c = context.Citizens.FirstOrDefault(x => x.ID == SearchBox.Text);
                if (c == null && UserManager.instance.currentUser.Rec_Create)
                {
                    var yesorno = new YesOrNoPrompt("Entry Not found. Would you like to go register instead?");
                    yesorno.FormClosed += (xx, yy) => { Enabled = true; };
                    yesorno.onBtnClick += (xx, yy) =>
                    {
                        if (yy)
                        {
                            IDEmptySearch?.Invoke(this, new EventArgs());
                            return;
                        }
                        /// set the total entries tag to 0
                        ResultTxt.Text = 0.ToString();
                    };
                    yesorno.Show();
                    Enabled = false;
                    return;
                }
                OpenPreview(c);
            }
        }
        void PopulateTable(Citizen[] c)
        {
            ResultTxt.Text = c.Length.ToString();
            DataTable.Rows.Clear();
            for (int i = 0; i < c.Length; i++)
            {
                DataTable.Rows.Add();
                DataTable.Rows[i].Cells[0].Value = c[i].ID;
                DataTable.Rows[i].Cells[1].Value = c[i].getNameWithSpace();
                DataTable.Rows[i].Cells[2].Value = c[i].Address;

            }
        }

        public void showData()
        {
            ///DataGrid();
            //Thread thread = new Thread(SetDataGrid);

            //thread.Start();
            using (var e = new EBarangayEntities())
                PopulateTable(e.Citizens.OrderBy(x => x.FirstName).ToArray());
        }
        void SetDataGrid()
        {
            using (var e = new EBarangayEntities())
                PopulateTable(e.Citizens.ToArray());
        }

        private void SearchBtn_Click(object sender, EventArgs e) => PerformQuery();
        User user;

        private void QueryControl_Load(object sender, EventArgs e)
        {
            IDEmptySearch += OpenReg;
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (SearchBox.Text == string.Empty)
                    return;

                PerformQuery();
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == string.Empty)
            {
                showData();
            }
        }
        /// <summary>
        /// Open Preview Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            OpenPreview(getCitizenByIndex);
        }
        private void InspectBtn_Click(object sender, EventArgs e)
        {
            if (DataTable.Rows.Count == 0)
                return;

            OpenPreview(getCitizenByIndex);

        }

        Citizen getCitizenByIndex
        {
            get
            {
                var c = new Citizen();
                int selectedrowindex = DataTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DataTable.Rows[selectedrowindex];
                string Value = Convert.ToString(selectedRow.Cells[0].Value);
                using (var m = new EBarangayEntities())
                {
                    c = m.Citizens.FirstOrDefault(r => r.ID == Value);
                    return c;
                }


            }
        }

        #region Modify
        PasswordToFormHandler<EditCitizen> edithandler;
        void OpenEditPage(Citizen c)
        {
            if (edithandler == null)
            {
                edithandler = new PasswordToFormHandler<EditCitizen>();
                edithandler.OnExit += Edithandler_OnExit;
                /// disable modify button
                ModifyBtn.Enabled = false;
                /// set details to be edited
                EditCitizen editPage = edithandler.form;
                editPage.AssignCitizen(c);
            }

        }

        private void Edithandler_OnExit(object sender, EventArgs e)
        {
            edithandler = null;
            ModifyBtn.Enabled = true;
        }
        #endregion

        #region previewshow
        Preview preview;
        void OpenPreview(Citizen citizen)
        {
            if (citizen == null)
            {
                MessageBox.Show("User not found.");
                return;
            }
            if (preview == null)
            {
                preview = new Preview();
                preview.AcceptDetails(citizen);
                preview.FormClosing += Preview_FormClosing;
                preview.OnRecordDeleted += Preview_OnRecordDeleted;
                preview.Show();
            }
            else
            {
                preview.AcceptDetails(citizen);
                preview.BringToFront();
            }
        }

        private void Preview_OnRecordDeleted(object sender, EventArgs e)
        {
            showData();
        }

        private void Preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            preview.FormClosing -= Preview_FormClosing;
            preview = null;
        }
        #endregion

        //private void SearchBox_Click(object sender, EventArgs e)
        //{

        //}
        public Control getDesiredControl
        {
            get
            {
                return SearchBox;
            }
        }

        bool GridEmpty
        {
            get
            {
                return DataTable.Rows.Count == 0;
            }
        }
        private void QueryControl_Enter(object sender, EventArgs e)
        {
            if (GridEmpty)
            {
                showData();
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            OpenReg(this, new EventArgs());
        }

        AddCitizenForm addCitizenForm;
        void OpenReg(object o, EventArgs e)
        {
            if (addCitizenForm == null)
            {
                addCitizenForm = new AddCitizenForm();
                addCitizenForm.FormClosed += Reg_FormClosed;               
                addCitizenForm.Show();
                return;
            }
            addCitizenForm.BringToFront();
        }

        private void Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            addCitizenForm = null;
        }
        //PasswordForm passwordForm;
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            if (DataTable.Rows.Count == 0)
            {
                return;
            }

            OpenEditPage(getCitizenByIndex);
        }

        AdvancedSearchForm adv;
        private void adSearchBtn_Click(object sender, EventArgs e)
        {
            if (adv == null)
            {
                adv = new AdvancedSearchForm();
                adv.FormClosed += (a, b) => { adv = null; };
                adv.Show();                
                return;
            }
            adv.BringToFront();

        }
    }
}
