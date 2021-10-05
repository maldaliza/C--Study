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

        // DB에서 테이블 전체 total 조회
        Int64 count = db.CountDB();
        
        // 행의 개수를 이용하여 동적인 버튼(Button) 생성
        private void CreateDynamicButton()
        {
            int TotalPage = (int)count / 10 + 1;
            int offset = (int)count / 10;              // 0, 10, 20, ...

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
                pageButton[i].Height = 40;
                pageButton[i].Margin = new Padding(10, 3, 3, 3);

                pageButton[i].Click += new EventHandler(pageButton_Click);

                flowLayoutPanel.Controls.Add(pageButton[i]);
            }

            pagingPanel.Controls.Add(flowLayoutPanel);
            flowLayoutPanel.Dock = DockStyle.Fill;
        }

        /*
         * Form1 생성자
         */
        public Form1()
        {
            InitializeComponent();
            
            table.Columns.Add("번호", typeof(string));
            table.Columns.Add("이름", typeof(string));
            table.Columns.Add("전화번호", typeof(string));
            table.Columns.Add("주소", typeof(string));

            // 데이터베이스 정보 조회
            db.SelectDB(table, 0);
            dataGridView.DataSource = table;

            // 행의 개수
            totalTextBox.Text = Convert.ToString(count);

            // 행의 개수를 이용하여 동적인 버튼(Button) 생성
            CreateDynamicButton();

            // 마지막 행 포커싱
            //dataGridView.CurrentCell = dataGridView.Rows[dataGridView.RowCount - 1].Cells[0];
        }


        /*
         * 데이터 추가
         */
        private void insertButton_Click(object sender, EventArgs e)
        {
            int offset = 0;

            db.InsertDB(table, offset, nameTextBox.Text, phoneNumberTextBox.Text, addressTextBox.Text);

            // 텍스트박스 초기화
            nameTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            addressTextBox.Text = "";

            // 행의 개수
            Int64 newCount = db.CountDB();
            totalTextBox.Text = Convert.ToString(newCount);

            // 마지막 행 포커싱
            //dataGridView.CurrentCell = dataGridView.Rows[dataGridView.RowCount - 1].Cells[0];
        }


        /*
         * 페이징 버튼 클릭 이벤트
         */
        private void pageButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int offset = (int.Parse(button.Text) - 1) * 10;     // button.Text를 int형으로 형변환 후 offset 값 설정

            db.SelectDB(table, offset);
        }


        /*
         * 검색기능 창 활성화
         */
        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }
    }
}
