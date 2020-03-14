using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Barangay.Class
{
    public class OfficerInfo
    {
        public OfficerInfo()
        {
            using (var ent = new EBarangayEntities())
            {
                var sb = ent.Officials.Where(x => x.Position == "Sangguniang Barangay Member");
                foreach (var s in sb)
                {
                    sbMemebers.Add(s.Name);
                }
                captName = ent.Officials.FirstOrDefault(x => x.ID == "Punong_Barangay").Name;
            }
        }
        public List<string> sbMemebers = new List<string>();
        public string captName { get; private set; }
        public void InitDropdowns(ComboBox c)
        {
            foreach (var x in sbMemebers)
            {
                c.Items.Add(x);
                c.AutoCompleteCustomSource.Add(x);
            }

        }
    }
}
