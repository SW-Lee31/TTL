
namespace View_structure_0811.UI.UI_contents
{
    partial class Add_person
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
            this.input_date = new Sunny.UI.UIDatePicker();
            this.input_gender_female = new Sunny.UI.UIRadioButton();
            this.input_gender_male = new Sunny.UI.UIRadioButton();
            this.text5 = new Sunny.UI.UILabel();
            this.text4 = new Sunny.UI.UILabel();
            this.input_addr = new Sunny.UI.UITextBox();
            this.text3 = new Sunny.UI.UILabel();
            this.input_digit = new Sunny.UI.UITextBox();
            this.text2 = new Sunny.UI.UILabel();
            this.input_name = new Sunny.UI.UITextBox();
            this.text1 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.but_confirm = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // input_date
            // 
            this.input_date.BackColor = System.Drawing.Color.White;
            this.input_date.FillColor = System.Drawing.Color.White;
            this.input_date.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_date.ForeColor = System.Drawing.Color.Silver;
            this.input_date.Location = new System.Drawing.Point(244, 233);
            this.input_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_date.MaxLength = 10;
            this.input_date.MinimumSize = new System.Drawing.Size(63, 0);
            this.input_date.Name = "input_date";
            this.input_date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.input_date.RectColor = System.Drawing.Color.Black;
            this.input_date.Size = new System.Drawing.Size(186, 29);
            this.input_date.Style = Sunny.UI.UIStyle.Custom;
            this.input_date.SymbolDropDown = 61555;
            this.input_date.SymbolNormal = 61555;
            this.input_date.TabIndex = 96;
            this.input_date.Text = "2021-07-30";
            this.input_date.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.input_date.Value = new System.DateTime(2021, 7, 30, 9, 44, 57, 692);
            // 
            // input_gender_female
            // 
            this.input_gender_female.BackColor = System.Drawing.Color.Transparent;
            this.input_gender_female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.input_gender_female.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_gender_female.ForeColor = System.Drawing.Color.Gray;
            this.input_gender_female.Location = new System.Drawing.Point(343, 270);
            this.input_gender_female.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_gender_female.Name = "input_gender_female";
            this.input_gender_female.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.input_gender_female.RadioButtonColor = System.Drawing.Color.Black;
            this.input_gender_female.Size = new System.Drawing.Size(86, 29);
            this.input_gender_female.Style = Sunny.UI.UIStyle.Custom;
            this.input_gender_female.TabIndex = 95;
            this.input_gender_female.Text = "Female";
            // 
            // input_gender_male
            // 
            this.input_gender_male.BackColor = System.Drawing.Color.Transparent;
            this.input_gender_male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.input_gender_male.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_gender_male.ForeColor = System.Drawing.Color.Gray;
            this.input_gender_male.Location = new System.Drawing.Point(244, 270);
            this.input_gender_male.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_gender_male.Name = "input_gender_male";
            this.input_gender_male.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.input_gender_male.RadioButtonColor = System.Drawing.Color.Black;
            this.input_gender_male.Size = new System.Drawing.Size(75, 29);
            this.input_gender_male.Style = Sunny.UI.UIStyle.Custom;
            this.input_gender_male.TabIndex = 94;
            this.input_gender_male.Text = "Male";
            // 
            // text5
            // 
            this.text5.BackColor = System.Drawing.Color.Transparent;
            this.text5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text5.ForeColor = System.Drawing.Color.Gray;
            this.text5.Location = new System.Drawing.Point(27, 270);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(164, 23);
            this.text5.Style = Sunny.UI.UIStyle.Custom;
            this.text5.TabIndex = 93;
            this.text5.Text = "※ 성별";
            this.text5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text4
            // 
            this.text4.BackColor = System.Drawing.Color.Transparent;
            this.text4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text4.ForeColor = System.Drawing.Color.Gray;
            this.text4.Location = new System.Drawing.Point(47, 233);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(164, 23);
            this.text4.Style = Sunny.UI.UIStyle.Custom;
            this.text4.TabIndex = 92;
            this.text4.Text = "※ 가입날짜";
            this.text4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_addr
            // 
            this.input_addr.BackColor = System.Drawing.Color.White;
            this.input_addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_addr.FillColor = System.Drawing.Color.White;
            this.input_addr.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_addr.Location = new System.Drawing.Point(244, 174);
            this.input_addr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_addr.Maximum = 2147483647D;
            this.input_addr.Minimum = -2147483648D;
            this.input_addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_addr.Name = "input_addr";
            this.input_addr.RectColor = System.Drawing.Color.Black;
            this.input_addr.Size = new System.Drawing.Size(288, 43);
            this.input_addr.Style = Sunny.UI.UIStyle.Custom;
            this.input_addr.TabIndex = 91;
            this.input_addr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text3
            // 
            this.text3.BackColor = System.Drawing.Color.Transparent;
            this.text3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text3.ForeColor = System.Drawing.Color.Gray;
            this.text3.Location = new System.Drawing.Point(27, 174);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(164, 23);
            this.text3.Style = Sunny.UI.UIStyle.Custom;
            this.text3.TabIndex = 90;
            this.text3.Text = "※ 주소";
            this.text3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_digit
            // 
            this.input_digit.BackColor = System.Drawing.Color.White;
            this.input_digit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_digit.FillColor = System.Drawing.Color.White;
            this.input_digit.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_digit.Location = new System.Drawing.Point(243, 129);
            this.input_digit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_digit.Maximum = 2147483647D;
            this.input_digit.Minimum = -2147483648D;
            this.input_digit.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_digit.Name = "input_digit";
            this.input_digit.RectColor = System.Drawing.Color.Black;
            this.input_digit.Size = new System.Drawing.Size(273, 29);
            this.input_digit.Style = Sunny.UI.UIStyle.Custom;
            this.input_digit.TabIndex = 89;
            this.input_digit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.Transparent;
            this.text2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.ForeColor = System.Drawing.Color.Gray;
            this.text2.Location = new System.Drawing.Point(47, 129);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(164, 23);
            this.text2.Style = Sunny.UI.UIStyle.Custom;
            this.text2.TabIndex = 88;
            this.text2.Text = "※ 전화번호";
            this.text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_name
            // 
            this.input_name.BackColor = System.Drawing.Color.White;
            this.input_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_name.FillColor = System.Drawing.Color.White;
            this.input_name.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_name.Location = new System.Drawing.Point(244, 85);
            this.input_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_name.Maximum = 2147483647D;
            this.input_name.Minimum = -2147483648D;
            this.input_name.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_name.Name = "input_name";
            this.input_name.RectColor = System.Drawing.Color.Black;
            this.input_name.Size = new System.Drawing.Size(163, 29);
            this.input_name.Style = Sunny.UI.UIStyle.Custom;
            this.input_name.TabIndex = 87;
            this.input_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.Transparent;
            this.text1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text1.ForeColor = System.Drawing.Color.Gray;
            this.text1.Location = new System.Drawing.Point(27, 85);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(164, 23);
            this.text1.TabIndex = 86;
            this.text1.Text = "※ 이름";
            this.text1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(0, 13);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(585, 37);
            this.uiLabel1.TabIndex = 97;
            this.uiLabel1.Text = "인적사항을 입력해주세요.";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.but_confirm.Location = new System.Drawing.Point(228, 325);
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
            this.but_confirm.TabIndex = 151;
            this.but_confirm.Text = "등록";
            this.but_confirm.Click += new System.EventHandler(this.but_confirm_Click);
            // 
            // Add_person
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.but_confirm);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.input_date);
            this.Controls.Add(this.input_gender_female);
            this.Controls.Add(this.input_gender_male);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.input_addr);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.input_digit);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.text1);
            this.Name = "Add_person";
            this.Size = new System.Drawing.Size(585, 402);
            this.Load += new System.EventHandler(this.Add_person_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDatePicker input_date;
        private Sunny.UI.UIRadioButton input_gender_female;
        private Sunny.UI.UIRadioButton input_gender_male;
        private Sunny.UI.UILabel text5;
        private Sunny.UI.UILabel text4;
        private Sunny.UI.UITextBox input_addr;
        private Sunny.UI.UILabel text3;
        private Sunny.UI.UITextBox input_digit;
        private Sunny.UI.UILabel text2;
        private Sunny.UI.UITextBox input_name;
        private Sunny.UI.UILabel text1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton but_confirm;
    }
}
