
namespace ExerciseServer01
{
    partial class Server
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
            this.button = new System.Windows.Forms.Button();
            this.connectClientPanel = new System.Windows.Forms.TableLayoutPanel();
            this.disconnectPanel = new System.Windows.Forms.TableLayoutPanel();
            this.disconnectLabel = new System.Windows.Forms.Label();
            this.disconnectTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.connectTextBox = new System.Windows.Forms.TextBox();
            this.connectLabel = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.TableLayoutPanel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.totalDivision.SuspendLayout();
            this.connectClientPanel.SuspendLayout();
            this.disconnectPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.messagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalDivision
            // 
            this.totalDivision.ColumnCount = 1;
            this.totalDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalDivision.Controls.Add(this.button, 0, 0);
            this.totalDivision.Controls.Add(this.connectClientPanel, 0, 1);
            this.totalDivision.Controls.Add(this.messagePanel, 0, 2);
            this.totalDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalDivision.Location = new System.Drawing.Point(20, 60);
            this.totalDivision.Margin = new System.Windows.Forms.Padding(0);
            this.totalDivision.Name = "totalDivision";
            this.totalDivision.RowCount = 3;
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.totalDivision.Size = new System.Drawing.Size(760, 370);
            this.totalDivision.TabIndex = 0;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(3, 3);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(754, 68);
            this.button.TabIndex = 0;
            this.button.Text = "클라이언트 접속 확인";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // connectClientPanel
            // 
            this.connectClientPanel.ColumnCount = 2;
            this.connectClientPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectClientPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectClientPanel.Controls.Add(this.disconnectPanel, 1, 0);
            this.connectClientPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.connectClientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectClientPanel.Location = new System.Drawing.Point(0, 74);
            this.connectClientPanel.Margin = new System.Windows.Forms.Padding(0);
            this.connectClientPanel.Name = "connectClientPanel";
            this.connectClientPanel.RowCount = 1;
            this.connectClientPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectClientPanel.Size = new System.Drawing.Size(760, 185);
            this.connectClientPanel.TabIndex = 1;
            // 
            // disconnectPanel
            // 
            this.disconnectPanel.ColumnCount = 1;
            this.disconnectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.disconnectPanel.Controls.Add(this.disconnectLabel, 0, 0);
            this.disconnectPanel.Controls.Add(this.disconnectTextBox, 0, 1);
            this.disconnectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disconnectPanel.Location = new System.Drawing.Point(380, 0);
            this.disconnectPanel.Margin = new System.Windows.Forms.Padding(0);
            this.disconnectPanel.Name = "disconnectPanel";
            this.disconnectPanel.RowCount = 2;
            this.disconnectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.disconnectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.disconnectPanel.Size = new System.Drawing.Size(380, 185);
            this.disconnectPanel.TabIndex = 0;
            // 
            // disconnectLabel
            // 
            this.disconnectLabel.AutoSize = true;
            this.disconnectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disconnectLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.disconnectLabel.Location = new System.Drawing.Point(3, 0);
            this.disconnectLabel.Name = "disconnectLabel";
            this.disconnectLabel.Size = new System.Drawing.Size(374, 30);
            this.disconnectLabel.TabIndex = 0;
            this.disconnectLabel.Text = "접속 실패 클라이언트";
            this.disconnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // disconnectTextBox
            // 
            this.disconnectTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disconnectTextBox.Location = new System.Drawing.Point(3, 33);
            this.disconnectTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.disconnectTextBox.Multiline = true;
            this.disconnectTextBox.Name = "disconnectTextBox";
            this.disconnectTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.disconnectTextBox.Size = new System.Drawing.Size(357, 149);
            this.disconnectTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.connectTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.connectLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 185);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // connectTextBox
            // 
            this.connectTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectTextBox.Location = new System.Drawing.Point(3, 33);
            this.connectTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.connectTextBox.Multiline = true;
            this.connectTextBox.Name = "connectTextBox";
            this.connectTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.connectTextBox.Size = new System.Drawing.Size(357, 149);
            this.connectTextBox.TabIndex = 2;
            // 
            // connectLabel
            // 
            this.connectLabel.AutoSize = true;
            this.connectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.connectLabel.Location = new System.Drawing.Point(3, 0);
            this.connectLabel.Name = "connectLabel";
            this.connectLabel.Size = new System.Drawing.Size(374, 30);
            this.connectLabel.TabIndex = 1;
            this.connectLabel.Text = "접속 클라이언트";
            this.connectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // messagePanel
            // 
            this.messagePanel.ColumnCount = 1;
            this.messagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messagePanel.Controls.Add(this.messageTextBox, 0, 1);
            this.messagePanel.Controls.Add(this.messageLabel, 0, 0);
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagePanel.Location = new System.Drawing.Point(0, 259);
            this.messagePanel.Margin = new System.Windows.Forms.Padding(0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.RowCount = 2;
            this.messagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.messagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messagePanel.Size = new System.Drawing.Size(760, 111);
            this.messagePanel.TabIndex = 2;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextBox.Location = new System.Drawing.Point(3, 33);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(754, 75);
            this.messageTextBox.TabIndex = 3;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.messageLabel.Location = new System.Drawing.Point(3, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(754, 30);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "클라이언트로부터 받은 메시지";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalDivision);
            this.Name = "Server";
            this.Text = "Server";
            this.totalDivision.ResumeLayout(false);
            this.connectClientPanel.ResumeLayout(false);
            this.disconnectPanel.ResumeLayout(false);
            this.disconnectPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel totalDivision;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TableLayoutPanel connectClientPanel;
        private System.Windows.Forms.TableLayoutPanel disconnectPanel;
        private System.Windows.Forms.Label disconnectLabel;
        private System.Windows.Forms.TextBox disconnectTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox connectTextBox;
        private System.Windows.Forms.Label connectLabel;
        private System.Windows.Forms.TableLayoutPanel messagePanel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label messageLabel;
    }
}

