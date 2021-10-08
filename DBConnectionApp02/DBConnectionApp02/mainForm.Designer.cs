
namespace DBConnectionApp02
{
    partial class mainForm
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
            this.bottomTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.totalCountTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.pagingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.firstPageLabel = new System.Windows.Forms.Label();
            this.prevPageLabel = new System.Windows.Forms.Label();
            this.nextPageLabel = new System.Windows.Forms.Label();
            this.lastPageLabel = new System.Windows.Forms.Label();
            this.pagingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pageLabel = new System.Windows.Forms.Label();
            this.currentPageTextBox = new System.Windows.Forms.TextBox();
            this.totalPageCountLabel = new System.Windows.Forms.Label();
            this.totalDivision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.bottomTableLayoutPanel.SuspendLayout();
            this.totalCountTableLayoutPanel.SuspendLayout();
            this.pagingTableLayoutPanel.SuspendLayout();
            this.pagingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalDivision
            // 
            this.totalDivision.ColumnCount = 1;
            this.totalDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalDivision.Controls.Add(this.dataGridView, 0, 0);
            this.totalDivision.Controls.Add(this.bottomTableLayoutPanel, 0, 1);
            this.totalDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalDivision.Location = new System.Drawing.Point(0, 0);
            this.totalDivision.Margin = new System.Windows.Forms.Padding(0);
            this.totalDivision.Name = "totalDivision";
            this.totalDivision.RowCount = 2;
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.totalDivision.Size = new System.Drawing.Size(784, 461);
            this.totalDivision.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(784, 421);
            this.dataGridView.TabIndex = 0;
            // 
            // bottomTableLayoutPanel
            // 
            this.bottomTableLayoutPanel.ColumnCount = 3;
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bottomTableLayoutPanel.Controls.Add(this.totalCountTableLayoutPanel, 2, 0);
            this.bottomTableLayoutPanel.Controls.Add(this.pagingTableLayoutPanel, 1, 0);
            this.bottomTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTableLayoutPanel.Location = new System.Drawing.Point(0, 421);
            this.bottomTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomTableLayoutPanel.Name = "bottomTableLayoutPanel";
            this.bottomTableLayoutPanel.RowCount = 1;
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTableLayoutPanel.Size = new System.Drawing.Size(784, 40);
            this.bottomTableLayoutPanel.TabIndex = 1;
            // 
            // totalCountTableLayoutPanel
            // 
            this.totalCountTableLayoutPanel.ColumnCount = 2;
            this.totalCountTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.totalCountTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.totalCountTableLayoutPanel.Controls.Add(this.totalLabel, 0, 0);
            this.totalCountTableLayoutPanel.Controls.Add(this.totalTextBox, 1, 0);
            this.totalCountTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalCountTableLayoutPanel.Location = new System.Drawing.Point(588, 0);
            this.totalCountTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.totalCountTableLayoutPanel.Name = "totalCountTableLayoutPanel";
            this.totalCountTableLayoutPanel.RowCount = 1;
            this.totalCountTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalCountTableLayoutPanel.Size = new System.Drawing.Size(196, 40);
            this.totalCountTableLayoutPanel.TabIndex = 0;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalLabel.Location = new System.Drawing.Point(0, 0);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(78, 40);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "TOTAL";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalTextBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalTextBox.Location = new System.Drawing.Point(88, 6);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(10, 6, 30, 3);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(78, 27);
            this.totalTextBox.TabIndex = 1;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pagingTableLayoutPanel
            // 
            this.pagingTableLayoutPanel.ColumnCount = 5;
            this.pagingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pagingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pagingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.pagingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pagingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pagingTableLayoutPanel.Controls.Add(this.lastPageLabel, 4, 0);
            this.pagingTableLayoutPanel.Controls.Add(this.nextPageLabel, 3, 0);
            this.pagingTableLayoutPanel.Controls.Add(this.prevPageLabel, 1, 0);
            this.pagingTableLayoutPanel.Controls.Add(this.firstPageLabel, 0, 0);
            this.pagingTableLayoutPanel.Controls.Add(this.pagingPanel, 2, 0);
            this.pagingTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagingTableLayoutPanel.Location = new System.Drawing.Point(196, 0);
            this.pagingTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pagingTableLayoutPanel.Name = "pagingTableLayoutPanel";
            this.pagingTableLayoutPanel.RowCount = 1;
            this.pagingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagingTableLayoutPanel.Size = new System.Drawing.Size(392, 40);
            this.pagingTableLayoutPanel.TabIndex = 1;
            // 
            // firstPageLabel
            // 
            this.firstPageLabel.AutoSize = true;
            this.firstPageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstPageLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.firstPageLabel.Location = new System.Drawing.Point(0, 0);
            this.firstPageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.firstPageLabel.Name = "firstPageLabel";
            this.firstPageLabel.Size = new System.Drawing.Size(63, 40);
            this.firstPageLabel.TabIndex = 1;
            this.firstPageLabel.Text = "<<";
            this.firstPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstPageLabel.Click += new System.EventHandler(this.firstPageLabel_Click);
            // 
            // prevPageLabel
            // 
            this.prevPageLabel.AutoSize = true;
            this.prevPageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prevPageLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.prevPageLabel.Location = new System.Drawing.Point(63, 0);
            this.prevPageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.prevPageLabel.Name = "prevPageLabel";
            this.prevPageLabel.Size = new System.Drawing.Size(63, 40);
            this.prevPageLabel.TabIndex = 2;
            this.prevPageLabel.Text = "<";
            this.prevPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prevPageLabel.Click += new System.EventHandler(this.prevPageLabel_Click);
            // 
            // nextPageLabel
            // 
            this.nextPageLabel.AutoSize = true;
            this.nextPageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextPageLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nextPageLabel.Location = new System.Drawing.Point(266, 0);
            this.nextPageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nextPageLabel.Name = "nextPageLabel";
            this.nextPageLabel.Size = new System.Drawing.Size(63, 40);
            this.nextPageLabel.TabIndex = 3;
            this.nextPageLabel.Text = ">";
            this.nextPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextPageLabel.Click += new System.EventHandler(this.nextPageLabel_Click);
            // 
            // lastPageLabel
            // 
            this.lastPageLabel.AutoSize = true;
            this.lastPageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastPageLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lastPageLabel.Location = new System.Drawing.Point(329, 0);
            this.lastPageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastPageLabel.Name = "lastPageLabel";
            this.lastPageLabel.Size = new System.Drawing.Size(63, 40);
            this.lastPageLabel.TabIndex = 4;
            this.lastPageLabel.Text = ">>";
            this.lastPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastPageLabel.Click += new System.EventHandler(this.lastPageLabel_Click);
            // 
            // pagingPanel
            // 
            this.pagingPanel.ColumnCount = 3;
            this.pagingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pagingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pagingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.pagingPanel.Controls.Add(this.pageLabel, 0, 0);
            this.pagingPanel.Controls.Add(this.currentPageTextBox, 1, 0);
            this.pagingPanel.Controls.Add(this.totalPageCountLabel, 2, 0);
            this.pagingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagingPanel.Location = new System.Drawing.Point(126, 0);
            this.pagingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pagingPanel.Name = "pagingPanel";
            this.pagingPanel.RowCount = 1;
            this.pagingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagingPanel.Size = new System.Drawing.Size(140, 40);
            this.pagingPanel.TabIndex = 5;
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pageLabel.Location = new System.Drawing.Point(0, 0);
            this.pageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(56, 40);
            this.pageLabel.TabIndex = 0;
            this.pageLabel.Text = "Page";
            this.pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentPageTextBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.currentPageTextBox.Location = new System.Drawing.Point(56, 7);
            this.currentPageTextBox.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.currentPageTextBox.Name = "currentPageTextBox";
            this.currentPageTextBox.Size = new System.Drawing.Size(35, 27);
            this.currentPageTextBox.TabIndex = 1;
            this.currentPageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalPageCountLabel
            // 
            this.totalPageCountLabel.AutoSize = true;
            this.totalPageCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPageCountLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalPageCountLabel.Location = new System.Drawing.Point(91, 0);
            this.totalPageCountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalPageCountLabel.Name = "totalPageCountLabel";
            this.totalPageCountLabel.Size = new System.Drawing.Size(49, 40);
            this.totalPageCountLabel.TabIndex = 2;
            this.totalPageCountLabel.Text = "/1";
            this.totalPageCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.totalDivision);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.totalDivision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.bottomTableLayoutPanel.ResumeLayout(false);
            this.totalCountTableLayoutPanel.ResumeLayout(false);
            this.totalCountTableLayoutPanel.PerformLayout();
            this.pagingTableLayoutPanel.ResumeLayout(false);
            this.pagingTableLayoutPanel.PerformLayout();
            this.pagingPanel.ResumeLayout(false);
            this.pagingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel totalDivision;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel bottomTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel totalCountTableLayoutPanel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TableLayoutPanel pagingTableLayoutPanel;
        private System.Windows.Forms.Label lastPageLabel;
        private System.Windows.Forms.Label nextPageLabel;
        private System.Windows.Forms.Label prevPageLabel;
        private System.Windows.Forms.Label firstPageLabel;
        private System.Windows.Forms.TableLayoutPanel pagingPanel;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.TextBox currentPageTextBox;
        private System.Windows.Forms.Label totalPageCountLabel;
    }
}

