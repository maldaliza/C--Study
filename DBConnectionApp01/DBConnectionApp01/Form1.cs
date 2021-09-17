using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;

namespace DBConnectionApp01
{
    public partial class Form1 : Form
    {
        private static ConnectDB db = new ConnectDB();
        
        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
            
            table.Columns.Add("번호", typeof(string));
            table.Columns.Add("이름", typeof(string));
            table.Columns.Add("전화번호", typeof(string));
            table.Columns.Add("주소", typeof(string));

            db.ConnDB(table);

            dataGridView.DataSource = table;
        }
    }
}
