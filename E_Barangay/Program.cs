﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Forms;
using E_Barangay.Class;

namespace E_Barangay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserManager.instance = new UserManager();
            Application.Run(new Login());
       
            //Application.Run(new E_Barangay.Forms.MainPage());
           // Application.Run(new ());
        }
    }
}
