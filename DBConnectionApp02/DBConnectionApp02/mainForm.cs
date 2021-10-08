using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnectionApp02
{
    public partial class mainForm : Form
    {
        private static DBConnection db = new DBConnection();

        DataTable table = new DataTable();

        int offset = 0;

        public mainForm()
        {
            InitializeComponent();

            table.Columns.Add("번호", typeof(string));
            table.Columns.Add("이름", typeof(string));
            table.Columns.Add("전화번호", typeof(string));
            table.Columns.Add("주소", typeof(string));

            // 최초 DB 정보 조회
            mainFormDB_Load();

            // 원하는 페이지로 이동하기 위한 키 이벤트
            currentPageTextBox.KeyDown += currentPageTextBox_KeyDown;

            dataGridView.DataSource = table;
        }

        /// <summary>
        /// currentPageTextBox에서 키를 누를 때 이벤트 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currentPageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // 엔터키 이벤트 발생
            if (e.KeyCode == Keys.Enter)
            {
                movePage(sender, e);
            }
        }

        /// <summary>
        /// currentPageTextBox에서 엔터키를 누르는 경우
        /// 원하는 페이지로 이동하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movePage(object sender, KeyEventArgs e)
        {
            string page = currentPageTextBox.Text;

            // 전체 페이지 수
            int totalPageCount = (int)Math.Ceiling(double.Parse(totalTextBox.Text) / 30);

            // 현재 페이지
            int currentPage = int.Parse(page);

            // 오프셋
            offset = (currentPage - 1) * 30;

            if (currentPage > totalPageCount || currentPage < 1)
            {
                MessageBox.Show("잘못된 페이지를 입력하였습니다.");
                
                offset = 0;
                db.SelectData(table, offset);
                currentPageTextBox.Text = "1";
            }
            else
            {
                db.SelectData(table, offset);
            }
        }

        /// <summary>
        /// 생성자 호출 시, 최초의 DB 정보 조회
        /// </summary>
        private void mainFormDB_Load()
        {
            // 데이터베이스 정보 Total 조회
            Int64 totalCount = db.CountTotal();
            int count = (int)totalCount;
            totalTextBox.Text = Convert.ToString(count);

            // 전체 페이지 수
            int totalPageCount = (int)Math.Ceiling((double)totalCount / 30);

            // 현재 페이지
            int currentPage = 1;

            currentPageTextBox.Text = Convert.ToString(currentPage);
            totalPageCountLabel.Text = "/" + Convert.ToString(totalPageCount);

            // 데이터베이스 정보 조회
            db.SelectData(table, offset);
        }

        /// <summary>
        /// 다음 페이지 이동 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextPageLabel_Click(object sender, EventArgs e)
        {
            // 전체 페이지 수
            int totalPageCount = (int)Math.Ceiling(double.Parse(totalTextBox.Text) / 30);

            if ((offset / 30) + 1 < totalPageCount)
            {
                offset += 30;
            }

            // 현재 페이지
            int currentPage = offset / 30 + 1;

            currentPageTextBox.Text = Convert.ToString(currentPage);
            totalPageCountLabel.Text = "/" + Convert.ToString(totalPageCount);
            
            // 데이터베이스 정보 조회
            if (currentPage <= totalPageCount)
            {
                db.SelectData(table, offset);
            }
        }

        /// <summary>
        /// 마지막 페이지 이동 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastPageLabel_Click(object sender, EventArgs e)
        {
            // 전체 페이지 수
            int totalPageCount = (int)Math.Ceiling(double.Parse(totalTextBox.Text) / 30);

            // 현재 페이지
            int currentPage = totalPageCount;

            // 오프셋
            offset = (totalPageCount - 1) * 30;

            currentPageTextBox.Text = Convert.ToString(currentPage);
            totalPageCountLabel.Text = "/" + Convert.ToString(totalPageCount);

            db.SelectData(table, offset);
        }

        /// <summary>
        /// 이전 페이지 이동 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prevPageLabel_Click(object sender, EventArgs e)
        {
            // 전체 페이지 수
            int totalPageCount = (int)Math.Ceiling(double.Parse(totalTextBox.Text) / 30);

            if (offset > 0)
            {
                offset -= 30;
            }

            // 현재 페이지
            int currentPage = offset / 30 + 1;

            currentPageTextBox.Text = Convert.ToString(currentPage);
            totalPageCountLabel.Text = "/" + Convert.ToString(totalPageCount);

            if (currentPage <= totalPageCount)
            {
                db.SelectData(table, offset);
            }
        }

        /// <summary>
        /// 처음 페이지 이동 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstPageLabel_Click(object sender, EventArgs e)
        {
            // 전체 페이지 수
            int totalPageCount = (int)Math.Ceiling(double.Parse(totalTextBox.Text) / 30);

            // 현재 페이지
            int currentPage = 1;

            // 오프셋
            offset = 0;

            currentPageTextBox.Text = Convert.ToString(currentPage);
            totalPageCountLabel.Text = "/" + Convert.ToString(totalPageCount);

            db.SelectData(table, offset);
        }
    }
}
