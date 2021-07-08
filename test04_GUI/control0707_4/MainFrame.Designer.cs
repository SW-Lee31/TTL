
namespace control0707_4
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
            this.esse_golden = new System.Windows.Forms.Button();
            this.esse_special = new System.Windows.Forms.Button();
            this.one_blue = new System.Windows.Forms.Button();
            this.one_orange = new System.Windows.Forms.Button();
            this.one_white = new System.Windows.Forms.Button();
            this.remind = new System.Windows.Forms.Label();
            this.amount_output = new System.Windows.Forms.Label();
            this.pay_button = new System.Windows.Forms.Button();
            this.price_input = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.Label();
            this.price_output = new System.Windows.Forms.Label();
            this.result_output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.result_output_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(287, 30);
            this.title.TabIndex = 0;
            this.title.Text = "Cigarette Vending Machine";
            // 
            // esse_golden
            // 
            this.esse_golden.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.esse_golden.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.esse_golden.Location = new System.Drawing.Point(12, 60);
            this.esse_golden.Name = "esse_golden";
            this.esse_golden.Size = new System.Drawing.Size(288, 46);
            this.esse_golden.TabIndex = 1;
            this.esse_golden.Text = "에쎄 골든 리프 : \\6000";
            this.esse_golden.UseVisualStyleBackColor = false;
            this.esse_golden.Click += new System.EventHandler(this.esse_golden_Click);
            // 
            // esse_special
            // 
            this.esse_special.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.esse_special.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.esse_special.Location = new System.Drawing.Point(12, 112);
            this.esse_special.Name = "esse_special";
            this.esse_special.Size = new System.Drawing.Size(288, 46);
            this.esse_special.TabIndex = 2;
            this.esse_special.Text = "에쎄 스페셜 골드 : \\5000";
            this.esse_special.UseVisualStyleBackColor = false;
            this.esse_special.Click += new System.EventHandler(this.esse_special_Click);
            // 
            // one_blue
            // 
            this.one_blue.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.one_blue.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.one_blue.Location = new System.Drawing.Point(12, 164);
            this.one_blue.Name = "one_blue";
            this.one_blue.Size = new System.Drawing.Size(288, 46);
            this.one_blue.TabIndex = 3;
            this.one_blue.Text = "더원 블루 : \\4500";
            this.one_blue.UseVisualStyleBackColor = false;
            this.one_blue.Click += new System.EventHandler(this.one_blue_Click);
            // 
            // one_orange
            // 
            this.one_orange.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.one_orange.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.one_orange.Location = new System.Drawing.Point(12, 216);
            this.one_orange.Name = "one_orange";
            this.one_orange.Size = new System.Drawing.Size(288, 46);
            this.one_orange.TabIndex = 4;
            this.one_orange.Text = "더원 오렌지 : \\4500";
            this.one_orange.UseVisualStyleBackColor = false;
            this.one_orange.Click += new System.EventHandler(this.one_orange_Click);
            // 
            // one_white
            // 
            this.one_white.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.one_white.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.one_white.Location = new System.Drawing.Point(12, 268);
            this.one_white.Name = "one_white";
            this.one_white.Size = new System.Drawing.Size(288, 46);
            this.one_white.TabIndex = 5;
            this.one_white.Text = "더원 화이트 : \\4500";
            this.one_white.UseVisualStyleBackColor = false;
            this.one_white.Click += new System.EventHandler(this.one_white_Click);
            // 
            // remind
            // 
            this.remind.AutoSize = true;
            this.remind.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.remind.Location = new System.Drawing.Point(28, 321);
            this.remind.Name = "remind";
            this.remind.Size = new System.Drawing.Size(0, 21);
            this.remind.TabIndex = 6;
            // 
            // amount_output
            // 
            this.amount_output.AutoSize = true;
            this.amount_output.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.amount_output.Location = new System.Drawing.Point(68, 355);
            this.amount_output.Name = "amount_output";
            this.amount_output.Size = new System.Drawing.Size(0, 21);
            this.amount_output.TabIndex = 7;
            // 
            // pay_button
            // 
            this.pay_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pay_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pay_button.Location = new System.Drawing.Point(201, 487);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(68, 21);
            this.pay_button.TabIndex = 8;
            this.pay_button.Text = "결제";
            this.pay_button.UseVisualStyleBackColor = false;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // price_input
            // 
            this.price_input.Location = new System.Drawing.Point(43, 487);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(147, 21);
            this.price_input.TabIndex = 9;
            this.price_input.TextChanged += new System.EventHandler(this.price_input_TextChanged);
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.text3.Location = new System.Drawing.Point(-7, 440);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(330, 21);
            this.text3.TabIndex = 10;
            this.text3.Text = "###########결제해주세요.###########";
            // 
            // price_output
            // 
            this.price_output.AutoSize = true;
            this.price_output.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price_output.Location = new System.Drawing.Point(143, 397);
            this.price_output.Name = "price_output";
            this.price_output.Size = new System.Drawing.Size(0, 21);
            this.price_output.TabIndex = 11;
            // 
            // result_output
            // 
            this.result_output.AutoSize = true;
            this.result_output.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result_output.Location = new System.Drawing.Point(28, 573);
            this.result_output.Name = "result_output";
            this.result_output.Size = new System.Drawing.Size(0, 21);
            this.result_output.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(28, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "결제금액 : ";
            // 
            // result_output_2
            // 
            this.result_output_2.AutoSize = true;
            this.result_output_2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result_output_2.Location = new System.Drawing.Point(28, 537);
            this.result_output_2.Name = "result_output_2";
            this.result_output_2.Size = new System.Drawing.Size(0, 21);
            this.result_output_2.TabIndex = 14;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 636);
            this.Controls.Add(this.result_output_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_output);
            this.Controls.Add(this.price_output);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.amount_output);
            this.Controls.Add(this.remind);
            this.Controls.Add(this.one_white);
            this.Controls.Add(this.one_orange);
            this.Controls.Add(this.one_blue);
            this.Controls.Add(this.esse_special);
            this.Controls.Add(this.esse_golden);
            this.Controls.Add(this.title);
            this.Name = "MainFrame";
            this.Text = "담배 자판기 V1.0.1";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button esse_golden;
        private System.Windows.Forms.Button esse_special;
        private System.Windows.Forms.Button one_blue;
        private System.Windows.Forms.Button one_orange;
        private System.Windows.Forms.Button one_white;
        private System.Windows.Forms.Label remind;
        private System.Windows.Forms.Label amount_output;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label price_output;
        private System.Windows.Forms.Label result_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result_output_2;
    }
}

