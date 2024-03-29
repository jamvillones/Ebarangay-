﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Barangay.Class
{
    public class Date
    {
        public int years { get; set; }
        public int months { get; set; }
        public int days { get; set; }

    }
    public static class DateTimeExtension
    {
        public static string ToAgeString(this DateTime dob, ref Date date)
        {
            DateTime today = DateTime.Today;

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

            date.years = years;
            date.months = months;
            date.days = days;

            return string.Format("{0} year{1}, {2} month{3} and {4} day{5}",
                                 years, (years == 1) ? "" : "s",
                                 months, (months == 1) ? "" : "s",
                                 days, (days == 1) ? "" : "s");
        }
        public static Date ToAge(this DateTime dob)
        {
            DateTime today = DateTime.Today;
            Date date = new Date();
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

            date.years = years;
            date.months = months;
            date.days = days;
            return date;
        }
    }
}
