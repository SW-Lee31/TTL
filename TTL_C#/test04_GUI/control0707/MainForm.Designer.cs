
namespace control0707
{
    partial class MainForm
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
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.Label();
            this.text5 = new System.Windows.Forms.Label();
            this.text6 = new System.Windows.Forms.Label();
            this.korean_input = new System.Windows.Forms.TextBox();
            this.english_input = new System.Windows.Forms.TextBox();
            this.math_input = new System.Windows.Forms.TextBox();
            this.society_input = new System.Windows.Forms.TextBox();
            this.science_input = new System.Windows.Forms.TextBox();
            this.text7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.operate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(206, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(355, 40);
            this.title.TabIndex = 0;
            this.title.Text = "성적관리 프로그램 V1.0.1";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text1.Location = new System.Drawing.Point(63, 83);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(202, 21);
            this.text1.TabIndex = 1;
            this.text1.Text = "과목 성적을 입력해주세요.";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.Location = new System.Drawing.Point(75, 122);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(64, 21);
            this.text2.TabIndex = 2;
            this.text2.Text = "○ 국어";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text3.Location = new System.Drawing.Point(75, 181);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(64, 21);
            this.text3.TabIndex = 3;
            this.text3.Text = "○ 영어";
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text4.Location = new System.Drawing.Point(75, 241);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(64, 21);
            this.text4.TabIndex = 4;
            this.text4.Text = "○ 수학";
            // 
            // text5
            // 
            this.text5.AutoSize = true;
            this.text5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text5.Location = new System.Drawing.Point(75, 305);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(64, 21);
            this.text5.TabIndex = 5;
            this.text5.Text = "○ 사회";
            // 
            // text6
            // 
            this.text6.AutoSize = true;
            this.text6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text6.Location = new System.Drawing.Point(75, 371);
            this.text6.Name = "text6";
            this.text6.Size = new System.Drawing.Size(64, 21);
            this.text6.TabIndex = 6;
            this.text6.Text = "○ 과학";
            // 
            // korean_input
            // 
            this.korean_input.Location = new System.Drawing.Point(157, 122);
            this.korean_input.Name = "korean_input";
            this.korean_input.Size = new System.Drawing.Size(60, 21);
            this.korean_input.TabIndex = 7;
            this.korean_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.korean_input.TextChanged += new System.EventHandler(this.korean_input_TextChanged);
            // 
            // english_input
            // 
            this.english_input.Location = new System.Drawing.Point(157, 181);
            this.english_input.Name = "english_input";
            this.english_input.Size = new System.Drawing.Size(60, 21);
            this.english_input.TabIndex = 8;
            this.english_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.english_input.TextChanged += new System.EventHandler(this.english_input_TextChanged);
            // 
            // math_input
            // 
            this.math_input.Location = new System.Drawing.Point(157, 241);
            this.math_input.Name = "math_input";
            this.math_input.Size = new System.Drawing.Size(60, 21);
            this.math_input.TabIndex = 9;
            this.math_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.math_input.TextChanged += new System.EventHandler(this.math_input_TextChanged);
            // 
            // society_input
            // 
            this.society_input.Location = new System.Drawing.Point(157, 305);
            this.society_input.Name = "society_input";
            this.society_input.Size = new System.Drawing.Size(60, 21);
            this.society_input.TabIndex = 10;
            this.society_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.society_input.TextChanged += new System.EventHandler(this.society_input_TextChanged);
            // 
            // science_input
            // 
            this.science_input.Location = new System.Drawing.Point(157, 371);
            this.science_input.Name = "science_input";
            this.science_input.Size = new System.Drawing.Size(60, 21);
            this.science_input.TabIndex = 11;
            this.science_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.science_input.TextChanged += new System.EventHandler(this.science_input_TextChanged);
            // 
            // text7
            // 
            this.text7.AutoSize = true;
            this.text7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text7.Location = new System.Drawing.Point(223, 122);
            this.text7.Name = "text7";
            this.text7.Size = new System.Drawing.Size(26, 21);
            this.text7.TabIndex = 12;
            this.text7.Text = "점";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(223, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "점";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(223, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "점";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(223, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "점";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(223, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "점";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exit_button.Location = new System.Drawing.Point(364, 415);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 17;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // operate
            // 
            this.operate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.operate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.operate.Location = new System.Drawing.Point(312, 204);
            this.operate.Name = "operate";
            this.operate.Size = new System.Drawing.Size(161, 72);
            this.operate.TabIndex = 18;
            this.operate.Text = "평균 및 성적 산출 >>>>>";
            this.operate.UseVisualStyleBackColor = true;
            this.operate.Click += new System.EventHandler(this.operate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(575, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "점수 합산";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(575, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "점수 평균";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(575, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "성적 등급";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(657, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "점";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(657, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "점";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(657, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "입니다.";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sum.Location = new System.Drawing.Point(591, 157);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(55, 30);
            this.sum.TabIndex = 25;
            this.sum.Text = "합산";
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.average.ForeColor = System.Drawing.SystemColors.Highlight;
            this.average.Location = new System.Drawing.Point(590, 255);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(55, 30);
            this.average.TabIndex = 26;
            this.average.Text = "평균";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.level.ForeColor = System.Drawing.SystemColors.Highlight;
            this.level.Location = new System.Drawing.Point(606, 350);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(0, 50);
            this.level.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.level);
            this.Controls.Add(this.average);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.operate);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text7);
            this.Controls.Add(this.science_input);
            this.Controls.Add(this.society_input);
            this.Controls.Add(this.math_input);
            this.Controls.Add(this.english_input);
            this.Controls.Add(this.korean_input);
            this.Controls.Add(this.text6);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "MainForm";
            this.Text = "성적관리 프로그램 V1.0.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.Label text5;
        private System.Windows.Forms.Label text6;
        private System.Windows.Forms.TextBox korean_input;
        private System.Windows.Forms.TextBox english_input;
        private System.Windows.Forms.TextBox math_input;
        private System.Windows.Forms.TextBox society_input;
        private System.Windows.Forms.TextBox science_input;
        private System.Windows.Forms.Label text7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button operate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Label level;
    }
}

