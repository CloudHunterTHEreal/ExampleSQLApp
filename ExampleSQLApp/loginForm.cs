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

/*        public AppUserData userData = currentUserData;*/
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
            var username = this.fieldUserNameInput.Text;
            var user_pass = this.fieldPasswordInput.Text;

            SqlDataAdapter db_adapter = new SqlDataAdapter();
            DataTable task_data = new DataTable();

            string get_user_data_query = $"SELECT nickname, pass_hash FROM users WHERE nickname = '{username}' AND pass_hash = '{user_pass}'";

            SqlCommand get_data_command = new SqlCommand(get_user_data_query, database.getConnection());

            db_adapter.SelectCommand = get_data_command;
            db_adapter.Fill(task_data);

            if(task_data.Rows.Count == 1)
            {
                MessageBox.Show("ACCESS GRANTED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connectionTestForm task_data_Form = new connectionTestForm();
                this.Hide();
                task_data_Form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Имя или пароль пользователя неверны.", "Unknown user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (username == null || user_pass == null) {
                Console.WriteLine("No data");
            }
            else
            {
                Console.WriteLine("[+] Username is: <" + this.fieldUserNameInput.Text + ">.");
                Console.WriteLine("[+] Password is: <" + this.fieldPasswordInput.Text + ">.");
            }
            Close();
        }

        private void loginMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fieldUserNameInput_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
