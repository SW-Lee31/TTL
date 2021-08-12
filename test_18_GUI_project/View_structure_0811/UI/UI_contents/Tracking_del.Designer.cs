
namespace View_structure_0811.UI.UI_contents
{
    partial class Tracking_del
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_del_digit = new Sunny.UI.UITextBox();
            this.but_confirm = new Sunny.UI.UISymbolButton();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // input_del_digit
            // 
            this.input_del_digit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_del_digit.FillColor = System.Drawing.Color.White;
            this.input_del_digit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_del_digit.Location = new System.Drawing.Point(170, 250);
            this.input_del_digit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_del_digit.Maximum = 2147483647D;
            this.input_del_digit.Minimum = -2147483648D;
            this.input_del_digit.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_del_digit.Name = "input_del_digit";
            this.input_del_digit.RectColor = System.Drawing.Color.Black;
            this.input_del_digit.Size = new System.Drawing.Size(244, 29);
            this.input_del_digit.Style = Sunny.UI.UIStyle.Custom;
            this.input_del_digit.TabIndex = 153;
            this.input_del_digit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // but_confirm
            // 
            this.but_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_confirm.FillColor = System.Drawing.Color.White;
            this.but_confirm.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_confirm.FillPressColor = System.Drawing.Color.Lime;
            this.but_confirm.FillSelectedColor = System.Drawing.Color.White;
            this.but_confirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_confirm.ForeColor = System.Drawing.Color.Black;
            this.but_confirm.ForeHoverColor = System.Drawing.Color.DarkRed;
            this.but_confirm.ForePressColor = System.Drawing.Color.Red;
            this.but_confirm.Location = new System.Drawing.Point(231, 327);
            this.but_confirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_confirm.Name = "but_confirm";
            this.but_confirm.RectColor = System.Drawing.Color.Black;
            this.but_confirm.RectDisableColor = System.Drawing.Color.Transparent;
            this.but_confirm.RectHoverColor = System.Drawing.Color.Lime;
            this.but_confirm.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_confirm.RectSelectedColor = System.Drawing.Color.Lime;
            this.but_confirm.Size = new System.Drawing.Size(123, 54);
            this.but_confirm.Style = Sunny.UI.UIStyle.Custom;
            this.but_confirm.StyleCustomMode = true;
            this.but_confirm.TabIndex = 150;
            this.but_confirm.Text = "조회";
            this.but_confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel5.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel5.Location = new System.Drawing.Point(3, 202);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(585, 43);
            this.uiLabel5.TabIndex = 143;
            this.uiLabel5.Text = "주문번호를 입력해주세요.";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = global::View_structure_0811.Properties.Resources.magnifying_glass;
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(10, 3);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(562, 196);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 154;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // Tracking_del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.input_del_digit);
            this.Controls.Add(this.but_confirm);
            this.Controls.Add(this.uiLabel5);
            this.Name = "Tracking_del";
            this.Size = new System.Drawing.Size(585, 402);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox input_del_digit;
        private Sunny.UI.UISymbolButton but_confirm;
        private Sunny.UI.UILabel uiLabel5;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
    }
}
