using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagingExercise01
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();

            // 폼 로드 시, nameTextBox에 포커스
            this.ActiveControl = nameTextBox;

            // 폼 로드 시, departmentComboBox "선택 없음" 포커스
            this.departmentComboBox.SelectedIndex = 0;

            table.Columns.Add("이름", typeof(string));
            table.Columns.Add("학번", typeof(string));
            table.Columns.Add("학과", typeof(string));
            table.Columns.Add("기타", typeof(string));

            table.Rows.Add("홍길동", "20210915", "경영학과", "");
            table.Rows.Add("이재국", "19940509", "컴퓨터공학과", "");
            table.Rows.Add("김김김", "15940401", "기계공학과", "");
            table.Rows.Add("박박박", "20130505", "영문학과", "");
            table.Rows.Add("정정정", "18640501", "체육학과", "");
            table.Rows.Add("홍길동", "20210915", "경영학과", "");
            table.Rows.Add("이재국", "19940509", "컴퓨터공학과", "");
            table.Rows.Add("김김김", "15940401", "기계공학과", "");
            table.Rows.Add("박박박", "20130505", "영문학과", "");
            table.Rows.Add("정정정", "18640501", "체육학과", "");
            table.Rows.Add("홍길동", "20210915", "경영학과", "");
            table.Rows.Add("이재국", "19940509", "컴퓨터공학과", "");
            table.Rows.Add("김김김", "15940401", "기계공학과", "");
            table.Rows.Add("박박박", "20130505", "영문학과", "");
            table.Rows.Add("정정정", "18640501", "체육학과", "");
            table.Rows.Add("홍길동", "20210915", "경영학과", "");
            table.Rows.Add("이재국", "19940509", "컴퓨터공학과", "");
            table.Rows.Add("김김김", "15940401", "기계공학과", "");
            table.Rows.Add("박박박", "20130505", "영문학과", "");
            table.Rows.Add("정정정", "18640501", "체육학과", "");

            dataGridView.DataSource = table;
        }
        
        private void addData(string name, string studentNo, string department, string etc)
        {
            // 이름, 학번, 학과는 무조건 입력 받아야 함.
            if (name == "" || studentNo == "" || department == "선택 없음")
            {
                MessageBox.Show("입력 오류!");
                nameTextBox.Text = "";
                studentNoTextBox.Text = "";
                departmentComboBox.SelectedIndex = 0;
                etcTextBox.Text = "";
                nameTextBox.Focus();
            } else
            {
                table.Rows.Add(name, studentNo, department, etc);
                dataGridView.DataSource = table;
                nameTextBox.Text = "";
                studentNoTextBox.Text = "";
                departmentComboBox.SelectedIndex = 0;
                etcTextBox.Text = "";

                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.RowCount - 2].Cells[0];   // 마지막으로 추가한 데이터 강제 포커싱
            }
        }
        
        /*
         * 추가 버튼 이벤트
         */
        private void addButton_Click(object sender, EventArgs e)
        {
            addData(nameTextBox.Text, studentNoTextBox.Text, departmentComboBox.Text, etcTextBox.Text);
        }

        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addData(nameTextBox.Text, studentNoTextBox.Text, departmentComboBox.Text, etcTextBox.Text);
            }
        }

        private void studentNoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addData(nameTextBox.Text, studentNoTextBox.Text, departmentComboBox.Text, etcTextBox.Text);
            }
        }

        private void etcTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addData(nameTextBox.Text, studentNoTextBox.Text, departmentComboBox.Text, etcTextBox.Text);
            }
        }

        
    }
}
