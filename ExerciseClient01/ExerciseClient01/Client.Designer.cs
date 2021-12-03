
namespace ExerciseClient01
{
    partial class Client
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
            this.connectButton = new System.Windows.Forms.Button();
            this.messagePanel = new System.Windows.Forms.TableLayoutPanel();
            this.sendButton = new System.Windows.Forms.Button();
            this.sendMsgTextBox = new System.Windows.Forms.TextBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.totalDivision.SuspendLayout();
            this.messagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalDivision
            // 
            this.totalDivision.ColumnCount = 1;
            this.totalDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalDivision.Controls.Add(this.connectButton, 0, 0);
            this.totalDivision.Controls.Add(this.messagePanel, 0, 2);
            this.totalDivision.Controls.Add(this.messageListBox, 0, 1);
            this.totalDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalDivision.Location = new System.Drawing.Point(20, 60);
            this.totalDivision.Margin = new System.Windows.Forms.Padding(0);
            this.totalDivision.Name = "totalDivision";
            this.totalDivision.RowCount = 3;
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.totalDivision.Size = new System.Drawing.Size(760, 370);
            this.totalDivision.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.connectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.connectButton.ForeColor = System.Drawing.Color.White;
            this.connectButton.Location = new System.Drawing.Point(3, 3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(754, 54);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "서버 접속 요청";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // messagePanel
            // 
            this.messagePanel.ColumnCount = 2;
            this.messagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.messagePanel.Controls.Add(this.sendButton, 1, 0);
            this.messagePanel.Controls.Add(this.sendMsgTextBox, 0, 0);
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagePanel.Location = new System.Drawing.Point(0, 330);
            this.messagePanel.Margin = new System.Windows.Forms.Padding(0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.RowCount = 1;
            this.messagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messagePanel.Size = new System.Drawing.Size(760, 40);
            this.messagePanel.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(633, 3);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(124, 34);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // sendMsgTextBox
            // 
            this.sendMsgTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendMsgTextBox.Location = new System.Drawing.Point(3, 10);
            this.sendMsgTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.sendMsgTextBox.Name = "sendMsgTextBox";
            this.sendMsgTextBox.Size = new System.Drawing.Size(624, 21);
            this.sendMsgTextBox.TabIndex = 1;
            // 
            // messageListBox
            // 
            this.messageListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 12;
            this.messageListBox.Location = new System.Drawing.Point(3, 63);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(754, 264);
            this.messageListBox.TabIndex = 2;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalDivision);
            this.Name = "Client";
            this.Text = "Client";
            this.totalDivision.ResumeLayout(false);
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel totalDivision;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TableLayoutPanel messagePanel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox sendMsgTextBox;
        private System.Windows.Forms.ListBox messageListBox;
    }
}

