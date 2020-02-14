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
        public int votersCount { get; private set; }

        public int student { get; private set; }
        public int pwd { get; private set; }
        public int senior { get; private set; }
        public int indigent { get; private set; }

        //public int single { get; private set; }
        //public int married { get; private set; }

        public List<Area> areas = new List<Area>();
        public List<CivilStatus> cstatuses = new List<CivilStatus>();

        static public double getPercentage(int num, int tP)
        {
            var f = (float)num / (float)tP * 100f;
            return Math.Round(f, 2);

        }
        public Statistics() { }
        public int notVotersCount
        {
            get
            {
                return totalPopulation - votersCount;
            }
        }
        public void Initialize()
        {

            using (var ent = new EBarangayEntities())
            {
                totalPopulation = ent.Citizens.Count();

                #region types
                student = ent.Citizens.Where(x => x.Student).Count();
                pwd = ent.Citizens.Where(x => x.PWD).Count();
                indigent = ent.Citizens.Where(x => x.Indigent).Count();
                senior = ent.Citizens.Where(x => x.SeniorCitizen).Count();
                #endregion
                #region areas
                foreach (var t in ent.Areas)
                {
                    var area = new Area { Name = t.Name, PopulationCount = t.Citizens.Count };
                    areas.Add(area);
                }
                #endregion
                #region genders
                male = ent.Citizens.Where(x => x.Gender == "Male").Count();
                female = totalPopulation - male;
                #endregion
                #region civilStats
                var civilStatGroup = from g in ent.Citizens
                                     group g by g.CivilStatus;
                foreach (var g in civilStatGroup)
                {
                    var status = new CivilStatus { Name = g.Key, Count = g.Count() };
                    cstatuses.Add(status);

                }
                #endregion

                votersCount = ent.Citizens.Where(x => !string.IsNullOrEmpty(x.VoterID)).Count();


            }
        }
    }
}

