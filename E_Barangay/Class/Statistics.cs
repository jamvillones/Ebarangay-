using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Barangay.Class
{
    class Area
    {
        public string Name { get; set; }
        public int PopulationCount { get; set; }

        public double GetPercentage(int totalPop)
        {
            var f = (float)PopulationCount / (float)totalPop * 100;
            return Math.Round(f, 2);
        }
    }
    class CivilStatus
    {
        public string Name { get; set; }
        public int Count { get; set; }
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

        //public int single { get; private set; }
        //public int married { get; private set; }

        public List<Area> areas = new List<Area>();
        public List<CivilStatus> cstatuses = new List<CivilStatus>();

        static public float getPercentage(int num, int tP)
        {
            return (num / tP) * 100;

        }
        public Statistics() { }

        public void Initialize()
        {

            using (var ent = new EBarangayEntities())
            {
                totalPopulation = ent.Citizens.Count();
                #region types
                var stnt = from c in ent.Citizens
                           where c.Student
                           select c;
                student = stnt.Count();

                var p = from c in ent.Citizens
                        where c.PWD
                        select c;
                pwd = p.Count();

                var ind = from c in ent.Citizens where c.Indigent select c;
                indigent = ind.Count();

                var sen = from c in ent.Citizens where c.SeniorCitizen select c;
                senior = sen.Count();
                #endregion
                foreach (var t in ent.Areas)
                {
                    var area = new Area { Name = t.Name, PopulationCount = t.Citizens.Count };
                    areas.Add(area);
                }
                var males = from c in ent.Citizens
                             where c.Gender == "Male"
                             select c;
                male = males.Count();
                female = totalPopulation - males.Count();

                var civilStatGroup = from g in ent.Citizens
                                     group g by g.CivilStatus;
                foreach (var g in civilStatGroup)
                {
                    var status = new CivilStatus { Name = g.Key, Count = g.Count() };
                    cstatuses.Add(status);

                }
                foreach (var c in cstatuses)
                    Console.WriteLine(c.Name + c.Count);

            }
        }
    }
}

