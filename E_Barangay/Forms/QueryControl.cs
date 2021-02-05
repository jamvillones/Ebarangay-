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
            CreateBtn.Enabled = user.Rec_Create;
            ModifyBtn.Enabled = user.Rec_Edit;
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

                Citizen c = context.Citizens.FirstOrDefault(x => x.IdNumber == SearchBox.Text);

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
            foreach (var i in c)
                DataTable.Rows.Add(i.ID, i.IdNumber, i.getNameWithSpace(), i.Address);
        }

        public void showData()
        {
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

        Citizen getCitizenByIndex
        {
            get
            {
                var c = new Citizen();
                int selectedrowindex = DataTable.SelectedCells[0].RowIndex;
                //DataGridViewRow selectedRow = DataTable.Rows[selectedrowindex];
                //string Value = DataTable.SelectedCells[0].Value.ToString();
                var Value = (int)(DataTable.SelectedCells[0].Value);
                using (var m = new EBarangayEntities())
                {
                    c = m.Citizens.FirstOrDefault(r => r.ID == Value);
                    return c;
                }
            }
        }

        #region Modify     
        /// <summary>
        /// the edit callback function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            if (DataTable.Rows.Count == 0)
                return;

            OpenEditPage(getCitizenByIndex);
        }
        /// <summary>
        /// the actual function that calls the edit handler
        /// </summary>
        /// <param name="citizen"></param>
        void OpenEditPage(Citizen citizen)
        {
            var passwordHandler = new PasswordToFormHandler<EditCitizen>();
            passwordHandler.InitNextForm += PasswordHandler_InitNextForm;
            passwordHandler.Start();
        }

        private void PasswordHandler_InitNextForm(object sender, EditCitizen e)
        {
            e.Onsave += Onsave_Callback;
            e.AssignCitizen(getCitizenByIndex);
        }

        private void Onsave_Callback(object sender, EventArgs e)
        {
            using (var eb = new EBarangayEntities())
            {
                PopulateTable(eb.Citizens.ToArray());
            }
            //throw new NotImplementedException();
        }
        #endregion

        #region previewshow
        private void InspectBtn_Click(object sender, EventArgs e)
        {
            if (DataTable.Rows.Count == 0)
                return;

            OpenPreview(getCitizenByIndex);
        }

        void OpenPreview(Citizen citizen)
        {
            if (citizen == null)
            {
                MessageBox.Show("User not found.");
                return;
            }
            using (var preview = new Preview())
            {
                preview.AcceptDetails(citizen);
                preview.OnRecordDeleted += Preview_OnRecordDeleted;
                preview.ShowDialog();
            }
        }

        private void Preview_OnRecordDeleted(object sender, EventArgs e)
        {
            showData();
        }
        #endregion

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

        void OpenReg(object o, EventArgs e)
        {

            using (var addCitizenForm = new AddCitizenForm())
            {
                addCitizenForm.Onsave += Onsave_Callback;
                addCitizenForm.ShowDialog();
            }

        }

        private void adSearchBtn_Click(object sender, EventArgs e)
        {

            using (var adv = new AdvancedSearchForm())
            {
                adv.ShowDialog();
            }
        }
    }
}
