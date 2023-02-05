using Mysqlx.Notice;
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
using test_DB;
using static ExampleSQLApp.Program;

namespace ExampleSQLApp
{
    public partial class loginForm : Form
    {
        DataBase database = new DataBase();
        SqlDataAdapter db_adapter = new SqlDataAdapter();
        DataTable currentDataFetch = new DataTable();

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

        /*        private void loginForm_Load(object sender, EventArgs e)
                {
                    fieldPasswordInput.PasswordChar = '*';
                }*/

        private void labelLoginTopPanel_Click(object sender, EventArgs e)
        {

        }

        private void labelCloseLoginForm_Click(object sender, EventArgs e)
        {
            /*            Console.WriteLine("[info] Current user's role is: <" + currentUserData.userRole + ">");
            */
            Console.WriteLine("[!] Form <" + this.Text + "> closed by user.");
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

        private bool IsPasswordCorrect(string name, string pass)
        {
            string get_user_data_query = $"SELECT nickname, pass_hash, role_name FROM users WHERE nickname = '{name}' AND pass_hash = '{pass}'";
            SqlCommand get_data_command = new SqlCommand(get_user_data_query, database.getConnection());
            db_adapter.SelectCommand = get_data_command;
            db_adapter.Fill(currentDataFetch);
            string current_role = null;

            if (currentDataFetch.Rows.Count != 1)
            {
                Console.WriteLine("[!] Access request rejected for: <" + name + ">");
                Console.WriteLine("[!] With password: <" + pass + ">");
                Console.WriteLine("Fetch has " + currentDataFetch.Rows.Count.ToString() + " rows.");

                return false;
            }
            else
            {
                current_role = currentDataFetch.Rows[0].Field<string>("role_name");
                MessageBox.Show("Доступ открыт, не забудьте код для обработки события!", "Доступ предоставлен", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                Console.WriteLine("[>] Access granted to: <" + name + ">");
                Console.WriteLine("[>] With role: <" + current_role + ">");

                return true;
            }
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

            while (!IsPasswordCorrect(username, user_pass))
            {
                MessageBox.Show("Имя или пароль пользователя неверны.", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //this.fieldUserNameInput.Focus();
/*                fieldUserNameInput.Text = username;
                username = fieldUserNameInput.Text;
                user_pass = fieldPasswordInput.Text;*/
            }

            connectionTestForm task_data_Form = new connectionTestForm();
            this.Hide();
            task_data_Form.ShowDialog();
            this.Show();
            this.Close();
        }

        private void loginMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fieldUserNameInput_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
