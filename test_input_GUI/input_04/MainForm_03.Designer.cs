
namespace input_04
{
    partial class MainForm_03
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
            this.text01 = new System.Windows.Forms.Label();
            this.korean = new System.Windows.Forms.Label();
            this.english = new System.Windows.Forms.Label();
            this.math = new System.Windows.Forms.Label();
            this.society = new System.Windows.Forms.Label();
            this.science = new System.Windows.Forms.Label();
            this.korean_input = new System.Windows.Forms.TextBox();
            this.english_input = new System.Windows.Forms.TextBox();
            this.math_input = new System.Windows.Forms.TextBox();
            this.society_input = new System.Windows.Forms.TextBox();
            this.science_input = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.sum_botton = new System.Windows.Forms.Button();
            this.sum_text = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.ave_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.Label();
            this.textzz1 = new System.Windows.Forms.Label();
            this.textzz5 = new System.Windows.Forms.Label();
            this.textzz2 = new System.Windows.Forms.Label();
            this.textzz3 = new System.Windows.Forms.Label();
            this.textzz4 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.level_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(119, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(605, 65);
            this.title.TabIndex = 0;
            this.title.Text = "성적 산출 프로그램 V1.0.1";
            // 
            // text01
            // 
            this.text01.AutoSize = true;
            this.text01.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text01.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.text01.Location = new System.Drawing.Point(37, 102);
            this.text01.Name = "text01";
            this.text01.Size = new System.Drawing.Size(203, 19);
            this.text01.TabIndex = 1;
            this.text01.Text = "성적을 입력해주세요.";
            // 
            // korean
            // 
            this.korean.AutoSize = true;
            this.korean.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.korean.Location = new System.Drawing.Point(53, 155);
            this.korean.Name = "korean";
            this.korean.Size = new System.Drawing.Size(96, 21);
            this.korean.TabIndex = 2;
            this.korean.Text = "○ 국어성적";
            // 
            // english
            // 
            this.english.AutoSize = true;
            this.english.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.english.Location = new System.Drawing.Point(53, 199);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(96, 21);
            this.english.TabIndex = 3;
            this.english.Text = "○ 영어성적";
            this.english.Click += new System.EventHandler(this.english_Click);
            // 
            // math
            // 
            this.math.AutoSize = true;
            this.math.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.math.Location = new System.Drawing.Point(53, 242);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(96, 21);
            this.math.TabIndex = 4;
            this.math.Text = "○ 수학성적";
            // 
            // society
            // 
            this.society.AutoSize = true;
            this.society.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.society.Location = new System.Drawing.Point(53, 290);
            this.society.Name = "society";
            this.society.Size = new System.Drawing.Size(96, 21);
            this.society.TabIndex = 5;
            this.society.Text = "○ 사회성적";
            // 
            // science
            // 
            this.science.AutoSize = true;
            this.science.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.science.Location = new System.Drawing.Point(53, 337);
            this.science.Name = "science";
            this.science.Size = new System.Drawing.Size(96, 21);
            this.science.TabIndex = 6;
            this.science.Text = "○ 과학성적";
            // 
            // korean_input
            // 
            this.korean_input.Location = new System.Drawing.Point(153, 155);
            this.korean_input.Name = "korean_input";
            this.korean_input.Size = new System.Drawing.Size(56, 21);
            this.korean_input.TabIndex = 7;
            this.korean_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.korean_input.TextChanged += new System.EventHandler(this.korean_input_TextChanged);
            // 
            // english_input
            // 
            this.english_input.Location = new System.Drawing.Point(153, 199);
            this.english_input.Name = "english_input";
            this.english_input.Size = new System.Drawing.Size(56, 21);
            this.english_input.TabIndex = 8;
            this.english_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.english_input.TextChanged += new System.EventHandler(this.english_input_TextChanged);
            // 
            // math_input
            // 
            this.math_input.Location = new System.Drawing.Point(153, 242);
            this.math_input.Name = "math_input";
            this.math_input.Size = new System.Drawing.Size(56, 21);
            this.math_input.TabIndex = 9;
            this.math_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.math_input.TextChanged += new System.EventHandler(this.math_input_TextChanged);
            // 
            // society_input
            // 
            this.society_input.Location = new System.Drawing.Point(153, 290);
            this.society_input.Name = "society_input";
            this.society_input.Size = new System.Drawing.Size(56, 21);
            this.society_input.TabIndex = 10;
            this.society_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.society_input.TextChanged += new System.EventHandler(this.society_input_TextChanged);
            // 
            // science_input
            // 
            this.science_input.Location = new System.Drawing.Point(153, 341);
            this.science_input.Name = "science_input";
            this.science_input.Size = new System.Drawing.Size(56, 21);
            this.science_input.TabIndex = 11;
            this.science_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.science_input.TextChanged += new System.EventHandler(this.science_input_TextChanged);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.exit.Location = new System.Drawing.Point(331, 415);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 12;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // sum_botton
            // 
            this.sum_botton.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum_botton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sum_botton.Location = new System.Drawing.Point(426, 188);
            this.sum_botton.Name = "sum_botton";
            this.sum_botton.Size = new System.Drawing.Size(102, 36);
            this.sum_botton.TabIndex = 13;
            this.sum_botton.Text = "성적합산";
            this.sum_botton.UseVisualStyleBackColor = true;
            this.sum_botton.Click += new System.EventHandler(this.sum_botton_Click);
            // 
            // sum_text
            // 
            this.sum_text.AutoSize = true;
            this.sum_text.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum_text.Location = new System.Drawing.Point(631, 190);
            this.sum_text.Name = "sum_text";
            this.sum_text.Size = new System.Drawing.Size(125, 32);
            this.sum_text.TabIndex = 14;
            this.sum_text.Text = "점 입니다.";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum.Location = new System.Drawing.Point(552, 186);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(0, 37);
            this.sum.TabIndex = 15;
            // 
            // ave_button
            // 
            this.ave_button.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ave_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ave_button.Location = new System.Drawing.Point(426, 255);
            this.ave_button.Name = "ave_button";
            this.ave_button.Size = new System.Drawing.Size(102, 36);
            this.ave_button.TabIndex = 16;
            this.ave_button.Text = "성적평균";
            this.ave_button.UseVisualStyleBackColor = true;
            this.ave_button.Click += new System.EventHandler(this.ave_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(631, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "점 입니다.";
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.average.Location = new System.Drawing.Point(552, 252);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(0, 37);
            this.average.TabIndex = 18;
            // 
            // textzz1
            // 
            this.textzz1.AutoSize = true;
            this.textzz1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textzz1.Location = new System.Drawing.Point(215, 155);
            this.textzz1.Name = "textzz1";
            this.textzz1.Size = new System.Drawing.Size(26, 21);
            this.textzz1.TabIndex = 19;
            this.textzz1.Text = "점";
            // 
            // textzz5
            // 
            this.textzz5.AutoSize = true;
            this.textzz5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textzz5.Location = new System.Drawing.Point(215, 200);
            this.textzz5.Name = "textzz5";
            this.textzz5.Size = new System.Drawing.Size(26, 21);
            this.textzz5.TabIndex = 20;
            this.textzz5.Text = "점";
            // 
            // textzz2
            // 
            this.textzz2.AutoSize = true;
            this.textzz2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textzz2.Location = new System.Drawing.Point(215, 242);
            this.textzz2.Name = "textzz2";
            this.textzz2.Size = new System.Drawing.Size(26, 21);
            this.textzz2.TabIndex = 21;
            this.textzz2.Text = "점";
            // 
            // textzz3
            // 
            this.textzz3.AutoSize = true;
            this.textzz3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textzz3.Location = new System.Drawing.Point(215, 290);
            this.textzz3.Name = "textzz3";
            this.textzz3.Size = new System.Drawing.Size(26, 21);
            this.textzz3.TabIndex = 22;
            this.textzz3.Text = "점";
            // 
            // textzz4
            // 
            this.textzz4.AutoSize = true;
            this.textzz4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textzz4.Location = new System.Drawing.Point(215, 341);
            this.textzz4.Name = "textzz4";
            this.textzz4.Size = new System.Drawing.Size(26, 21);
            this.textzz4.TabIndex = 23;
            this.textzz4.Text = "점";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.level.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.level.Location = new System.Drawing.Point(421, 329);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(106, 29);
            this.level.TabIndex = 24;
            this.level.Text = "등급 : ";
            // 
            // level_value
            // 
            this.level_value.AutoSize = true;
            this.level_value.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.level_value.ForeColor = System.Drawing.SystemColors.Highlight;
            this.level_value.Location = new System.Drawing.Point(552, 321);
            this.level_value.Name = "level_value";
            this.level_value.Size = new System.Drawing.Size(0, 45);
            this.level_value.TabIndex = 25;
            // 
            // MainForm_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.level_value);
            this.Controls.Add(this.level);
            this.Controls.Add(this.textzz4);
            this.Controls.Add(this.textzz3);
            this.Controls.Add(this.textzz2);
            this.Controls.Add(this.textzz5);
            this.Controls.Add(this.textzz1);
            this.Controls.Add(this.average);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ave_button);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.sum_text);
            this.Controls.Add(this.sum_botton);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.science_input);
            this.Controls.Add(this.society_input);
            this.Controls.Add(this.math_input);
            this.Controls.Add(this.english_input);
            this.Controls.Add(this.korean_input);
            this.Controls.Add(this.science);
            this.Controls.Add(this.society);
            this.Controls.Add(this.math);
            this.Controls.Add(this.english);
            this.Controls.Add(this.korean);
            this.Controls.Add(this.text01);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "MainForm_03";
            this.Text = "성적계산프로그램 V1.0.1";
            this.Load += new System.EventHandler(this.MainForm_03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label text01;
        private System.Windows.Forms.Label korean;
        private System.Windows.Forms.Label english;
        private System.Windows.Forms.Label math;
        private System.Windows.Forms.Label society;
        private System.Windows.Forms.Label science;
        private System.Windows.Forms.TextBox korean_input;
        private System.Windows.Forms.TextBox english_input;
        private System.Windows.Forms.TextBox math_input;
        private System.Windows.Forms.TextBox society_input;
        private System.Windows.Forms.TextBox science_input;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button sum_botton;
        private System.Windows.Forms.Label sum_text;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Button ave_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Label textzz1;
        private System.Windows.Forms.Label textzz5;
        private System.Windows.Forms.Label textzz2;
        private System.Windows.Forms.Label textzz3;
        private System.Windows.Forms.Label textzz4;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label level_value;
    }
}

