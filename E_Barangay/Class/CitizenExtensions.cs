using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Barangay.Class
{
    public static class CitizenExtensions
    {
        public static int getAGe(this Citizen c)
        {
            DateTime today = DateTime.Today;
            DateTime dob = c.Birthday;
            int months = today.Month - dob.Month;
            int years = today.Year - dob.Year;

            if (today.Day < dob.Day)
            {
                months--;
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            int days = (today - dob.AddMonths((years * 12) + months)).Days;
            return years;
        }
        public static string getNameWithSpace(this Citizen c)
        {
            return c.FirstName + " " + c.MiddleName + " " + c.LastName + (string.IsNullOrEmpty(c.Extension) ? "" : " " + c.Extension);
        }
        public static string getName(this Citizen c)
        {
            return c.FirstName + c.MiddleName + c.LastName + c.Extension;
        }
        public static NameHelper getNameSeparated(this Citizen c)
        {
            NameHelper helper = new NameHelper(c.getNameWithSpace());
            return helper;
        }
        public static bool CitizenFound(string fullName,out Citizen citizen)
        {
           
            string n = fullName.Replace(' ', '\0');
            using (var e = new EBarangayEntities())
            {
                citizen = e.Citizens.ToArray().FirstOrDefault(x => x.getName() == n);
            }
            return citizen != null;
        }
    }

}
