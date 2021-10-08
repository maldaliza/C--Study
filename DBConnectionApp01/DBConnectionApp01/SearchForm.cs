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

        int offset = 0;

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
            offset = 0;     // 오프셋 초기화
            string phoneNumber = phoneNumberTextBox.Text;
            db.SearchDB(table, phoneNumber, offset);
            
            Int64 totalCount = db.SearchDataCount(phoneNumber);    // 텍스트박스 값으로 DB에서 Total 조회
            totalTextBox.Text = Convert.ToString(totalCount);

            int totalPageCount = (int)Math.Ceiling((double)totalCount / 30); // 전체 페이지 갯수
            if (totalPageCount == 0)
            {
                totalPageCount = 1;
            }
            int currentPage = offset / 30 + 1;                               // 현재 페이지

            pageNumber.Text = "Page " + currentPage.ToString() + "/" + totalPageCount.ToString();
        }

        /*
         * 다음 페이지 이동 버튼
         */
        private void nextPageLabel_Click(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberTextBox.Text;
            Int64 totalCount = db.SearchDataCount(phoneNumber);

            // 전체 페이지 갯수
            int totalPageCount = (int)Math.Ceiling((double)totalCount / 30);

            if ((offset / 30) + 1 < totalPageCount)
            {
                offset += 30;
            }

            // 현재 페이지
            int currentPage = offset / 30 + 1;
            if (currentPage <= totalPageCount)
            {
                db.SearchDB(table, phoneNumber, offset);
            }

            pageNumber.Text = "Page " + currentPage.ToString() + "/" + totalPageCount.ToString();
        }

        /*
         * 마지막 페이지 이동 버튼
         */
        private void lastPageLabel_Click(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberTextBox.Text;
            Int64 totalCount = db.SearchDataCount(phoneNumber);

            // 전체 페이지 갯수
            int totalPageCount = (int)Math.Ceiling((double)totalCount / 30);

            // 현재 페이지
            int currentPage = totalPageCount;

            // 오프셋
            offset = (totalPageCount - 1) * 30;

            db.SearchDB(table, phoneNumber, offset);

            pageNumber.Text = "Page " + currentPage.ToString() + "/" + totalPageCount.ToString();
        }

        /*
         * 이전 페이지 이동 버튼
         */
        private void prevPageLabel_Click(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberTextBox.Text;
            Int64 totalCount = db.SearchDataCount(phoneNumber);

            // 전체 페이지 갯수
            int totalPageCount = (int)Math.Ceiling((double)totalCount / 30);

            if (offset > 0)
            {
                offset -= 30;
            }

            // 현재 페이지
            int currentPage = offset / 30 + 1;
            if (currentPage <= totalPageCount)
            {
                db.SearchDB(table, phoneNumber, offset);
            }

            pageNumber.Text = "Page " + currentPage.ToString() + "/" + totalPageCount.ToString();
        }

        /*
         * 처음 페이지 이동 버튼
         */
        private void firstPageLabel_Click(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberTextBox.Text;
            Int64 totalCount = db.SearchDataCount(phoneNumber);

            // 전체 페이지 갯수
            int totalPageCount = (int)Math.Ceiling((double)totalCount / 30);

            // 현재 페이지
            int currentPage = 1;

            // 오프셋
            offset = 0;

            db.SearchDB(table, phoneNumber, offset);

            pageNumber.Text = "Page " + currentPage.ToString() + "/" + totalPageCount.ToString();
        }
    }
}
