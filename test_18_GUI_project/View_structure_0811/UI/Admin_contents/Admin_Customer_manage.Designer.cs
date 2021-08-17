
namespace View_structure_0811.UI.UI_contents
{
    partial class Admin_Customer_manage
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
            this.confirm = new Sunny.UI.UISymbolButton();
            this.cus_but_submit = new Sunny.UI.UISymbolButton();
            this.input_mem_digit = new System.Windows.Forms.TextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.output_gender = new Sunny.UI.UILabel();
            this.output_birth = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.output_digit = new Sunny.UI.UILabel();
            this.text2 = new Sunny.UI.UILabel();
            this.output_cusname = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.output_addr = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm.FillColor = System.Drawing.Color.White;
            this.confirm.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.confirm.FillPressColor = System.Drawing.Color.Lime;
            this.confirm.FillSelectedColor = System.Drawing.Color.White;
            this.confirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.confirm.ForeColor = System.Drawing.Color.Black;
            this.confirm.ForeHoverColor = System.Drawing.Color.DarkRed;
            this.confirm.ForePressColor = System.Drawing.Color.Red;
            this.confirm.Location = new System.Drawing.Point(320, 46);
            this.confirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.confirm.Name = "confirm";
            this.confirm.RectColor = System.Drawing.Color.Black;
            this.confirm.RectDisableColor = System.Drawing.Color.Transparent;
            this.confirm.RectHoverColor = System.Drawing.Color.Lime;
            this.confirm.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.confirm.RectSelectedColor = System.Drawing.Color.Lime;
            this.confirm.Size = new System.Drawing.Size(71, 25);
            this.confirm.Style = Sunny.UI.UIStyle.Custom;
            this.confirm.StyleCustomMode = true;
            this.confirm.TabIndex = 123;
            this.confirm.Text = "확인";
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cus_but_submit
            // 
            this.cus_but_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cus_but_submit.FillColor = System.Drawing.Color.White;
            this.cus_but_submit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cus_but_submit.FillPressColor = System.Drawing.Color.Lime;
            this.cus_but_submit.FillSelectedColor = System.Drawing.Color.White;
            this.cus_but_submit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cus_but_submit.ForeColor = System.Drawing.Color.Black;
            this.cus_but_submit.ForeHoverColor = System.Drawing.Color.DarkRed;
            this.cus_but_submit.ForePressColor = System.Drawing.Color.Red;
            this.cus_but_submit.Location = new System.Drawing.Point(317, 308);
            this.cus_but_submit.MinimumSize = new System.Drawing.Size(1, 1);
            this.cus_but_submit.Name = "cus_but_submit";
            this.cus_but_submit.RectColor = System.Drawing.Color.Black;
            this.cus_but_submit.RectDisableColor = System.Drawing.Color.Transparent;
            this.cus_but_submit.RectHoverColor = System.Drawing.Color.Lime;
            this.cus_but_submit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cus_but_submit.RectSelectedColor = System.Drawing.Color.Lime;
            this.cus_but_submit.Size = new System.Drawing.Size(71, 27);
            this.cus_but_submit.Style = Sunny.UI.UIStyle.Custom;
            this.cus_but_submit.StyleCustomMode = true;
            this.cus_but_submit.TabIndex = 122;
            this.cus_but_submit.Text = "등록";
            this.cus_but_submit.Click += new System.EventHandler(this.cus_but_submit_Click);
            // 
            // input_mem_digit
            // 
            this.input_mem_digit.Location = new System.Drawing.Point(150, 311);
            this.input_mem_digit.Name = "input_mem_digit";
            this.input_mem_digit.Size = new System.Drawing.Size(150, 21);
            this.input_mem_digit.TabIndex = 121;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel4.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel4.Location = new System.Drawing.Point(98, 271);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(339, 31);
            this.uiLabel4.TabIndex = 120;
            this.uiLabel4.Text = "부여할 고객번호를 입력하세요.";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_gender
            // 
            this.output_gender.BackColor = System.Drawing.Color.Transparent;
            this.output_gender.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_gender.ForeColor = System.Drawing.Color.Black;
            this.output_gender.Location = new System.Drawing.Point(229, 177);
            this.output_gender.Name = "output_gender";
            this.output_gender.Size = new System.Drawing.Size(162, 26);
            this.output_gender.TabIndex = 119;
            this.output_gender.Text = "data";
            this.output_gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_birth
            // 
            this.output_birth.BackColor = System.Drawing.Color.Transparent;
            this.output_birth.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_birth.ForeColor = System.Drawing.Color.Black;
            this.output_birth.Location = new System.Drawing.Point(229, 135);
            this.output_birth.Name = "output_birth";
            this.output_birth.Size = new System.Drawing.Size(162, 26);
            this.output_birth.TabIndex = 118;
            this.output_birth.Text = "data";
            this.output_birth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel3.Location = new System.Drawing.Point(53, 178);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(90, 28);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 117;
            this.uiLabel3.Text = "※ 성별";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel2.Location = new System.Drawing.Point(69, 135);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(90, 28);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 116;
            this.uiLabel2.Text = "※ 가입날짜";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_digit
            // 
            this.output_digit.BackColor = System.Drawing.Color.Transparent;
            this.output_digit.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_digit.ForeColor = System.Drawing.Color.Black;
            this.output_digit.Location = new System.Drawing.Point(229, 87);
            this.output_digit.Name = "output_digit";
            this.output_digit.Size = new System.Drawing.Size(162, 26);
            this.output_digit.TabIndex = 114;
            this.output_digit.Text = "data";
            this.output_digit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.Transparent;
            this.text2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.ForeColor = System.Drawing.Color.Gray;
            this.text2.Location = new System.Drawing.Point(66, 85);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(93, 28);
            this.text2.Style = Sunny.UI.UIStyle.Custom;
            this.text2.TabIndex = 112;
            this.text2.Text = "※ 전화번호";
            this.text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_cusname
            // 
            this.output_cusname.DataSource = null;
            this.output_cusname.FillColor = System.Drawing.Color.White;
            this.output_cusname.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.output_cusname.Location = new System.Drawing.Point(141, 44);
            this.output_cusname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.output_cusname.MinimumSize = new System.Drawing.Size(63, 0);
            this.output_cusname.Name = "output_cusname";
            this.output_cusname.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.output_cusname.Size = new System.Drawing.Size(159, 25);
            this.output_cusname.TabIndex = 110;
            this.output_cusname.Text = "고객명";
            this.output_cusname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel5.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel5.Location = new System.Drawing.Point(45, 10);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(444, 29);
            this.uiLabel5.TabIndex = 111;
            this.uiLabel5.Text = "고객명을 확인해주세요.";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel1.Location = new System.Drawing.Point(52, 223);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(91, 28);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 124;
            this.uiLabel1.Text = "※ 주소";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_addr
            // 
            this.output_addr.BackColor = System.Drawing.Color.Transparent;
            this.output_addr.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_addr.ForeColor = System.Drawing.Color.Black;
            this.output_addr.Location = new System.Drawing.Point(120, 223);
            this.output_addr.Name = "output_addr";
            this.output_addr.Size = new System.Drawing.Size(342, 26);
            this.output_addr.TabIndex = 125;
            this.output_addr.Text = "data";
            this.output_addr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin_Customer_manage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.output_addr);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.cus_but_submit);
            this.Controls.Add(this.input_mem_digit);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.output_gender);
            this.Controls.Add(this.output_birth);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.output_digit);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.output_cusname);
            this.Controls.Add(this.uiLabel5);
            this.Name = "Admin_Customer_manage";
            this.Size = new System.Drawing.Size(515, 358);
            this.Load += new System.EventHandler(this.Admin_Customer_manage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UISymbolButton confirm;
        private Sunny.UI.UISymbolButton cus_but_submit;
        private System.Windows.Forms.TextBox input_mem_digit;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel output_gender;
        private Sunny.UI.UILabel output_birth;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel output_digit;
        private Sunny.UI.UILabel text2;
        private Sunny.UI.UIComboBox output_cusname;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel output_addr;
    }
}
