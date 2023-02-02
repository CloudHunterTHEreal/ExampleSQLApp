using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
/*    public static 
        class AppUserData
    {
        public string userRole = "Guest";

        public AppUserData(string arg_userRole)
        {
            userRole = arg_userRole;
        }
    }*/

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //          public static AppUserData currentUserData = new AppUserData();
            //          Console.WriteLine("[info] Current user's role is: <" + currentUserData.userRole + ">");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
        }
    }
}
