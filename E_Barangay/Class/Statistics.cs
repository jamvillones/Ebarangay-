using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Barangay.Class
{
    class Statistics
    {
        Citizen[] citizen;

        public int totalPopulation;

        public int male { get; private set; }
        
        
        public int female { get; private set; }
       

        public int student { get; private set; }
       
        public int pwd { get; private set; }
        public int senior { get; private set; }
        public int indigent { get; private set; }

        public int single { get; private set; }
        public int married { get; private set; }

        public float getPercentage(int num)
        {
            return ((float)num / (float)totalPopulation)*100.0f;
        }
        public Statistics() { }

        public void Initialize(Citizen[] c)
        {
            citizen = c;
            totalPopulation = citizen.Length;
            foreach (var i in citizen)
            {
                ///male of female
                if (i.Gender == "Male")
                    male++;
                else
                    female++;

                ///indigent, pwd, student, senior
                if (i.Indigent) indigent++;
                if (i.Student) student++;
                if (i.PWD) pwd++;
                if (i.SeniorCitizen) senior++;

                ///single,married
                if (i.CivilStatus == "Single")
                    single++;
                else
                    married++;
            }
        }
    }
}
