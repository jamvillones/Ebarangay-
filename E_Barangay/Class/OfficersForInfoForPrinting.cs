using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Barangay.Class
{
    public class OfficersForInfoForPrinting
    {
        public OfficersForInfoForPrinting()
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
    }
}
