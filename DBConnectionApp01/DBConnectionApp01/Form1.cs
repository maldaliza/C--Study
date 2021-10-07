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

        Int64 count = db.CountDB();     // 데이터 Total 조회
        int offset = 0;
        int sequence = 1;

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

            // 전체 데이터 Total
            totalTextBox.Text = Convert.ToString(count);

            // 행의 개수를 이용하여 동적인 버튼(Button) 생성
            CreateDynamicButton(count, sequence);
        }

        /*
         * 행의 개수를 이용하여 동적인 버튼(Button) 생성
         */
        private void CreateDynamicButton(Int64 count, int sequence)     // 파라미터 -> 행의 개수, 몇번째 페이지 묶음인지
        {
            // pagingPanel 초기화
            pagingPanel.Controls.Clear();

            int TotalPage = 0;      // 전체 페이지 수 ex) 1, 2, 3, ...
            if ((int)count % 10 == 0)
            {
                TotalPage = (int)count / 10;
            } 
            else
            {
                TotalPage = (int)count / 10 + 1;
            }

            Control[] pageButton = new Control[7];
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();


            //========== 페이징 처리 ==========//
            int pageGroup = 0;
            if (TotalPage > 0)
            {
                if (TotalPage % 5 != 0)
                {
                    pageGroup = (TotalPage / 5) + 1;
                }
                else if (TotalPage % 5 == 0)
                {
                    pageGroup = TotalPage / 5;
                }
            }

            int firstPage = ((sequence - 1) * 5) + 1;   // 1, 6, 11, 16, ...
            int lastPage = sequence * 5;                // 5, 10, 15, 20, ...
            if (lastPage > TotalPage)
            {
                lastPage = TotalPage;
            }

            // 
            // prevPageButton
            //
            if (sequence != 1)  // 첫번째 페이지 묶음이 아닌 경우
            {
                pageButton[0] = new Button();
                pageButton[0].Name = "prevPageButton";
                pageButton[0].Size = new Size(40, 40);
                pageButton[0].Text = "<";
                pageButton[0].Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                pageButton[0].Width = 40;
                pageButton[0].Height = 40;
                pageButton[0].Margin = new Padding(10, 3, 3, 3);

                // 이전 페이지 묶음 이동 버튼 클릭 이벤트
                pageButton[0].Click += new EventHandler(prevNextPageButton_Click);

                flowLayoutPanel.Controls.Add(pageButton[0]);
            }

            // 
            // pageButton
            //
            for (int i=firstPage; i<=lastPage; i++)
            {
                int index = i % 5;

                pageButton[index] = new Button();
                pageButton[index].Name = "pageButton" + Convert.ToString(i);
                pageButton[index].Size = new Size(40, 40);
                pageButton[index].Text = Convert.ToString(i);
                pageButton[index].Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                pageButton[index].Width = 40;
                pageButton[index].Height = 40;
                pageButton[index].Margin = new Padding(10, 3, 3, 3);

                // 해당 버튼 클릭 시, offset 값 변동
                pageButton[index].Click += new EventHandler(pageButton_Click);

                flowLayoutPanel.Controls.Add(pageButton[index]);
            }

            //
            // nextPageButton
            //
            if (TotalPage > 5 && sequence != pageGroup)
            {
                pageButton[6] = new Button();
                pageButton[6].Name = "nextPageButton";
                pageButton[6].Size = new Size(40, 40);
                pageButton[6].Text = ">";
                pageButton[6].Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                pageButton[6].Width = 40;
                pageButton[6].Height = 40;
                pageButton[6].Margin = new Padding(10, 3, 3, 3);

                // 다음 페이지 묶음 이동 버튼 클릭 이벤트
                pageButton[6].Click += new EventHandler(prevNextPageButton_Click);

                flowLayoutPanel.Controls.Add(pageButton[6]);
            }


            //=================================//

            pagingPanel.Controls.Add(flowLayoutPanel);
            flowLayoutPanel.Dock = DockStyle.Fill;
        }

        /*
         * 페이지 묶음 이동 버튼
         * -> 이전 페이지 이동, 다음 페이지 이동 분리 해놓으면 sequence 값 동기화가 안됨...
         * -> 그래서 두 메소드를 합침.
         */
        private void prevNextPageButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == ">")
            {
                offset = sequence * 50;
                sequence++;
            }
            else if (button.Text == "<")
            {
                offset = ((sequence - 1) * 50) - 10;
                sequence--;
            }

            db.SelectDB(table, offset);

            CreateDynamicButton(count, sequence);
        }

        /*
         * 페이징 버튼 클릭 이벤트
         */
        private void pageButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            offset = (int.Parse(button.Text) - 1) * 10;     // button.Text를 int형으로 형변환 후 offset 값 설정

            db.SelectDB(table, offset);
        }


        /*
         * 데이터 추가
         */
        private void insertButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" || phoneNumberTextBox.Text != "" || addressTextBox.Text != "")
            {
                db.InsertDB(table, offset, nameTextBox.Text, phoneNumberTextBox.Text, addressTextBox.Text);
            }

            // 텍스트박스 초기화
            nameTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            addressTextBox.Text = "";

            // 행의 개수
            count = db.CountDB();
            totalTextBox.Text = Convert.ToString(count);

            CreateDynamicButton(count, sequence);
        }


        /*
         * 검색기능 창 활성화
         */
        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }


        /*
         * dataGridView에서 셀 선택
         */
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

            nameTextBox.Text = selectedRow.Cells[1].Value.ToString();
            phoneNumberTextBox.Text = selectedRow.Cells[2].Value.ToString();
            addressTextBox.Text = selectedRow.Cells[3].Value.ToString();

            updateButton.Click += new System.EventHandler(updateButton_Click);
            deleteButton.Click += new System.EventHandler(deleteButton_Click);
        }


        /*
         * 데이터 수정
         */
        private void updateButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            int id = int.Parse(selectedRow.Cells[0].Value.ToString());

            if (nameTextBox.Text != "" || phoneNumberTextBox.Text != "" || addressTextBox.Text != "")
            {
                db.UpdateDB(id, nameTextBox.Text, phoneNumberTextBox.Text, addressTextBox.Text);
            }
            db.SelectDB(table, 0);

            nameTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            addressTextBox.Text = "";
        }


        /*
         * 데이터 삭제
         */
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            int id = int.Parse(selectedRow.Cells[0].Value.ToString());

            if (nameTextBox.Text != "" || phoneNumberTextBox.Text != "" || addressTextBox.Text != "")
            {
                db.DeleteDB(id);
                db.SelectDB(table, 0);
            }

            nameTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            addressTextBox.Text = "";

            count = db.CountDB();
            totalTextBox.Text = Convert.ToString(count);

            CreateDynamicButton(count, 1);
        }
    }
}
