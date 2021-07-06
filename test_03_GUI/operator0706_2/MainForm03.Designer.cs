
namespace operator0706_2
{
    partial class MainForm03
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
            this.num_input = new System.Windows.Forms.TextBox();
            this.num_output = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.num_button = new System.Windows.Forms.Button();
            this.text02 = new System.Windows.Forms.Label();
            this.greatest_1 = new System.Windows.Forms.TextBox();
            this.greatest_2 = new System.Windows.Forms.TextBox();
            this.greatest_button = new System.Windows.Forms.Button();
            this.greatest_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(191, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(309, 30);
            this.title.TabIndex = 0;
            this.title.Text = "Operator 활용 프로그램 V1.0.1";
            // 
            // text01
            // 
            this.text01.AutoSize = true;
            this.text01.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text01.Location = new System.Drawing.Point(193, 55);
            this.text01.Name = "text01";
            this.text01.Size = new System.Drawing.Size(321, 15);
            this.text01.TabIndex = 1;
            this.text01.Text = "홀, 짝수 구분을 원하는 값을 입력해주세요.";
            // 
            // num_input
            // 
            this.num_input.Location = new System.Drawing.Point(286, 82);
            this.num_input.Name = "num_input";
            this.num_input.Size = new System.Drawing.Size(100, 21);
            this.num_input.TabIndex = 2;
            this.num_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_output
            // 
            this.num_output.AutoSize = true;
            this.num_output.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num_output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.num_output.Location = new System.Drawing.Point(287, 161);
            this.num_output.Name = "num_output";
            this.num_output.Size = new System.Drawing.Size(0, 19);
            this.num_output.TabIndex = 3;
            this.num_output.Click += new System.EventHandler(this.num_output_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_button.Location = new System.Drawing.Point(311, 415);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // num_button
            // 
            this.num_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num_button.Location = new System.Drawing.Point(299, 119);
            this.num_button.Name = "num_button";
            this.num_button.Size = new System.Drawing.Size(75, 23);
            this.num_button.TabIndex = 5;
            this.num_button.Text = "홀/짝";
            this.num_button.UseVisualStyleBackColor = true;
            this.num_button.Click += new System.EventHandler(this.num_button_Click);
            // 
            // text02
            // 
            this.text02.AutoSize = true;
            this.text02.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text02.Location = new System.Drawing.Point(176, 237);
            this.text02.Name = "text02";
            this.text02.Size = new System.Drawing.Size(354, 15);
            this.text02.TabIndex = 6;
            this.text02.Text = "최대, 최소값을 원하는 값(2개)를 입력해주세요.";
            // 
            // greatest_1
            // 
            this.greatest_1.Location = new System.Drawing.Point(224, 270);
            this.greatest_1.Name = "greatest_1";
            this.greatest_1.Size = new System.Drawing.Size(100, 21);
            this.greatest_1.TabIndex = 7;
            this.greatest_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.greatest_1.TextChanged += new System.EventHandler(this.greatest_1_TextChanged);
            // 
            // greatest_2
            // 
            this.greatest_2.Location = new System.Drawing.Point(373, 270);
            this.greatest_2.Name = "greatest_2";
            this.greatest_2.Size = new System.Drawing.Size(100, 21);
            this.greatest_2.TabIndex = 8;
            this.greatest_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // greatest_button
            // 
            this.greatest_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.greatest_button.Location = new System.Drawing.Point(254, 306);
            this.greatest_button.Name = "greatest_button";
            this.greatest_button.Size = new System.Drawing.Size(190, 23);
            this.greatest_button.TabIndex = 9;
            this.greatest_button.Text = "최대값, 최솟값 산출";
            this.greatest_button.UseVisualStyleBackColor = true;
            this.greatest_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // greatest_output
            // 
            this.greatest_output.AutoSize = true;
            this.greatest_output.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.greatest_output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.greatest_output.Location = new System.Drawing.Point(338, 274);
            this.greatest_output.Name = "greatest_output";
            this.greatest_output.Size = new System.Drawing.Size(0, 19);
            this.greatest_output.TabIndex = 10;
            // 
            // MainForm03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greatest_output);
            this.Controls.Add(this.greatest_button);
            this.Controls.Add(this.greatest_2);
            this.Controls.Add(this.greatest_1);
            this.Controls.Add(this.text02);
            this.Controls.Add(this.num_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.num_output);
            this.Controls.Add(this.num_input);
            this.Controls.Add(this.text01);
            this.Controls.Add(this.title);
            this.Name = "MainForm03";
            this.Text = "Operator using v1.0.1";
            this.Load += new System.EventHandler(this.MainForm03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label text01;
        private System.Windows.Forms.TextBox num_input;
        private System.Windows.Forms.Label num_output;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button num_button;
        private System.Windows.Forms.Label text02;
        private System.Windows.Forms.TextBox greatest_1;
        private System.Windows.Forms.TextBox greatest_2;
        private System.Windows.Forms.Button greatest_button;
        private System.Windows.Forms.Label greatest_output;
    }
}

