
namespace Class0727_03_Winform.UI
{
    partial class Add_customer
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
            this.title = new Sunny.UI.UISymbolLabel();
            this.but_back = new Sunny.UI.UISymbolButton();
            this.but_submit = new Sunny.UI.UISymbolButton();
            this.but_temp_store = new Sunny.UI.UISymbolButton();
            this.text1 = new Sunny.UI.UILabel();
            this.input_name = new Sunny.UI.UITextBox();
            this.input_digit = new Sunny.UI.UITextBox();
            this.text2 = new Sunny.UI.UILabel();
            this.input_address = new Sunny.UI.UITextBox();
            this.text3 = new Sunny.UI.UILabel();
            this.text4 = new Sunny.UI.UILabel();
            this.input_date = new Sunny.UI.UIDatetimePicker();
            this.text5 = new Sunny.UI.UILabel();
            this.input_gender_male = new Sunny.UI.UIRadioButton();
            this.input_gender_female = new Sunny.UI.UIRadioButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.but_check_ad = new Sunny.UI.UICheckBox();
            this.but_introduced = new Sunny.UI.UICheckBox();
            this.uiCheckBox2 = new Sunny.UI.UICheckBox();
            this.uiCheckBox3 = new Sunny.UI.UICheckBox();
            this.line1 = new Sunny.UI.UILine();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.text6 = new Sunny.UI.UILabel();
            this.input_year = new Sunny.UI.UIComboBox();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("양재벨라체M", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(73, 12);
            this.title.MinimumSize = new System.Drawing.Size(1, 1);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.title.Size = new System.Drawing.Size(528, 44);
            this.title.Style = Sunny.UI.UIStyle.Custom;
            this.title.Symbol = 61980;
            this.title.SymbolColor = System.Drawing.Color.Black;
            this.title.SymbolSize = 45;
            this.title.TabIndex = 56;
            this.title.Text = "THE MOTOR";
            // 
            // but_back
            // 
            this.but_back.BackColor = System.Drawing.Color.Transparent;
            this.but_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_back.FillColor = System.Drawing.Color.Transparent;
            this.but_back.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.but_back.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.but_back.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.but_back.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_back.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_back.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_back.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_back.Location = new System.Drawing.Point(12, 10);
            this.but_back.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_back.Name = "but_back";
            this.but_back.RectColor = System.Drawing.Color.White;
            this.but_back.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_back.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_back.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_back.Size = new System.Drawing.Size(41, 39);
            this.but_back.Style = Sunny.UI.UIStyle.Custom;
            this.but_back.Symbol = 61536;
            this.but_back.SymbolSize = 30;
            this.but_back.TabIndex = 57;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // but_submit
            // 
            this.but_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_submit.FillColor = System.Drawing.Color.White;
            this.but_submit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_submit.FillPressColor = System.Drawing.Color.Lime;
            this.but_submit.FillSelectedColor = System.Drawing.Color.White;
            this.but_submit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_submit.ForeColor = System.Drawing.Color.Black;
            this.but_submit.ForeHoverColor = System.Drawing.Color.DarkRed;
            this.but_submit.ForePressColor = System.Drawing.Color.Red;
            this.but_submit.Location = new System.Drawing.Point(371, 606);
            this.but_submit.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_submit.Name = "but_submit";
            this.but_submit.RectColor = System.Drawing.Color.Transparent;
            this.but_submit.RectDisableColor = System.Drawing.Color.Transparent;
            this.but_submit.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_submit.RectPressColor = System.Drawing.Color.Transparent;
            this.but_submit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.but_submit.Size = new System.Drawing.Size(186, 47);
            this.but_submit.Style = Sunny.UI.UIStyle.Custom;
            this.but_submit.StyleCustomMode = true;
            this.but_submit.TabIndex = 58;
            this.but_submit.Text = "Submit";
            this.but_submit.Click += new System.EventHandler(this.but_submit_Click);
            // 
            // but_temp_store
            // 
            this.but_temp_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_temp_store.FillColor = System.Drawing.Color.White;
            this.but_temp_store.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.but_temp_store.FillPressColor = System.Drawing.Color.Silver;
            this.but_temp_store.FillSelectedColor = System.Drawing.Color.White;
            this.but_temp_store.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_temp_store.ForeColor = System.Drawing.Color.Black;
            this.but_temp_store.ForeHoverColor = System.Drawing.Color.DarkRed;
            this.but_temp_store.ForePressColor = System.Drawing.Color.Red;
            this.but_temp_store.Location = new System.Drawing.Point(123, 606);
            this.but_temp_store.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_temp_store.Name = "but_temp_store";
            this.but_temp_store.RectColor = System.Drawing.Color.Transparent;
            this.but_temp_store.RectDisableColor = System.Drawing.Color.Transparent;
            this.but_temp_store.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_temp_store.RectPressColor = System.Drawing.Color.Transparent;
            this.but_temp_store.RectSelectedColor = System.Drawing.Color.Transparent;
            this.but_temp_store.Size = new System.Drawing.Size(186, 47);
            this.but_temp_store.Style = Sunny.UI.UIStyle.Custom;
            this.but_temp_store.StyleCustomMode = true;
            this.but_temp_store.TabIndex = 59;
            this.but_temp_store.Text = "Temporary store";
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.Transparent;
            this.text1.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text1.ForeColor = System.Drawing.Color.Black;
            this.text1.Location = new System.Drawing.Point(135, 118);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(164, 23);
            this.text1.TabIndex = 60;
            this.text1.Text = "※ Name";
            this.text1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_name
            // 
            this.input_name.BackColor = System.Drawing.Color.White;
            this.input_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_name.FillColor = System.Drawing.Color.White;
            this.input_name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_name.Location = new System.Drawing.Point(358, 118);
            this.input_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_name.Maximum = 2147483647D;
            this.input_name.Minimum = -2147483648D;
            this.input_name.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_name.Name = "input_name";
            this.input_name.RectColor = System.Drawing.Color.Transparent;
            this.input_name.Size = new System.Drawing.Size(117, 29);
            this.input_name.Style = Sunny.UI.UIStyle.Custom;
            this.input_name.TabIndex = 61;
            this.input_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_digit
            // 
            this.input_digit.BackColor = System.Drawing.Color.White;
            this.input_digit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_digit.FillColor = System.Drawing.Color.White;
            this.input_digit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_digit.Location = new System.Drawing.Point(358, 174);
            this.input_digit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_digit.Maximum = 2147483647D;
            this.input_digit.Minimum = -2147483648D;
            this.input_digit.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_digit.Name = "input_digit";
            this.input_digit.RectColor = System.Drawing.Color.Transparent;
            this.input_digit.Size = new System.Drawing.Size(227, 29);
            this.input_digit.Style = Sunny.UI.UIStyle.Custom;
            this.input_digit.TabIndex = 63;
            this.input_digit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.input_digit.TextChanged += new System.EventHandler(this.uiTextBox2_TextChanged);
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.Transparent;
            this.text2.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.ForeColor = System.Drawing.Color.Black;
            this.text2.Location = new System.Drawing.Point(130, 175);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(164, 23);
            this.text2.Style = Sunny.UI.UIStyle.Custom;
            this.text2.TabIndex = 62;
            this.text2.Text = "※ Digit";
            this.text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_address
            // 
            this.input_address.BackColor = System.Drawing.Color.White;
            this.input_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_address.FillColor = System.Drawing.Color.White;
            this.input_address.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_address.Location = new System.Drawing.Point(358, 232);
            this.input_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_address.Maximum = 2147483647D;
            this.input_address.Minimum = -2147483648D;
            this.input_address.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_address.Name = "input_address";
            this.input_address.RectColor = System.Drawing.Color.Transparent;
            this.input_address.Size = new System.Drawing.Size(250, 51);
            this.input_address.Style = Sunny.UI.UIStyle.Custom;
            this.input_address.TabIndex = 65;
            this.input_address.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text3
            // 
            this.text3.BackColor = System.Drawing.Color.Transparent;
            this.text3.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text3.ForeColor = System.Drawing.Color.Black;
            this.text3.Location = new System.Drawing.Point(141, 238);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(164, 23);
            this.text3.Style = Sunny.UI.UIStyle.Custom;
            this.text3.TabIndex = 64;
            this.text3.Text = "※ Address";
            this.text3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text4
            // 
            this.text4.BackColor = System.Drawing.Color.Transparent;
            this.text4.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text4.ForeColor = System.Drawing.Color.Black;
            this.text4.Location = new System.Drawing.Point(164, 316);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(164, 23);
            this.text4.Style = Sunny.UI.UIStyle.Custom;
            this.text4.TabIndex = 67;
            this.text4.Text = "※ Submit Date";
            this.text4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_date
            // 
            this.input_date.FillColor = System.Drawing.Color.White;
            this.input_date.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_date.Location = new System.Drawing.Point(360, 316);
            this.input_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_date.MaxLength = 19;
            this.input_date.MinimumSize = new System.Drawing.Size(63, 0);
            this.input_date.Name = "input_date";
            this.input_date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.input_date.RectColor = System.Drawing.Color.Transparent;
            this.input_date.Size = new System.Drawing.Size(200, 29);
            this.input_date.Style = Sunny.UI.UIStyle.Custom;
            this.input_date.SymbolDropDown = 61555;
            this.input_date.SymbolNormal = 61555;
            this.input_date.TabIndex = 68;
            this.input_date.Text = "2021-07-28 14:19:16";
            this.input_date.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.input_date.Value = new System.DateTime(2021, 7, 28, 14, 19, 16, 880);
            // 
            // text5
            // 
            this.text5.BackColor = System.Drawing.Color.Transparent;
            this.text5.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text5.ForeColor = System.Drawing.Color.Black;
            this.text5.Location = new System.Drawing.Point(141, 380);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(164, 23);
            this.text5.Style = Sunny.UI.UIStyle.Custom;
            this.text5.TabIndex = 69;
            this.text5.Text = "※ gender";
            this.text5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_gender_male
            // 
            this.input_gender_male.BackColor = System.Drawing.Color.Transparent;
            this.input_gender_male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.input_gender_male.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_gender_male.ForeColor = System.Drawing.Color.Black;
            this.input_gender_male.Location = new System.Drawing.Point(358, 380);
            this.input_gender_male.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_gender_male.Name = "input_gender_male";
            this.input_gender_male.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.input_gender_male.RadioButtonColor = System.Drawing.Color.Black;
            this.input_gender_male.Size = new System.Drawing.Size(75, 29);
            this.input_gender_male.Style = Sunny.UI.UIStyle.Custom;
            this.input_gender_male.TabIndex = 70;
            this.input_gender_male.Text = "Male";
            // 
            // input_gender_female
            // 
            this.input_gender_female.BackColor = System.Drawing.Color.Transparent;
            this.input_gender_female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.input_gender_female.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_gender_female.ForeColor = System.Drawing.Color.Black;
            this.input_gender_female.Location = new System.Drawing.Point(457, 380);
            this.input_gender_female.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_gender_female.Name = "input_gender_female";
            this.input_gender_female.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.input_gender_female.RadioButtonColor = System.Drawing.Color.Black;
            this.input_gender_female.Size = new System.Drawing.Size(86, 29);
            this.input_gender_female.Style = Sunny.UI.UIStyle.Custom;
            this.input_gender_female.TabIndex = 71;
            this.input_gender_female.Text = "Female";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.Location = new System.Drawing.Point(146, 513);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(198, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 72;
            this.uiLabel1.Text = "※ Subscription Path";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_check_ad
            // 
            this.but_check_ad.BackColor = System.Drawing.Color.Transparent;
            this.but_check_ad.CheckBoxColor = System.Drawing.Color.Black;
            this.but_check_ad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_check_ad.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_check_ad.ForeColor = System.Drawing.Color.Black;
            this.but_check_ad.Location = new System.Drawing.Point(364, 507);
            this.but_check_ad.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_check_ad.Name = "but_check_ad";
            this.but_check_ad.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.but_check_ad.Size = new System.Drawing.Size(60, 29);
            this.but_check_ad.Style = Sunny.UI.UIStyle.Custom;
            this.but_check_ad.TabIndex = 73;
            this.but_check_ad.Text = "Ad";
            // 
            // but_introduced
            // 
            this.but_introduced.BackColor = System.Drawing.Color.Transparent;
            this.but_introduced.CheckBoxColor = System.Drawing.Color.Black;
            this.but_introduced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_introduced.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_introduced.ForeColor = System.Drawing.Color.Black;
            this.but_introduced.Location = new System.Drawing.Point(461, 507);
            this.but_introduced.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_introduced.Name = "but_introduced";
            this.but_introduced.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.but_introduced.Size = new System.Drawing.Size(119, 29);
            this.but_introduced.Style = Sunny.UI.UIStyle.Custom;
            this.but_introduced.TabIndex = 74;
            this.but_introduced.Text = "Introduced";
            // 
            // uiCheckBox2
            // 
            this.uiCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBox2.CheckBoxColor = System.Drawing.Color.Black;
            this.uiCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiCheckBox2.ForeColor = System.Drawing.Color.Black;
            this.uiCheckBox2.Location = new System.Drawing.Point(364, 563);
            this.uiCheckBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox2.Name = "uiCheckBox2";
            this.uiCheckBox2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox2.Size = new System.Drawing.Size(91, 29);
            this.uiCheckBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox2.TabIndex = 75;
            this.uiCheckBox2.Text = "Internet";
            // 
            // uiCheckBox3
            // 
            this.uiCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBox3.CheckBoxColor = System.Drawing.Color.Black;
            this.uiCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiCheckBox3.ForeColor = System.Drawing.Color.Black;
            this.uiCheckBox3.Location = new System.Drawing.Point(461, 563);
            this.uiCheckBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox3.Name = "uiCheckBox3";
            this.uiCheckBox3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox3.Size = new System.Drawing.Size(138, 29);
            this.uiCheckBox3.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox3.TabIndex = 76;
            this.uiCheckBox3.Text = "Activity Club";
            // 
            // line1
            // 
            this.line1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.line1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.line1.LineColor = System.Drawing.Color.Black;
            this.line1.Location = new System.Drawing.Point(12, 424);
            this.line1.MinimumSize = new System.Drawing.Size(2, 2);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(646, 3);
            this.line1.Style = Sunny.UI.UIStyle.Custom;
            this.line1.TabIndex = 77;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(27, 77);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(68, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(116, 142);
            this.uiSymbolLabel2.Symbol = 61564;
            this.uiSymbolLabel2.SymbolSize = 64;
            this.uiSymbolLabel2.TabIndex = 78;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("양재벨라체M", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(22, 222);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(121, 23);
            this.uiLabel2.TabIndex = 79;
            this.uiLabel2.Text = "Upload picture";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("양재벨라체M", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel7.ForeColor = System.Drawing.Color.White;
            this.uiLabel7.Location = new System.Drawing.Point(160, 77);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(433, 33);
            this.uiLabel7.TabIndex = 80;
            this.uiLabel7.Text = "Input personal information";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text6
            // 
            this.text6.BackColor = System.Drawing.Color.Transparent;
            this.text6.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text6.ForeColor = System.Drawing.Color.Black;
            this.text6.Location = new System.Drawing.Point(96, 453);
            this.text6.Name = "text6";
            this.text6.Size = new System.Drawing.Size(198, 23);
            this.text6.Style = Sunny.UI.UIStyle.Custom;
            this.text6.TabIndex = 81;
            this.text6.Text = "※ Birth";
            this.text6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_year
            // 
            this.input_year.DataSource = null;
            this.input_year.FillColor = System.Drawing.Color.White;
            this.input_year.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_year.Items.AddRange(new object[] {
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.input_year.Location = new System.Drawing.Point(260, 453);
            this.input_year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_year.MinimumSize = new System.Drawing.Size(63, 0);
            this.input_year.Name = "input_year";
            this.input_year.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.input_year.RectColor = System.Drawing.Color.Transparent;
            this.input_year.Size = new System.Drawing.Size(96, 29);
            this.input_year.Style = Sunny.UI.UIStyle.Custom;
            this.input_year.TabIndex = 82;
            this.input_year.Text = "Year";
            this.input_year.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.DropDownWidth = 12;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox1.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.uiComboBox1.Location = new System.Drawing.Point(371, 453);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.RectColor = System.Drawing.Color.Transparent;
            this.uiComboBox1.Size = new System.Drawing.Size(96, 29);
            this.uiComboBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiComboBox1.TabIndex = 83;
            this.uiComboBox1.Text = "Month";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.DataSource = null;
            this.uiComboBox2.DropDownWidth = 31;
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.uiComboBox2.Location = new System.Drawing.Point(497, 453);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox2.RectColor = System.Drawing.Color.Transparent;
            this.uiComboBox2.Size = new System.Drawing.Size(96, 29);
            this.uiComboBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiComboBox2.TabIndex = 84;
            this.uiComboBox2.Text = "Day";
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Add_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 673);
            this.ControlBox = false;
            this.Controls.Add(this.uiComboBox2);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.input_year);
            this.Controls.Add(this.text6);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.uiCheckBox3);
            this.Controls.Add(this.uiCheckBox2);
            this.Controls.Add(this.but_introduced);
            this.Controls.Add(this.but_check_ad);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.input_gender_female);
            this.Controls.Add(this.input_gender_male);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.input_date);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.input_address);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.input_digit);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.but_temp_store);
            this.Controls.Add(this.but_submit);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.title);
            this.Name = "Add_customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Add_customer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel title;
        private Sunny.UI.UISymbolButton but_back;
        private Sunny.UI.UISymbolButton but_submit;
        private Sunny.UI.UISymbolButton but_temp_store;
        private Sunny.UI.UILabel text1;
        private Sunny.UI.UITextBox input_name;
        private Sunny.UI.UITextBox input_digit;
        private Sunny.UI.UILabel text2;
        private Sunny.UI.UITextBox input_address;
        private Sunny.UI.UILabel text3;
        private Sunny.UI.UILabel text4;
        private Sunny.UI.UIDatetimePicker input_date;
        private Sunny.UI.UILabel text5;
        private Sunny.UI.UIRadioButton input_gender_male;
        private Sunny.UI.UIRadioButton input_gender_female;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UICheckBox but_check_ad;
        private Sunny.UI.UICheckBox but_introduced;
        private Sunny.UI.UICheckBox uiCheckBox2;
        private Sunny.UI.UICheckBox uiCheckBox3;
        private Sunny.UI.UILine line1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel text6;
        private Sunny.UI.UIComboBox input_year;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIComboBox uiComboBox2;
    }
}