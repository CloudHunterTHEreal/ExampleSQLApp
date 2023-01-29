using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExampleSQLApp.Program;

namespace ExampleSQLApp
{
    public partial class loginForm : Form
    {
/*        public AppUserData userData = currentUserData;*/
        public loginForm()
        {
            InitializeComponent();
            this.fieldPasswordInput.Size = new Size(this.fieldPasswordInput.Size.Width, 
                this.fieldUserNameInput.Width);
        }

        private void labelLoginTopPanel_Click(object sender, EventArgs e)
        {

        }

        private void labelCloseLoginForm_Click(object sender, EventArgs e)
        {
/*            Console.WriteLine("[info] Current user's role is: <" + currentUserData.userRole + ">");
*/            Console.WriteLine("[!] Form <" + this.Text + "> closed by user.");
            this.Close();
        }

        private void labelCloseLoginForm_MouseHover(object sender, EventArgs e)
        {
            labelCloseLoginFormBottom.ForeColor = Color.Red;
            //            Console.WriteLine("[!] Mouse over <" + labelCloseLoginFormBottom.ForeColor.ToString() + ">.");
        }

        private void labelCloseLoginFormBottom_MouseLeave(object sender, EventArgs e)
        {
            labelCloseLoginFormBottom.ForeColor = Color.FromArgb(193, 191, 198);
            //            Console.WriteLine("[!] Mouse over <" + labelCloseLoginFormBottom.ForeColor.ToString() + ">.");

        }

        Point startPressedLeftButtonPoint;
        private void loginMainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            startPressedLeftButtonPoint = new Point(e.X, e.Y);
        }

        private void loginMainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - startPressedLeftButtonPoint.X;
                this.Top += e.Y - startPressedLeftButtonPoint.Y;
            }
        }

        private void fieldUserNameInput_TextChanged(object sender, EventArgs e)
        {
            this.fieldUserNameInput.ForeColor = Color.Red;
        }

        private void loginDataEnter_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[+] Username is: <" + this.fieldUserNameInput.Text + ">.");
            Console.WriteLine("[+] Password is: <" + this.fieldPasswordInput.Text + ">.");
            Close();
        }
    }
}
