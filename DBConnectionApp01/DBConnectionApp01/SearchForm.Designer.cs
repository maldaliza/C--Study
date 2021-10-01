
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
            this.totalDivision.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.inputDataPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // totalDivision
            // 
            this.totalDivision.ColumnCount = 1;
            this.totalDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.totalDivision.Controls.Add(this.topPanel, 0, 0);
            this.totalDivision.Controls.Add(this.dataGridView, 0, 1);
            this.totalDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalDivision.Location = new System.Drawing.Point(0, 0);
            this.totalDivision.Margin = new System.Windows.Forms.Padding(0);
            this.totalDivision.Name = "totalDivision";
            this.totalDivision.RowCount = 3;
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.totalDivision.Size = new System.Drawing.Size(384, 461);
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
            this.topPanel.Size = new System.Drawing.Size(384, 167);
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
            this.inputDataPanel.Size = new System.Drawing.Size(384, 100);
            this.inputDataPanel.TabIndex = 0;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumberTextBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(153, 40);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(0, 40, 40, 0);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(191, 23);
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
            this.phoneNumberLabel.Size = new System.Drawing.Size(133, 100);
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
            this.buttonPanel.Size = new System.Drawing.Size(384, 67);
            this.buttonPanel.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold);
            this.searchButton.Location = new System.Drawing.Point(20, 10);
            this.searchButton.Margin = new System.Windows.Forms.Padding(20, 10, 3, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 47);
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
            this.dataGridView.Size = new System.Drawing.Size(384, 251);
            this.dataGridView.TabIndex = 1;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.totalDivision);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.totalDivision.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.inputDataPanel.ResumeLayout(false);
            this.inputDataPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
    }
}