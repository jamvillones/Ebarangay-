using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public static class PrintingExtensions
{
    public static string MrMs(this Control c)
    {
        if (c.Text == "")
            return "(BLANK)";

        return c.Text == "Male" ? "Mr." : "Ms.";
    }
    public static string PrintAge(this NumericUpDown n)
    {

        string end = "of age";
        if(n.Value <= 1)
        {
            return n.Value + " year "+end;
        }

        return n.Value+" years "+end+(n.Value >= 18?"(of legal age)":string.Empty);
    }
    //public static string AddLegalif(this Control c)
    //{
    //    ///fail safe
    //    if (string.IsNullOrEmpty(c.Text))
    //        return string.Empty;

    //    int age = Convert.ToInt32(c.Text);
    //    if (age >= 18)
    //        return "(of legal age)";
    //    return string.Empty;
    //}
    public static string MrMrs(this Control c)
    {
        if (c.Text == "")
            return "(BLANK)";

        return c.Text == "Male" ? "Mr." : "Mrs.";
    }
    public static string HisHer(this Control c)
    {
        if (c.Text == "") return "(BLANK)";
        return c.Text == "Male" ? "his" : "her";
    }
    public static string HimHer(this Control c)
    {
        if (string.IsNullOrEmpty(c.Text)) return "(BLANK)";
        return c.Text == "Male" ? "him" : "her";
    }
    public static string HeShe(this Control c)
    {
        if (string.IsNullOrEmpty(c.Text)) return "(BLANK)";
        return c.Text == "Male" ? "he" : "she";
    }
    public static string GetYears(this NumericUpDown n)
    {
        return n.Value > 1 ? n.Value + " years" : "a year";
    }
    public static string customFormat(this DateTimePicker dt)
    {
        string end = dt.Value.ToString("MMMM, yyyy");

        if (dt.Value.Day == 1)
            return "1st day of " + end;
        if (dt.Value.Day == 2)
            return "2nd day of " + end;
        if (dt.Value.Day == 3)
            return "3rd day of " + end;
        if (dt.Value.Day == 21)
            return "21st day of " + end;
        if (dt.Value.Day == 22)
            return "22nd day of " + end;
        if (dt.Value.Day == 23)
            return "23rd day of " + end;
        if (dt.Value.Day == 31)
            return "31st day of " + end;

        return dt.Value.Day + "th day of " + end;
    }

}

