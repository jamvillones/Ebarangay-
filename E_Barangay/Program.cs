using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Forms;
using E_Barangay.Class;
using E_Barangay.Documents;

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

            #region main application
            UserManager.instance = new UserManager();
            Login login = new Login();
            Application.Run(login);

            if (login.UserSuccessfullyAuthenticated)
                Application.Run(new MainPage());
            #endregion

            //Application.Run(new EditOfficials());
        }
    }
}
