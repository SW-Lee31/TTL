
namespace Loop0708_2
{
    partial class MainFrame
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
            this.title = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kimchi_button = new System.Windows.Forms.Button();
            this.soy_button = new System.Windows.Forms.Button();
            this.knife_button = new System.Windows.Forms.Button();
            this.fest_button = new System.Windows.Forms.Button();
            this.bibim_button = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.menu_output = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.price_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.warn = new System.Windows.Forms.Label();
            this.kimchi_num = new System.Windows.Forms.Label();
            this.soy_num = new System.Windows.Forms.Label();
            this.knife_num = new System.Windows.Forms.Label();
            this.fest_num = new System.Windows.Forms.Label();
            this.rice_num = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.payprice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(228, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(330, 32);
            this.title.TabIndex = 0;
            this.title.Text = "Food Order Program V1.0.1";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Loop0708_2.Properties.Resources.bibimbop;
            this.pictureBox5.Location = new System.Drawing.Point(655, 98);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(129, 121);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Loop0708_2.Properties.Resources.festival_noodle;
            this.pictureBox4.Location = new System.Drawing.Point(493, 98);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(129, 121);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Loop0708_2.Properties.Resources.knife_noodle;
            this.pictureBox3.Location = new System.Drawing.Point(333, 98);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Loop0708_2.Properties.Resources.soybean_soup;
            this.pictureBox2.Location = new System.Drawing.Point(171, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Loop0708_2.Properties.Resources.kimchi_soup;
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kimchi_button
            // 
            this.kimchi_button.Location = new System.Drawing.Point(12, 225);
            this.kimchi_button.Name = "kimchi_button";
            this.kimchi_button.Size = new System.Drawing.Size(129, 32);
            this.kimchi_button.TabIndex = 6;
            this.kimchi_button.Text = "김치찌개 5000원";
            this.kimchi_button.UseVisualStyleBackColor = true;
            this.kimchi_button.Click += new System.EventHandler(this.kimchi_button_Click);
            // 
            // soy_button
            // 
            this.soy_button.Location = new System.Drawing.Point(173, 225);
            this.soy_button.Name = "soy_button";
            this.soy_button.Size = new System.Drawing.Size(129, 32);
            this.soy_button.TabIndex = 7;
            this.soy_button.Text = "된장찌개 5000원";
            this.soy_button.UseVisualStyleBackColor = true;
            this.soy_button.Click += new System.EventHandler(this.kimchi_button_Click);
            // 
            // knife_button
            // 
            this.knife_button.Location = new System.Drawing.Point(334, 225);
            this.knife_button.Name = "knife_button";
            this.knife_button.Size = new System.Drawing.Size(129, 32);
            this.knife_button.TabIndex = 8;
            this.knife_button.Text = "칼국수 4500원";
            this.knife_button.UseVisualStyleBackColor = true;
            this.knife_button.Click += new System.EventHandler(this.kimchi_button_Click);
            // 
            // fest_button
            // 
            this.fest_button.Location = new System.Drawing.Point(493, 225);
            this.fest_button.Name = "fest_button";
            this.fest_button.Size = new System.Drawing.Size(129, 32);
            this.fest_button.TabIndex = 9;
            this.fest_button.Text = "잔치국수 4000원";
            this.fest_button.UseVisualStyleBackColor = true;
            this.fest_button.Click += new System.EventHandler(this.kimchi_button_Click);
            // 
            // bibim_button
            // 
            this.bibim_button.Location = new System.Drawing.Point(655, 225);
            this.bibim_button.Name = "bibim_button";
            this.bibim_button.Size = new System.Drawing.Size(129, 32);
            this.bibim_button.TabIndex = 10;
            this.bibim_button.Text = "비빔밥 5000원";
            this.bibim_button.UseVisualStyleBackColor = true;
            this.bibim_button.Click += new System.EventHandler(this.kimchi_button_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text1.Location = new System.Drawing.Point(326, 319);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(139, 16);
            this.text1.TabIndex = 11;
            this.text1.Text = "○ 선택하신 메뉴";
            // 
            // menu_output
            // 
            this.menu_output.AutoSize = true;
            this.menu_output.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_output.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_output.Location = new System.Drawing.Point(345, 349);
            this.menu_output.Name = "menu_output";
            this.menu_output.Size = new System.Drawing.Size(0, 24);
            this.menu_output.TabIndex = 12;
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.payment.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.payment.Location = new System.Drawing.Point(341, 441);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(0, 19);
            this.payment.TabIndex = 13;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.Location = new System.Drawing.Point(352, 408);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(65, 16);
            this.text2.TabIndex = 14;
            this.text2.Text = "○ 가격";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text3.Location = new System.Drawing.Point(419, 441);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(29, 19);
            this.text3.TabIndex = 15;
            this.text3.Text = "원";
            // 
            // price_input
            // 
            this.price_input.Location = new System.Drawing.Point(300, 521);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(100, 21);
            this.price_input.TabIndex = 16;
            this.price_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price_input.TextChanged += new System.EventHandler(this.price_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(353, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "○ 결제";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(403, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "원";
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.warn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.warn.Location = new System.Drawing.Point(294, 550);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(0, 16);
            this.warn.TabIndex = 19;
            // 
            // kimchi_num
            // 
            this.kimchi_num.AutoSize = true;
            this.kimchi_num.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kimchi_num.Location = new System.Drawing.Point(58, 269);
            this.kimchi_num.Name = "kimchi_num";
            this.kimchi_num.Size = new System.Drawing.Size(17, 16);
            this.kimchi_num.TabIndex = 20;
            this.kimchi_num.Text = "0";
            // 
            // soy_num
            // 
            this.soy_num.AutoSize = true;
            this.soy_num.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.soy_num.Location = new System.Drawing.Point(216, 268);
            this.soy_num.Name = "soy_num";
            this.soy_num.Size = new System.Drawing.Size(17, 16);
            this.soy_num.TabIndex = 21;
            this.soy_num.Text = "0";
            // 
            // knife_num
            // 
            this.knife_num.AutoSize = true;
            this.knife_num.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.knife_num.Location = new System.Drawing.Point(375, 268);
            this.knife_num.Name = "knife_num";
            this.knife_num.Size = new System.Drawing.Size(17, 16);
            this.knife_num.TabIndex = 22;
            this.knife_num.Text = "0";
            // 
            // fest_num
            // 
            this.fest_num.AutoSize = true;
            this.fest_num.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fest_num.Location = new System.Drawing.Point(535, 270);
            this.fest_num.Name = "fest_num";
            this.fest_num.Size = new System.Drawing.Size(17, 16);
            this.fest_num.TabIndex = 23;
            this.fest_num.Text = "0";
            // 
            // rice_num
            // 
            this.rice_num.AutoSize = true;
            this.rice_num.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rice_num.Location = new System.Drawing.Point(693, 269);
            this.rice_num.Name = "rice_num";
            this.rice_num.Size = new System.Drawing.Size(17, 16);
            this.rice_num.TabIndex = 24;
            this.rice_num.Tag = "";
            this.rice_num.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(93, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "개";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(251, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "개";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(410, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "개";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(570, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "개";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(728, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "개";
            // 
            // payprice
            // 
            this.payprice.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.payprice.Location = new System.Drawing.Point(433, 522);
            this.payprice.Name = "payprice";
            this.payprice.Size = new System.Drawing.Size(54, 23);
            this.payprice.TabIndex = 30;
            this.payprice.Text = "결제";
            this.payprice.UseVisualStyleBackColor = true;
            this.payprice.Click += new System.EventHandler(this.payprice_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.payprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rice_num);
            this.Controls.Add(this.fest_num);
            this.Controls.Add(this.knife_num);
            this.Controls.Add(this.soy_num);
            this.Controls.Add(this.kimchi_num);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.menu_output);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.bibim_button);
            this.Controls.Add(this.fest_button);
            this.Controls.Add(this.knife_button);
            this.Controls.Add(this.soy_button);
            this.Controls.Add(this.kimchi_button);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Name = "MainFrame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button kimchi_button;
        private System.Windows.Forms.Button soy_button;
        private System.Windows.Forms.Button knife_button;
        private System.Windows.Forms.Button fest_button;
        private System.Windows.Forms.Button bibim_button;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label menu_output;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.Label kimchi_num;
        private System.Windows.Forms.Label soy_num;
        private System.Windows.Forms.Label knife_num;
        private System.Windows.Forms.Label fest_num;
        private System.Windows.Forms.Label rice_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button payprice;
    }
}

