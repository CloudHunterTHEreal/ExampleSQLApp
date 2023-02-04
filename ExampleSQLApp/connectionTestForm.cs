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
        DataBase  database = new DataBase();
        public connectionTestForm()
        {
            InitializeComponent();
        }

        private void connectForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "miit_localDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.miit_localDataSet.users);

        }

        private void users_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
