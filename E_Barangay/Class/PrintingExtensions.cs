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
        string end = dt.Value.ToString("MMMM ,yyyy");

        if (dt.Value.Day == 1)
            return "1st day of " + end;

        if (dt.Value.Day == 2)
            return "2nd day of " + end;

        if (dt.Value.Day == 3)
            return "3rd day of " + end;

        return dt.Value.Day + "th day of " + end;
    }

}

