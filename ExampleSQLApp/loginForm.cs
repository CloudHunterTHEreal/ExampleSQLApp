﻿using Mysqlx.Notice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using test_DB;
using static ExampleSQLApp.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ExampleSQLApp
{
    public partial class loginForm : Form
    {
        internal DataBase database = new DataBase();
        internal SqlDataAdapter db_adapter = new SqlDataAdapter();
        internal DataTable currentDataFetch = new DataTable();

        public loginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            // Set same height for both icons and input fields.
            int LOGIN_FIELDS_HEIGHT = this.iconUserName.Height;
            this.fieldUserNameInput.Size = new Size(this.fieldPasswordInput.Size.Width,
                LOGIN_FIELDS_HEIGHT);
            this.fieldPasswordInput.Size = new Size(this.fieldPasswordInput.Size.Width,
                LOGIN_FIELDS_HEIGHT);
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
            labelCloseLoginFormBottom.ForeColor = Color.Red;
        }

        private void labelCloseLoginFormBottom_MouseLeave(object sender, EventArgs e)
        {
            labelCloseLoginFormBottom.ForeColor = Color.FromArgb(193, 191, 198);
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

        }

        private bool IsPasswordCorrect(string name, string pass)
        {
            string current_role = null;

            string get_user_data_query = $"SELECT nickname, pass_hash, role_name FROM users WHERE nickname = '{name}' AND pass_hash = '{pass}'";
            SqlCommand get_data_command = new SqlCommand(get_user_data_query, database.getConnection());

            database.OpenConnection();

            db_adapter.SelectCommand = get_data_command;
            db_adapter.Fill(currentDataFetch);

            if (currentDataFetch.Rows.Count == 1)
            {
                current_role = currentDataFetch.Rows[0].Field<string>("role_name");
                Console.WriteLine("[>] Access granted to: <" + name + "> as <" + current_role + ">");

                MessageBox.Show("Доступ открыт, не забудьте код для обработки события!", "Доступ предоставлен",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("[!] Access request rejected for: <" + name + ">, password: <" + pass + ">");
/*                Console.WriteLine("Fetch has " + currentDataFetch.Rows.Count.ToString() + " rows.");*/
            }

            database.CloseConnection();

            if (current_role is null)
            {
                return false;
            }
            return true;
        }

 /*       private void openMainForm()
        {
            task_data_Form.ShowDialog();
        }
 */
        //
        // - - - - - - - - - -  L O G I N   K E Y - - - - - - - 
        //

        private void loginDataEnter_Click(object sender, EventArgs e)
        {
            var username = fieldUserNameInput.Text;
            var user_pass = fieldPasswordInput.Text;

            if (!IsPasswordCorrect(username, user_pass))
            {
                MessageBox.Show("Имя или пароль пользователя неверны.", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.fieldUserNameInput.Text = username;
                this.fieldPasswordInput.Text = user_pass;
                this.fieldUserNameInput.Focus();

                return;
            }

            this.Hide();
            connectionTestForm task_data_Form = new connectionTestForm();
            task_data_Form.ShowDialog();
            this.Show();
            this.Close();
        }

        private void loginMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginDataDrop_Click(object sender, EventArgs e)
        {
            this.fieldUserNameInput.Text = "";
            this.fieldPasswordInput.Text = "";
            this.fieldUserNameInput.Focus();
        }

        private void loginNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
/*            newUserForm newUserForm = new newUserForm();
            newUserForm.ShowDialog();*/
            this.Show();
        }

        private void fieldUserNameInput_KeyUp(object sender, KeyEventArgs e)
        {
            Control ctl;
            ctl = (Control)sender;
            /*MessageBox.Show($"{ctl.Name.ToString()}");*/            

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    MessageBox.Show($"name fiel key pressed");
                    ActiveControl = GetNextControl(ctl, true);
                    MessageBox.Show($"{ActiveControl.Name.ToString()}");
                    /*                    ActiveControl.;*/
                    /*                    ActiveControl;*/
                    /*                    fieldPasswordInput.Focus();*/
                    break;

                case Keys.Escape:
                    if (fieldUserNameInput.Text.Length == 0)
                    {
                        if (IsExitAccept() == DialogResult.Yes)
                            this.Close();
                        else
                            break;
                    }
                    else
                        fieldUserNameInput.Text = "";
                    break;

                /*                    SelectNextControl(ActiveControl, true, false, false, true);
                                    break;*/

                default:
                    break;
            }        
        }

        private void fieldPasswordInput_KeyUp(object sender, KeyEventArgs e)
        {
/*            loginDataEnter.Focus();*/
        }

        private void fieldUserNameInput_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Потеря фокуса ИМЯ");
        }

        private void fieldPasswordInput_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Получение фокуса ПАРОЛЬ");
        }
    }
}
