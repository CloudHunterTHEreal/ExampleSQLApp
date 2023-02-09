using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_DB;

namespace ExampleSQLApp
{
    public partial class connectionTestForm : Form
    {
        public connectionTestForm()
        {
            InitializeComponent();
        }

        private void connectForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "miit_local_User_Auth_n_Role_Data.roles". При необходимости она может быть перемещена или удалена.
            rolesTableAdapter.Fill(miit_local_User_Auth_n_Role_Data.roles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "miit_localDataSet.users". При необходимости она может быть перемещена или удалена.
            usersTableAdapter.Fill(miit_localDataSet.users);
            var fake_list = new List<string> 
            { "1 - Один", "2 - Два", "3 - Три", "4 - Четыре", "5 - Пять", "6 - Шесть", "7 - Семь" };

/*            var new_list = fake_list.Select(x => x.Where(x.EndsWith())Contains("П"));*/
            /*var new_list = fake_list.OrderBy(x => x.Count());*/
            var new_list = miit_local_User_Auth_n_Role_Data.roles.OrderBy(x => x.role_name.ToString());

            foreach (var item in new_list)
            {
                listBox.Items.Add(item);
            }
        }

/*        private object IListSource(List<string> fake_list)
        {
            throw new NotImplementedException();
        }*/

        private void users_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
