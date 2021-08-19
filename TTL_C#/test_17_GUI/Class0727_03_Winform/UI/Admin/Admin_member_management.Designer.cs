
namespace Class0727_03_Winform.UI
{
    partial class Admin_member_management
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
            this.output_cusname = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.but_back = new Sunny.UI.UISymbolButton();
            this.title = new Sunny.UI.UISymbolLabel();
            this.output_gender = new Sunny.UI.UILabel();
            this.output_birth = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.output_date = new Sunny.UI.UILabel();
            this.output_digit = new Sunny.UI.UILabel();
            this.text3 = new Sunny.UI.UILabel();
            this.text2 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.input_mem_digit = new System.Windows.Forms.TextBox();
            this.cus_but_submit = new Sunny.UI.UISymbolButton();
            this.confirm = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // output_cusname
            // 
            this.output_cusname.DataSource = null;
            this.output_cusname.FillColor = System.Drawing.Color.White;
            this.output_cusname.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.output_cusname.Items.AddRange(new object[] {
            "Suzuki",
            "Karasaki",
            "Harley"});
            this.output_cusname.Location = new System.Drawing.Point(49, 99);
            this.output_cusname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.output_cusname.MinimumSize = new System.Drawing.Size(63, 0);
            this.output_cusname.Name = "output_cusname";
            this.output_cusname.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.output_cusname.Size = new System.Drawing.Size(249, 29);
            this.output_cusname.TabIndex = 71;
            this.output_cusname.Text = "Choose Customer\'s Name";
            this.output_cusname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.output_cusname.SelectedIndexChanged += new System.EventHandler(this.output_cusname_SelectedIndexChanged);
            this.output_cusname.SelectedValueChanged += new System.EventHandler(this.output_cusname_SelectedValueChanged);
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel5.ForeColor = System.Drawing.Color.Black;
            this.uiLabel5.Location = new System.Drawing.Point(29, 73);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(430, 23);
            this.uiLabel5.TabIndex = 72;
            this.uiLabel5.Text = "Choose Customer who needed to be a Member";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.but_back.Location = new System.Drawing.Point(22, 10);
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
            this.but_back.TabIndex = 77;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("양재벨라체M", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(2, 12);
            this.title.MinimumSize = new System.Drawing.Size(1, 1);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.title.Size = new System.Drawing.Size(493, 44);
            this.title.Style = Sunny.UI.UIStyle.Custom;
            this.title.Symbol = 61980;
            this.title.SymbolColor = System.Drawing.Color.Black;
            this.title.SymbolSize = 45;
            this.title.TabIndex = 76;
            this.title.Text = "THE MOTOR";
            // 
            // output_gender
            // 
            this.output_gender.BackColor = System.Drawing.Color.Transparent;
            this.output_gender.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_gender.ForeColor = System.Drawing.Color.Black;
            this.output_gender.Location = new System.Drawing.Point(214, 274);
            this.output_gender.Name = "output_gender";
            this.output_gender.Size = new System.Drawing.Size(270, 23);
            this.output_gender.TabIndex = 105;
            this.output_gender.Text = "data";
            this.output_gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_birth
            // 
            this.output_birth.BackColor = System.Drawing.Color.Transparent;
            this.output_birth.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_birth.ForeColor = System.Drawing.Color.Black;
            this.output_birth.Location = new System.Drawing.Point(214, 233);
            this.output_birth.Name = "output_birth";
            this.output_birth.Size = new System.Drawing.Size(270, 23);
            this.output_birth.TabIndex = 104;
            this.output_birth.Text = "data";
            this.output_birth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Black;
            this.uiLabel3.Location = new System.Drawing.Point(19, 274);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(164, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 103;
            this.uiLabel3.Text = "※ Gender";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(19, 233);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(164, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 102;
            this.uiLabel2.Text = "※ Birth";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_date
            // 
            this.output_date.BackColor = System.Drawing.Color.Transparent;
            this.output_date.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_date.ForeColor = System.Drawing.Color.Black;
            this.output_date.Location = new System.Drawing.Point(214, 197);
            this.output_date.Name = "output_date";
            this.output_date.Size = new System.Drawing.Size(270, 23);
            this.output_date.TabIndex = 101;
            this.output_date.Text = "data";
            this.output_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_digit
            // 
            this.output_digit.BackColor = System.Drawing.Color.Transparent;
            this.output_digit.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_digit.ForeColor = System.Drawing.Color.Black;
            this.output_digit.Location = new System.Drawing.Point(214, 158);
            this.output_digit.Name = "output_digit";
            this.output_digit.Size = new System.Drawing.Size(270, 23);
            this.output_digit.TabIndex = 100;
            this.output_digit.Text = "data";
            this.output_digit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text3
            // 
            this.text3.BackColor = System.Drawing.Color.Transparent;
            this.text3.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text3.ForeColor = System.Drawing.Color.Black;
            this.text3.Location = new System.Drawing.Point(-3, 197);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(211, 23);
            this.text3.Style = Sunny.UI.UIStyle.Custom;
            this.text3.TabIndex = 98;
            this.text3.Text = "※ Subsciription Date";
            this.text3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.Transparent;
            this.text2.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.ForeColor = System.Drawing.Color.Black;
            this.text2.Location = new System.Drawing.Point(19, 158);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(164, 23);
            this.text2.Style = Sunny.UI.UIStyle.Custom;
            this.text2.TabIndex = 97;
            this.text2.Text = "※ Digit";
            this.text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel4.ForeColor = System.Drawing.Color.Black;
            this.uiLabel4.Location = new System.Drawing.Point(29, 338);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(430, 23);
            this.uiLabel4.TabIndex = 106;
            this.uiLabel4.Text = "Input Memeber\'s ID Digit";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel4.Click += new System.EventHandler(this.uiLabel4_Click);
            // 
            // input_mem_digit
            // 
            this.input_mem_digit.Location = new System.Drawing.Point(183, 364);
            this.input_mem_digit.Name = "input_mem_digit";
            this.input_mem_digit.Size = new System.Drawing.Size(136, 21);
            this.input_mem_digit.TabIndex = 107;
            this.input_mem_digit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.cus_but_submit.Location = new System.Drawing.Point(159, 391);
            this.cus_but_submit.MinimumSize = new System.Drawing.Size(1, 1);
            this.cus_but_submit.Name = "cus_but_submit";
            this.cus_but_submit.RectColor = System.Drawing.Color.Transparent;
            this.cus_but_submit.RectDisableColor = System.Drawing.Color.Transparent;
            this.cus_but_submit.RectHoverColor = System.Drawing.Color.Transparent;
            this.cus_but_submit.RectPressColor = System.Drawing.Color.Transparent;
            this.cus_but_submit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.cus_but_submit.Size = new System.Drawing.Size(186, 47);
            this.cus_but_submit.Style = Sunny.UI.UIStyle.Custom;
            this.cus_but_submit.StyleCustomMode = true;
            this.cus_but_submit.TabIndex = 108;
            this.cus_but_submit.Text = "Submit";
            this.cus_but_submit.Click += new System.EventHandler(this.cus_but_submit_Click);
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
            this.confirm.Location = new System.Drawing.Point(322, 99);
            this.confirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.confirm.Name = "confirm";
            this.confirm.RectColor = System.Drawing.Color.Transparent;
            this.confirm.RectDisableColor = System.Drawing.Color.Transparent;
            this.confirm.RectHoverColor = System.Drawing.Color.Transparent;
            this.confirm.RectPressColor = System.Drawing.Color.Transparent;
            this.confirm.RectSelectedColor = System.Drawing.Color.Transparent;
            this.confirm.Size = new System.Drawing.Size(106, 29);
            this.confirm.Style = Sunny.UI.UIStyle.Custom;
            this.confirm.StyleCustomMode = true;
            this.confirm.TabIndex = 109;
            this.confirm.Text = "Confirm";
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Admin_member_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.ControlBox = false;
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.cus_but_submit);
            this.Controls.Add(this.input_mem_digit);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.output_gender);
            this.Controls.Add(this.output_birth);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.output_date);
            this.Controls.Add(this.output_digit);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.title);
            this.Controls.Add(this.output_cusname);
            this.Controls.Add(this.uiLabel5);
            this.Name = "Admin_member_management";
            this.Load += new System.EventHandler(this.Admin_member_management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIComboBox output_cusname;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UISymbolButton but_back;
        private Sunny.UI.UISymbolLabel title;
        private Sunny.UI.UILabel output_gender;
        private Sunny.UI.UILabel output_birth;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel output_date;
        private Sunny.UI.UILabel output_digit;
        private Sunny.UI.UILabel text3;
        private Sunny.UI.UILabel text2;
        private Sunny.UI.UILabel uiLabel4;
        private System.Windows.Forms.TextBox input_mem_digit;
        private Sunny.UI.UISymbolButton cus_but_submit;
        private Sunny.UI.UISymbolButton confirm;
    }
}