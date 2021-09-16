
namespace PagingExercise01
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalDivision = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.inputDataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.etcTextBox = new System.Windows.Forms.TextBox();
            this.studentNoTextBox = new System.Windows.Forms.TextBox();
            this.etcLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.studentNoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.totalDivision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.inputDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalDivision
            // 
            this.totalDivision.ColumnCount = 1;
            this.totalDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalDivision.Controls.Add(this.dataGridView, 0, 1);
            this.totalDivision.Controls.Add(this.inputDataPanel, 0, 0);
            this.totalDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalDivision.Location = new System.Drawing.Point(0, 0);
            this.totalDivision.Margin = new System.Windows.Forms.Padding(0);
            this.totalDivision.Name = "totalDivision";
            this.totalDivision.RowCount = 2;
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.totalDivision.Size = new System.Drawing.Size(384, 561);
            this.totalDivision.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 168);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(384, 393);
            this.dataGridView.TabIndex = 0;
            // 
            // inputDataPanel
            // 
            this.inputDataPanel.ColumnCount = 2;
            this.inputDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.inputDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.inputDataPanel.Controls.Add(this.etcTextBox, 1, 3);
            this.inputDataPanel.Controls.Add(this.studentNoTextBox, 1, 1);
            this.inputDataPanel.Controls.Add(this.etcLabel, 0, 3);
            this.inputDataPanel.Controls.Add(this.departmentLabel, 0, 2);
            this.inputDataPanel.Controls.Add(this.studentNoLabel, 0, 1);
            this.inputDataPanel.Controls.Add(this.nameLabel, 0, 0);
            this.inputDataPanel.Controls.Add(this.nameTextBox, 1, 0);
            this.inputDataPanel.Controls.Add(this.addButton, 0, 4);
            this.inputDataPanel.Controls.Add(this.departmentComboBox, 1, 2);
            this.inputDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataPanel.Location = new System.Drawing.Point(0, 0);
            this.inputDataPanel.Margin = new System.Windows.Forms.Padding(0);
            this.inputDataPanel.Name = "inputDataPanel";
            this.inputDataPanel.RowCount = 5;
            this.inputDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputDataPanel.Size = new System.Drawing.Size(384, 168);
            this.inputDataPanel.TabIndex = 1;
            // 
            // etcTextBox
            // 
            this.etcTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etcTextBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.etcTextBox.Location = new System.Drawing.Point(79, 104);
            this.etcTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 20, 0);
            this.etcTextBox.Multiline = true;
            this.etcTextBox.Name = "etcTextBox";
            this.etcTextBox.Size = new System.Drawing.Size(285, 28);
            this.etcTextBox.TabIndex = 7;
            this.etcTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.etcTextBox_KeyUp);
            // 
            // studentNoTextBox
            // 
            this.studentNoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentNoTextBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.studentNoTextBox.Location = new System.Drawing.Point(79, 38);
            this.studentNoTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 20, 0);
            this.studentNoTextBox.Multiline = true;
            this.studentNoTextBox.Name = "studentNoTextBox";
            this.studentNoTextBox.Size = new System.Drawing.Size(285, 28);
            this.studentNoTextBox.TabIndex = 5;
            this.studentNoTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.studentNoTextBox_KeyUp);
            // 
            // etcLabel
            // 
            this.etcLabel.AutoSize = true;
            this.etcLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etcLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.etcLabel.Location = new System.Drawing.Point(0, 99);
            this.etcLabel.Margin = new System.Windows.Forms.Padding(0);
            this.etcLabel.Name = "etcLabel";
            this.etcLabel.Size = new System.Drawing.Size(76, 33);
            this.etcLabel.TabIndex = 3;
            this.etcLabel.Text = "기타 :";
            this.etcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.departmentLabel.Location = new System.Drawing.Point(0, 66);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(76, 33);
            this.departmentLabel.TabIndex = 2;
            this.departmentLabel.Text = "학과 :";
            this.departmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentNoLabel
            // 
            this.studentNoLabel.AutoSize = true;
            this.studentNoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentNoLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.studentNoLabel.Location = new System.Drawing.Point(0, 33);
            this.studentNoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.studentNoLabel.Name = "studentNoLabel";
            this.studentNoLabel.Size = new System.Drawing.Size(76, 33);
            this.studentNoLabel.TabIndex = 1;
            this.studentNoLabel.Text = "학번 :";
            this.studentNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 33);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "이름 :";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameTextBox.Location = new System.Drawing.Point(79, 5);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 20, 0);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(285, 28);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyUp);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addButton.Location = new System.Drawing.Point(3, 135);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(70, 30);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "추가";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentComboBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "선택 없음",
            "컴퓨터공학과",
            "경영학과",
            "기계공학과",
            "체육학과",
            "수학과",
            "영문학과",
            "법학과",
            "심리학과"});
            this.departmentComboBox.Location = new System.Drawing.Point(79, 71);
            this.departmentComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 20, 0);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(285, 28);
            this.departmentComboBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.totalDivision);
            this.Name = "Form1";
            this.Text = "Form1";
            this.totalDivision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.inputDataPanel.ResumeLayout(false);
            this.inputDataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel totalDivision;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel inputDataPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label studentNoLabel;
        private System.Windows.Forms.Label etcLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox etcTextBox;
        private System.Windows.Forms.TextBox studentNoTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox departmentComboBox;
    }
}

