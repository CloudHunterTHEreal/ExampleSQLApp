using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void labelLoginTopPanel_Click(object sender, EventArgs e)
        {

        }

        private void labelCloseLoginForm_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[!] Form <" + this.Text + "> closed by user.");
            this.Close();
        }

        private void labelCloseLoginForm_MouseHover(object sender, EventArgs e)
        {
            labelCloseLoginFormBottom.ForeColor = Color.Yellow;
            //            Console.WriteLine("[!] Mouse over <" + labelCloseLoginFormBottom.ForeColor.ToString() + ">.");
        }

        private void labelCloseLoginFormBottom_MouseLeave(object sender, EventArgs e)
        {
            labelCloseLoginFormBottom.ForeColor = Color.LightGray;
            //            Console.WriteLine("[!] Mouse over <" + labelCloseLoginFormBottom.ForeColor.ToString() + ">.");

        }
    }
}
