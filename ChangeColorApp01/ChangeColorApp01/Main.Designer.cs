
namespace ChangeColorApp01
{
    partial class ChangeColorAppForm
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
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.foregroundColorButton = new System.Windows.Forms.Button();
            this.backgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.foregroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Location = new System.Drawing.Point(100, 50);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(180, 55);
            this.backgroundColorButton.TabIndex = 0;
            this.backgroundColorButton.Text = "배경색";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            // 
            // foregroundColorButton
            // 
            this.foregroundColorButton.Location = new System.Drawing.Point(100, 150);
            this.foregroundColorButton.Name = "foregroundColorButton";
            this.foregroundColorButton.Size = new System.Drawing.Size(180, 55);
            this.foregroundColorButton.TabIndex = 1;
            this.foregroundColorButton.Text = "전경색";
            this.foregroundColorButton.UseVisualStyleBackColor = true;
            // 
            // ChangeColorAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.foregroundColorButton);
            this.Controls.Add(this.backgroundColorButton);
            this.Name = "ChangeColorAppForm";
            this.Text = "Change Color";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Button foregroundColorButton;
        private System.Windows.Forms.ColorDialog backgroundColorDialog;
        private System.Windows.Forms.ColorDialog foregroundColorDialog;
    }
}

