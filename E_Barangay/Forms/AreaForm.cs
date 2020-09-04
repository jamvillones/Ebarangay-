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
    public partial class AreaForm : Form
    {
        public AreaForm()
        {
            InitializeComponent();
        }

        private void AreaForm_Load(object sender, EventArgs e)
        {
            using (var p = new EBarangayEntities())
            {
                foreach (var i in p.Areas)
                    areaTable.Rows.Add(i.ID, i.Name, "Remove");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (areaName.Text == string.Empty)
                return;
            var an = areaName.Text.Trim(' ');
            using (var p = new EBarangayEntities())
            {
                if (p.Areas.Any(x => x.Name == an))
                {
                    MessageBox.Show("Already registered");
                    return;
                }
                var a = new Area();
                a.Name = an;
                p.Areas.Add(a);
                p.SaveChanges();
                areaTable.Rows.Add(a.ID, a.Name, "Remove");
            }
            MessageBox.Show("Area added.");

        }

        private void areaTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2)
            {
                return;
            }

            if (MessageBox.Show("Are you sure you want to remove item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            var id = (int)(areaTable.Rows[e.RowIndex].Cells[0].Value);
            using (var p = new EBarangayEntities())
            {
                var a = p.Areas.FirstOrDefault(x => x.ID == id);
                p.Areas.Remove(a);
                p.SaveChanges();
            }
            areaTable.Rows.RemoveAt(e.RowIndex);
        }
        int targetId;
        private void areaTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            targetId = (int)(areaTable.Rows[e.RowIndex].Cells[0].Value);
        }

        private void areaTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using (var p = new EBarangayEntities())
            {
                var t = p.Areas.FirstOrDefault(x => x.ID == targetId);
                t.Name = areaTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                p.SaveChanges();
            }
        }
    }
}
