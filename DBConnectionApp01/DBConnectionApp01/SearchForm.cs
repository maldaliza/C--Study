using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnectionApp01
{
    public partial class SearchForm : Form
    {
        private static ConnectDB db = new ConnectDB();

        DataTable table = new DataTable();

        public SearchForm()
        {
            InitializeComponent();

            table.Columns.Add("번호", typeof(string));
            table.Columns.Add("이름", typeof(string));
            table.Columns.Add("전화번호", typeof(string));
            table.Columns.Add("주소", typeof(string));

            dataGridView.DataSource = table;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            db.SearchDB(table, phoneNumberTextBox.Text);

            phoneNumberTextBox.Text = "";
        }
    }
}
