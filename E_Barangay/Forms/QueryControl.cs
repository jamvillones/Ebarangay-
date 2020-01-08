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

namespace E_Barangay.Forms
{
    public partial class QueryControl : UserControl, E_Barangay.Interface.IAccept
    {
        public event EventHandler<string> IDEmptySearch;
        public QueryControl()
        {
            InitializeComponent();
            //AcceptButton = SearchBtn;

        }
        public Button getAcceptButton()
        {

            return SearchBtn;
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
                //switch (SearchFilter.Text)
                //{
                //    case "ID":
                //        SearchedElements = from Citizen in context.Citizens
                //                           where Citizen.ID.Contains(SearchBox.Text)
                //                           select Citizen;
                //        if (SearchedElements.Count() == 0)
                //        {
                //            IDEmptySearch.Invoke(this, SearchBox.Text);
                //            return;
                //        }
                //        break;
                //    case "Name":
                //        SearchedElements = from Citizen in context.Citizens
                //                           where Citizen.Name.Contains(SearchBox.Text)
                //                           select Citizen;
                //        break;
                //    case "Address":
                //        SearchedElements = from Citizen in context.Citizens
                //                           where Citizen.Address.Contains(SearchBox.Text)
                //                           select Citizen;
                //        break;
                //    default:
                //        break;
                //}

                /// search for id
                SearchedElements = from Citizen in context.Citizens
                                   where Citizen.Name.Contains(SearchBox.Text)
                                   select Citizen;
                if (SearchedElements.Count() > 0)
                {
                    PopulateTable(SearchedElements.ToArray());
                    return;
                }
                else
                {
                    SearchedElements = from Citizen in context.Citizens
                                       where Citizen.Address.Contains(SearchBox.Text)
                                       select Citizen;
                    if (SearchedElements.Count() > 0)
                    {
                        PopulateTable(SearchedElements.ToArray());
                        return;
                    }

                }


                SearchedElements = from Citizen in context.Citizens
                                   where Citizen.ID.Contains(SearchBox.Text)
                                   select Citizen;


                if (int.TryParse(SearchBox.Text, out int n))
                {
                    if (SearchedElements.Count() == 0)
                    {
                        IDEmptySearch.Invoke(this, SearchBox.Text);
                        return;
                    }
                    else if (SearchedElements.Count() == 1)
                    {
                        OpenPreview(SearchedElements.First());
                        return;
                    }
                }



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
                DataTable.Rows[i].Cells[1].Value = c[i].Name;
                DataTable.Rows[i].Cells[2].Value = c[i].Address;

            }
        }

        public void showData()
        {
            using (var e = new EBarangayEntities())
                PopulateTable(e.Citizens.ToArray());

        }

        private void SearchBtn_Click(object sender, EventArgs e) => PerformQuery();

        private void QueryControl_Load(object sender, EventArgs e)
        {
            User u = UserManager.instance.currentUser;
            CreateBtn.Enabled = u.canRegister ? true : false;
            ModifyBtn.Enabled = u.canEdit ? true : false;
            DeleteBtn.Enabled = u.canDelete ? true : false;
            //SearchFilter.SelectedIndex = 0;
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

        Preview preview;
        void OpenPreview(Citizen citizen)
        {
            if (preview == null)
            {
                preview = new Preview();
                preview.AcceptDetails(citizen);
                preview.FormClosing += Preview_FormClosing;
                preview.Show();
            }
            else
            {
                preview.AcceptDetails(citizen);
                preview.BringToFront();
            }
        }

        private void Preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            preview.FormClosing -= Preview_FormClosing;
            preview = null;
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SearchBox.Text))
            {
                SearchBox.SelectionStart = 0;
                SearchBox.SelectionLength = SearchBox.Text.Length;
            }
        }
        public Control getDesiredControl
        {
            get
            {
                return SearchBox;
            }
        }


        private void QueryControl_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SearchBox.Text))
            {
                SearchBox.SelectionStart = 0;
                SearchBox.SelectionLength = SearchBox.Text.Length;
            }
        }

        RegisterPage reg;
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (reg == null)
            {
                reg = new RegisterPage();
                reg.FormClosed += Reg_FormClosed;
                reg.LoadValues();
                reg.Show();
                return;
            }
            reg.BringToFront();
        }

        private void Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            reg = null;
        }
    }
}
