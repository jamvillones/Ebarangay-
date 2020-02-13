using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Barangay.Class
{
    class Area
    {
        public string Name;
        public int PopulationCount;
    }
    class Statistics
    {
       

        public int totalPopulation;

        public int male { get; private set; }


        public int female { get; private set; }


        public int student { get; private set; }

        public int pwd { get; private set; }
        public int senior { get; private set; }
        public int indigent { get; private set; }

        public int single { get; private set; }
        public int married { get; private set; }

        public List<Area> areas = new List<Area>();

        public float getPercentage(int num)
        {
            return ((float)num / (float)totalPopulation) * 100.0f;
        }
        public Statistics() { }

        public void Initialize()
        {
            
            using (var ent = new EBarangayEntities())
            {
                totalPopulation = ent.Citizens.Count();

                foreach(var t in ent.Areas)
                {
                    var area = new Area { Name = t.Name, PopulationCount = t.Citizens.Count };
                    areas.Add(area);
                }
            }
        }
    }
}

