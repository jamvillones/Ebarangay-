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
        public static string getName(this Citizen c)
        {
            string name;
            name = c.Name.Replace(',', ' ');
            return name;
        }
    }
    
}
