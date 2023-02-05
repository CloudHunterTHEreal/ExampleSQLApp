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
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MessageBox.Show("Нажмите <OK> для закрытия формы", "Макет стартовой страницы", MessageBoxButtons.OK);
            Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
