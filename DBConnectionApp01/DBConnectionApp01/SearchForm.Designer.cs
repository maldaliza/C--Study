
namespace DBConnectionApp01
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalDivision = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inputDataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bottomPanel = new System.Windows.Forms.TableLayoutPanel();
            this.totalPanel = new System.Windows.Forms.TableLayoutPanel();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.pagingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lastPageLabel = new System.Windows.Forms.Label();
            this.nextPageLabel = new System.Windows.Forms.Label();
            this.prevPageLabel = new System.Windows.Forms.Label();
            this.firstPageLabel = new System.Windows.Forms.Label();
            this.pageNumber = new System.Windows.Forms.Label();
            this.totalDivision.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.inputDataPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.totalPanel.SuspendLayout();
            this.pagingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalDivision
            // 
            this.totalDivision.ColumnCount = 1;
            this.totalDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.totalDivision.Controls.Add(this.topPanel, 0, 0);
            this.totalDivision.Controls.Add(this.dataGridView, 0, 1);
            this.totalDivision.Controls.Add(this.bottomPanel, 0, 2);
            this.totalDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalDivision.Location = new System.Drawing.Point(0, 0);
            this.totalDivision.Margin = new System.Windows.Forms.Padding(0);
            this.totalDivision.Name = "totalDivision";
            this.totalDivision.RowCount = 3;
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.totalDivision.Size = new System.Drawing.Size(484, 461);
            this.totalDivision.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.ColumnCount = 1;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topPanel.Controls.Add(this.inputDataPanel, 0, 0);
            this.topPanel.Controls.Add(this.buttonPanel, 0, 1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 2;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.topPanel.Size = new System.Drawing.Size(484, 167);
            this.topPanel.TabIndex = 0;
            // 
            // inputDataPanel
            // 
            this.inputDataPanel.ColumnCount = 2;
            this.inputDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.inputDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.inputDataPanel.Controls.Add(this.phoneNumberTextBox, 1, 0);
            this.inputDataPanel.Controls.Add(this.phoneNumberLabel, 0, 0);
            this.inputDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataPanel.Location = new System.Drawing.Point(0, 0);
            this.inputDataPanel.Margin = new System.Windows.Forms.Padding(0);
            this.inputDataPanel.Name = "inputDataPanel";
            this.inputDataPanel.RowCount = 1;
            this.inputDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputDataPanel.Size = new System.Drawing.Size(484, 100);
            this.inputDataPanel.TabIndex = 0;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumberTextBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(193, 40);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(0, 40, 40, 0);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(251, 23);
            this.phoneNumberTextBox.TabIndex = 5;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumberLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(20, 0);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(173, 100);
            this.phoneNumberLabel.TabIndex = 0;
            this.phoneNumberLabel.Text = "전화번호";
            this.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 4;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.Controls.Add(this.searchButton, 0, 0);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(0, 100);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 1;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonPanel.Size = new System.Drawing.Size(484, 67);
            this.buttonPanel.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold);
            this.searchButton.Location = new System.Drawing.Point(20, 10);
            this.searchButton.Margin = new System.Windows.Forms.Padding(20, 10, 3, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 47);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "검색";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 167);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(484, 251);
            this.dataGridView.TabIndex = 1;
            // 
            // bottomPanel
            // 
            this.bottomPanel.ColumnCount = 2;
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.bottomPanel.Controls.Add(this.totalPanel, 1, 0);
            this.bottomPanel.Controls.Add(this.pagingPanel, 0, 0);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 418);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.RowCount = 1;
            this.bottomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomPanel.Size = new System.Drawing.Size(484, 43);
            this.bottomPanel.TabIndex = 2;
            // 
            // totalPanel
            // 
            this.totalPanel.ColumnCount = 2;
            this.totalPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.totalPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.totalPanel.Controls.Add(this.totalTextBox, 1, 0);
            this.totalPanel.Controls.Add(this.totalLabel, 0, 0);
            this.totalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPanel.Location = new System.Drawing.Point(338, 0);
            this.totalPanel.Margin = new System.Windows.Forms.Padding(0);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.RowCount = 1;
            this.totalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalPanel.Size = new System.Drawing.Size(146, 43);
            this.totalPanel.TabIndex = 0;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalTextBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalTextBox.Location = new System.Drawing.Point(58, 8);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(0, 8, 20, 0);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(68, 25);
            this.totalTextBox.TabIndex = 2;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.totalLabel.Location = new System.Drawing.Point(0, 0);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(58, 43);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "TOTAL";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagingPanel
            // 
            this.pagingPanel.ColumnCount = 5;
            this.pagingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pagingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.pagingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pagingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.pagingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pagingPanel.Controls.Add(this.lastPageLabel, 4, 0);
            this.pagingPanel.Controls.Add(this.nextPageLabel, 3, 0);
            this.pagingPanel.Controls.Add(this.prevPageLabel, 1, 0);
            this.pagingPanel.Controls.Add(this.firstPageLabel, 0, 0);
            this.pagingPanel.Controls.Add(this.pageNumber, 2, 0);
            this.pagingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagingPanel.Location = new System.Drawing.Point(0, 0);
            this.pagingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pagingPanel.Name = "pagingPanel";
            this.pagingPanel.RowCount = 1;
            this.pagingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagingPanel.Size = new System.Drawing.Size(338, 43);
            this.pagingPanel.TabIndex = 1;
            // 
            // lastPageLabel
            // 
            this.lastPageLabel.AutoSize = true;
            this.lastPageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastPageLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lastPageLabel.Location = new System.Drawing.Point(283, 0);
            this.lastPageLabel.Name = "lastPageLabel";
            this.lastPageLabel.Size = new System.Drawing.Size(52, 43);
            this.lastPageLabel.TabIndex = 4;
            this.lastPageLabel.Text = ">>";
            this.lastPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastPageLabel.Click += new System.EventHandler(this.lastPageLabel_Click);
            // 
            // nextPageLabel
            // 
            this.nextPageLabel.AutoSize = true;
            this.nextPageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextPageLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nextPageLabel.Location = new System.Drawing.Point(227, 0);
            this.nextPageLabel.Name = "nextPageLabel";
            this.nextPageLabel.Size = new System.Drawing.Size(50, 43);
            this.nextPageLabel.TabIndex = 3;
            this.nextPageLabel.Text = ">";
            this.nextPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextPageLabel.Click += new System.EventHandler(this.nextPageLabel_Click);
            // 
            // prevPageLabel
            // 
            this.prevPageLabel.AutoSize = true;
            this.prevPageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prevPageLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.prevPageLabel.Location = new System.Drawing.Point(59, 0);
            this.prevPageLabel.Name = "prevPageLabel";
            this.prevPageLabel.Size = new System.Drawing.Size(50, 43);
            this.prevPageLabel.TabIndex = 2;
            this.prevPageLabel.Text = "<";
            this.prevPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prevPageLabel.Click += new System.EventHandler(this.prevPageLabel_Click);
            // 
            // firstPageLabel
            // 
            this.firstPageLabel.AutoSize = true;
            this.firstPageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstPageLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.firstPageLabel.Location = new System.Drawing.Point(3, 0);
            this.firstPageLabel.Name = "firstPageLabel";
            this.firstPageLabel.Size = new System.Drawing.Size(50, 43);
            this.firstPageLabel.TabIndex = 1;
            this.firstPageLabel.Text = "<<";
            this.firstPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstPageLabel.Click += new System.EventHandler(this.firstPageLabel_Click);
            // 
            // pageNumber
            // 
            this.pageNumber.AutoSize = true;
            this.pageNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageNumber.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pageNumber.Location = new System.Drawing.Point(115, 0);
            this.pageNumber.Name = "pageNumber";
            this.pageNumber.Size = new System.Drawing.Size(106, 43);
            this.pageNumber.TabIndex = 0;
            this.pageNumber.Text = "Page 1/1";
            this.pageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.totalDivision);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.totalDivision.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.inputDataPanel.ResumeLayout(false);
            this.inputDataPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.totalPanel.ResumeLayout(false);
            this.totalPanel.PerformLayout();
            this.pagingPanel.ResumeLayout(false);
            this.pagingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel totalDivision;
        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.TableLayoutPanel inputDataPanel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel bottomPanel;
        private System.Windows.Forms.TableLayoutPanel totalPanel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TableLayoutPanel pagingPanel;
        private System.Windows.Forms.Label pageNumber;
        private System.Windows.Forms.Label lastPageLabel;
        private System.Windows.Forms.Label nextPageLabel;
        private System.Windows.Forms.Label prevPageLabel;
        private System.Windows.Forms.Label firstPageLabel;
    }
}