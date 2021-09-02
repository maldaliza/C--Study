using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeColorApp01
{
    public partial class ChangeColorAppForm : Form
    {
        #region 생성자 - ChangeColorAppForm()

        public ChangeColorAppForm()
        {
            InitializeComponent();

            #region 이벤트를 설정한다.

            Load += Form_Load;
            this.backgroundColorButton.Click += backgroundColorButton_Click;
            this.foregroundColorButton.Click += foregroundColorButton_Click;

            #endregion
        }

        #endregion

        #region 폼 로드 시 처리하기 - Form_Load(sender, e)

        /// <summary>
        /// 폼 로드시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Form_Load(object sender, EventArgs e)
        {
            int[] backgroundColorArray =
            {
                0xffffff, 0xffc0c0, 0xffe0c0, 0xffffc0, 0xc0ffc0,
                0xc0ffff, 0xc0c0ff, 0xffc0ff, 0xe0e0e0, 0xff8080,
                0xffc080, 0xffff80, 0x80ff80, 0x80ffff, 0x8080ff,
                0xff80ff
            };

            this.backgroundColorDialog.CustomColors = backgroundColorArray;

            int[] foregroundColorArray =
            {
                0x808080, 0xff0000, 0xff8000, 0xffff00, 0x00ff00,
                0x00ffff, 0x0000ff, 0xff00ff, 0x000000, 0xc00000,
                0x804000, 0xc0c000, 0x008000, 0x00c0c0, 0x0000c0,
                0x800080
            };

            this.foregroundColorDialog.CustomColors = foregroundColorArray;
        }

        #endregion
        #region 전경색 버튼 클릭 시 처리하기 - foregroundColorButton_Click(sender, e)

        /// <summary>
        /// 전경색 버튼 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void foregroundColorButton_Click(object sender, EventArgs e)
        {
            this.foregroundColorDialog.Color = this.ForeColor;

            if (this.foregroundColorDialog.ShowDialog() == DialogResult.OK)
            {
                ForeColor = this.foregroundColorDialog.Color;
            }
        }

        #endregion
        #region 배경색 버튼 클릭 시 처리하기 - backgroundColorButton_Click(sender, e)

        /// <summary>
        /// 배경색 버튼 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            this.backgroundColorDialog.Color = this.BackColor;

            if (this.backgroundColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = this.backgroundColorDialog.Color;

                this.backgroundColorButton.BackColor = this.backgroundColorDialog.Color;
                this.foregroundColorButton.BackColor = this.backgroundColorDialog.Color;
            }
        }

        #endregion
    }
}
