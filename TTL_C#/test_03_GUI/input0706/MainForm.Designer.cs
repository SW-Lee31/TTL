
namespace input0706
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
            this.text02 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.sum_button = new System.Windows.Forms.Button();
            this.average_button = new System.Windows.Forms.Button();
            this.sum_output = new System.Windows.Forms.Label();
            this.average_output = new System.Windows.Forms.Label();
            this.text10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text12 = new System.Windows.Forms.Label();
            this.level_output = new System.Windows.Forms.Label();
            this.text13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(142, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(452, 40);
            this.title.TabIndex = 0;
            this.title.Text = "성적입력 및 출력프로그램 V1.0.1";
            // 
            // text01
            // 
            this.text01.AutoSize = true;
            this.text01.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text01.Location = new System.Drawing.Point(28, 99);
            this.text01.Name = "text01";
            this.text01.Size = new System.Drawing.Size(202, 21);
            this.text01.TabIndex = 1;
            this.text01.Text = "※ 성적을 입력해주세요. ※";
            // 
            // korean
            // 
            this.korean.AutoSize = true;
            this.korean.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.korean.Location = new System.Drawing.Point(38, 138);
            this.korean.Name = "korean";
            this.korean.Size = new System.Drawing.Size(94, 20);
            this.korean.TabIndex = 2;
            this.korean.Text = "○ 국어 성적";
            // 
            // english
            // 
            this.english.AutoSize = true;
            this.english.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.english.Location = new System.Drawing.Point(38, 190);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(94, 20);
            this.english.TabIndex = 7;
            this.english.Text = "○ 영어 성적";
            // 
            // math
            // 
            this.math.AutoSize = true;
            this.math.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.math.Location = new System.Drawing.Point(38, 247);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(94, 20);
            this.math.TabIndex = 8;
            this.math.Text = "○ 수학 성적";
            // 
            // society
            // 
            this.society.AutoSize = true;
            this.society.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.society.Location = new System.Drawing.Point(38, 309);
            this.society.Name = "society";
            this.society.Size = new System.Drawing.Size(94, 20);
            this.society.TabIndex = 9;
            this.society.Text = "○ 사회 성적";
            // 
            // science
            // 
            this.science.AutoSize = true;
            this.science.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.science.Location = new System.Drawing.Point(38, 371);
            this.science.Name = "science";
            this.science.Size = new System.Drawing.Size(94, 20);
            this.science.TabIndex = 10;
            this.science.Text = "○ 과학 성적";
            // 
            // korean_input
            // 
            this.korean_input.Location = new System.Drawing.Point(138, 138);
            this.korean_input.Name = "korean_input";
            this.korean_input.Size = new System.Drawing.Size(50, 21);
            this.korean_input.TabIndex = 11;
            this.korean_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.korean_input.TextChanged += new System.EventHandler(this.korean_input_TextChanged);
            // 
            // english_input
            // 
            this.english_input.Location = new System.Drawing.Point(138, 189);
            this.english_input.Name = "english_input";
            this.english_input.Size = new System.Drawing.Size(50, 21);
            this.english_input.TabIndex = 12;
            this.english_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.english_input.TextChanged += new System.EventHandler(this.english_input_TextChanged);
            // 
            // math_input
            // 
            this.math_input.Location = new System.Drawing.Point(138, 247);
            this.math_input.Name = "math_input";
            this.math_input.Size = new System.Drawing.Size(50, 21);
            this.math_input.TabIndex = 13;
            this.math_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.math_input.TextChanged += new System.EventHandler(this.math_input_TextChanged);
            // 
            // society_input
            // 
            this.society_input.Location = new System.Drawing.Point(138, 309);
            this.society_input.Name = "society_input";
            this.society_input.Size = new System.Drawing.Size(50, 21);
            this.society_input.TabIndex = 14;
            this.society_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.society_input.TextChanged += new System.EventHandler(this.society_input_TextChanged);
            // 
            // science_input
            // 
            this.science_input.Location = new System.Drawing.Point(138, 371);
            this.science_input.Name = "science_input";
            this.science_input.Size = new System.Drawing.Size(50, 21);
            this.science_input.TabIndex = 15;
            this.science_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.science_input.TextChanged += new System.EventHandler(this.science_input_TextChanged);
            // 
            // text02
            // 
            this.text02.AutoSize = true;
            this.text02.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text02.Location = new System.Drawing.Point(194, 139);
            this.text02.Name = "text02";
            this.text02.Size = new System.Drawing.Size(24, 20);
            this.text02.TabIndex = 16;
            this.text02.Text = "점";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(194, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "점";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(194, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "점";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(194, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "점";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(194, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "점";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exit_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exit_button.Location = new System.Drawing.Point(313, 415);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 21;
            this.exit_button.Text = "종료";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // sum_button
            // 
            this.sum_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sum_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sum_button.Location = new System.Drawing.Point(343, 150);
            this.sum_button.Name = "sum_button";
            this.sum_button.Size = new System.Drawing.Size(87, 45);
            this.sum_button.TabIndex = 22;
            this.sum_button.Text = "합산 산출";
            this.sum_button.UseVisualStyleBackColor = false;
            this.sum_button.Click += new System.EventHandler(this.sum_button_Click);
            // 
            // average_button
            // 
            this.average_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.average_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.average_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.average_button.Location = new System.Drawing.Point(343, 233);
            this.average_button.Name = "average_button";
            this.average_button.Size = new System.Drawing.Size(87, 45);
            this.average_button.TabIndex = 23;
            this.average_button.Text = "평균 산출";
            this.average_button.UseVisualStyleBackColor = false;
            this.average_button.Click += new System.EventHandler(this.average_button_Click);
            // 
            // sum_output
            // 
            this.sum_output.AutoSize = true;
            this.sum_output.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum_output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sum_output.Location = new System.Drawing.Point(448, 160);
            this.sum_output.Name = "sum_output";
            this.sum_output.Size = new System.Drawing.Size(0, 20);
            this.sum_output.TabIndex = 24;
            // 
            // average_output
            // 
            this.average_output.AutoSize = true;
            this.average_output.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.average_output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.average_output.Location = new System.Drawing.Point(452, 243);
            this.average_output.Name = "average_output";
            this.average_output.Size = new System.Drawing.Size(0, 20);
            this.average_output.TabIndex = 25;
            // 
            // text10
            // 
            this.text10.AutoSize = true;
            this.text10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.text10.Location = new System.Drawing.Point(502, 161);
            this.text10.Name = "text10";
            this.text10.Size = new System.Drawing.Size(78, 20);
            this.text10.TabIndex = 26;
            this.text10.Text = "점 입니다.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(502, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "점 입니다.";
            // 
            // text12
            // 
            this.text12.AutoSize = true;
            this.text12.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.text12.Location = new System.Drawing.Point(381, 305);
            this.text12.Name = "text12";
            this.text12.Size = new System.Drawing.Size(188, 21);
            this.text12.TabIndex = 28;
            this.text12.Text = "※ 평균에 따른 등급은 ※";
            // 
            // level_output
            // 
            this.level_output.AutoSize = true;
            this.level_output.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.level_output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.level_output.Location = new System.Drawing.Point(447, 344);
            this.level_output.Name = "level_output";
            this.level_output.Size = new System.Drawing.Size(0, 37);
            this.level_output.TabIndex = 29;
            this.level_output.Click += new System.EventHandler(this.level_output_Click);
            // 
            // text13
            // 
            this.text13.AutoSize = true;
            this.text13.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.text13.Location = new System.Drawing.Point(488, 360);
            this.text13.Name = "text13";
            this.text13.Size = new System.Drawing.Size(62, 21);
            this.text13.TabIndex = 30;
            this.text13.Text = "입니다.";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.text13);
            this.Controls.Add(this.level_output);
            this.Controls.Add(this.text12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text10);
            this.Controls.Add(this.average_output);
            this.Controls.Add(this.sum_output);
            this.Controls.Add(this.average_button);
            this.Controls.Add(this.sum_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text02);
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
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "MainFrame";
            this.Text = "성적입, 출력 프로그램 V1.0.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Label text02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button sum_button;
        private System.Windows.Forms.Button average_button;
        private System.Windows.Forms.Label sum_output;
        private System.Windows.Forms.Label average_output;
        private System.Windows.Forms.Label text10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label text12;
        private System.Windows.Forms.Label level_output;
        private System.Windows.Forms.Label text13;
    }
}

