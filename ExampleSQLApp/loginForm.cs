﻿using System;
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
            labelCloseLoginFormBottom.ForeColor = Color.Yellow;
            //            Console.WriteLine("[!] Mouse over <" + labelCloseLoginFormBottom.ForeColor.ToString() + ">.");
        }

        private void labelCloseLoginFormBottom_MouseLeave(object sender, EventArgs e)
        {
            labelCloseLoginFormBottom.ForeColor = Color.LightGray;
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
    }
}
