﻿using System;
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
   
}

