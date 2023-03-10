using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static public DialogResult IsExitAccept()
        {
            DialogResult requestResult = MessageBox.Show("        Выйти?",
                                                         "Завершение работы",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
            return requestResult;
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
            /*            Application.Run(new mainForm());*/
        }
    }
}
