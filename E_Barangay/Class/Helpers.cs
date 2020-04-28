using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public static class Helper
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
        if (n.Value <= 1)
        {
            return n.Value + " year " + end;
        }

        return n.Value + " years " + end + (n.Value >= 18 ? "(of legal age)" : string.Empty);
    }
    /// <summary>
    /// callback for trimming excess spaces in textboxes after an edit is made
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public static void TextBoxTrimSpaces(object sender, EventArgs e)
    {
        TextBox t = (TextBox)sender;

        if (string.IsNullOrEmpty(t.Text))
            return;
        if (t.Multiline)
            return;
        t.Text = t.Text.Trim(' ');
    }
    /// <summary>
    /// adds desired controls from a control to a list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collections"></param>
    /// <param name="control"></param>
    public static void addControls<T>(this List<T> collections, Control control) where T : Control
    {

        foreach (var i in control.Controls)
        {
            if (i is T)
                collections.Add(i as T);
            else
                addControls<T>(collections, i as Control);
        }
    }
    /// <summary>
    /// collects specific controls
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="control"></param>
    /// <returns></returns>
    public static List<T> GetContainedControls<T>(this Control control) where T : Control
    {
        List<T> temp = new List<T>();
        foreach (var i in control.Controls)
        {
            if (i is T)
                temp.Add((T)i);

            else
                foreach (var j in GetContainedControls<T>(i as Control))
                    temp.Add(j);
        }
        return temp;
    }

    public static string MrMrs(this Control c)
    {
        if (c.Text == "")
            return "(BLANK)";

        return c.Text == "Male" ? "Mr." : "Mrs.";
    }
    public static string HisHer(this Control c, bool firstCap = false)
    {
        if (c.Text == "") return "(BLANK)";
        string t =  c.Text == "Male" ? "his" : "her";
        if (firstCap)
            t.Replace('h', 'H');
        return t;
    }
    public static string HimHer(this Control c, bool firstCap = false)
    {
        if (string.IsNullOrEmpty(c.Text)) return "(BLANK)";

        string t = c.Text == "Male" ? "him" : "her";

        if (firstCap)
            t.Replace('h', 'H');
        return t;
    }
    public static string HeShe(this Control c, bool firstCapitalize = false)
    {
        if (string.IsNullOrEmpty(c.Text)) return "(BLANK)";
        return c.Text == "Male" ? (firstCapitalize ? "He" : "he") : (firstCapitalize ? "She" : "she");
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

