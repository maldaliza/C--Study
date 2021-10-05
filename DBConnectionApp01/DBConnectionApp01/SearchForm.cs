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

        /*
         * 검색 버튼 클릭 이벤트
         */
        private void searchButton_Click(object sender, EventArgs e)
        {
            db.SearchDB(table, phoneNumberTextBox.Text, 0);
            
            Int64 count = db.SearchDataCount(phoneNumberTextBox.Text);    // 검색 버튼 클릭 시, 검색 Total 조회
            totalTextBox.Text = Convert.ToString(count);

            CreateDynamicButton(count);

            /*int TotalPage = (int)count / 10 + 1;

            Control[] pageButton = new Control[7];
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

            for (int i=0; i<TotalPage; i++)
            {
                pageButton[i] = new Button();
                pageButton[i].Name = "pageButton" + (i + 1).ToString();
                pageButton[i].Size = new Size(40, 40);
                pageButton[i].Text = (i + 1).ToString();
                pageButton[i].Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

                pageButton[i].Width = 40;
                pageButton[i].Height = 35;
                pageButton[i].Margin = new Padding(10, 3, 3, 3);

                pageButton[i].Click += new EventHandler(pageButton_Click);

                flowLayoutPanel.Controls.Add(pageButton[i]);
            }

            pagingPanel.Controls.Add(flowLayoutPanel);
            flowLayoutPanel.Dock = DockStyle.Fill;*/

            //phoneNumberTextBox.Text = "";
        }


        private void CreateDynamicButton(Int64 count)
        {
            int TotalPage = (int)count / 10 + 1;

            Control[] pageButton = new Control[7];
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

            for (int i = 0; i < TotalPage; i++)
            {
                pageButton[i] = new Button();
                pageButton[i].Name = "pageButton" + (i + 1).ToString();
                pageButton[i].Size = new Size(40, 40);
                pageButton[i].Text = (i + 1).ToString();
                pageButton[i].Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

                pageButton[i].Width = 40;
                pageButton[i].Height = 35;
                pageButton[i].Margin = new Padding(10, 3, 3, 3);

                pageButton[i].Click += new EventHandler(pageButton_Click);

                flowLayoutPanel.Controls.Add(pageButton[i]);
            }

            pagingPanel.Controls.Add(flowLayoutPanel);
            flowLayoutPanel.Dock = DockStyle.Fill;
        }

        private void pageButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int offset = (int.Parse(button.Text) - 1) * 10;

            db.SearchDB(table, phoneNumberTextBox.Text, offset);
        }
    }
}
