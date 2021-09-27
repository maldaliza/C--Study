﻿using System;
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

            // 데이터베이스 정보 조회
            db.SelectDB(table);

            dataGridView.DataSource = table;

            // 마지막 행 포커싱
            dataGridView.CurrentCell = dataGridView.Rows[dataGridView.RowCount - 1].Cells[0];
        }

        /*
         * 데이터 추가
         */
        private void insertButton_Click(object sender, EventArgs e)
        {
            db.InsertDB(table, nameTextBox.Text, phoneNumberTextBox.Text, addressTextBox.Text);

            // 마지막 행 포커싱
            dataGridView.CurrentCell = dataGridView.Rows[dataGridView.RowCount - 1].Cells[0];
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }
    }
}
