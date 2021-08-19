
namespace operator03
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
            this.input_amount = new System.Windows.Forms.TextBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.text02 = new System.Windows.Forms.Label();
            this.text03 = new System.Windows.Forms.Label();
            this.text04 = new System.Windows.Forms.Label();
            this.text05 = new System.Windows.Forms.Label();
            this.text06 = new System.Windows.Forms.Label();
            this.text07 = new System.Windows.Forms.Label();
            this.fivehundred_ouput = new System.Windows.Forms.Label();
            this.hundred_output = new System.Windows.Forms.Label();
            this.fifty_output = new System.Windows.Forms.Label();
            this.ten_output = new System.Windows.Forms.Label();
            this.operate_button = new System.Windows.Forms.Button();
            this.text08 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(190, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(325, 32);
            this.title.TabIndex = 0;
            this.title.Text = "동전 교환기 프로그램 V1.0.1";
            // 
            // text01
            // 
            this.text01.AutoSize = true;
            this.text01.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text01.Location = new System.Drawing.Point(250, 63);
            this.text01.Name = "text01";
            this.text01.Size = new System.Drawing.Size(199, 19);
            this.text01.TabIndex = 1;
            this.text01.Text = "금액을 입력하세요.";
            // 
            // input_amount
            // 
            this.input_amount.Location = new System.Drawing.Point(287, 94);
            this.input_amount.Name = "input_amount";
            this.input_amount.Size = new System.Drawing.Size(100, 21);
            this.input_amount.TabIndex = 2;
            this.input_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_amount.TextChanged += new System.EventHandler(this.input_amount_TextChanged);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit_button.Location = new System.Drawing.Point(302, 415);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // text02
            // 
            this.text02.AutoSize = true;
            this.text02.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text02.Location = new System.Drawing.Point(393, 96);
            this.text02.Name = "text02";
            this.text02.Size = new System.Drawing.Size(30, 19);
            this.text02.TabIndex = 4;
            this.text02.Text = "원";
            // 
            // text03
            // 
            this.text03.AutoSize = true;
            this.text03.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text03.ForeColor = System.Drawing.SystemColors.Highlight;
            this.text03.Location = new System.Drawing.Point(283, 162);
            this.text03.Name = "text03";
            this.text03.Size = new System.Drawing.Size(125, 19);
            this.text03.TabIndex = 5;
            this.text03.Text = "결과입니다.";
            // 
            // text04
            // 
            this.text04.AutoSize = true;
            this.text04.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text04.Location = new System.Drawing.Point(159, 201);
            this.text04.Name = "text04";
            this.text04.Size = new System.Drawing.Size(129, 19);
            this.text04.TabIndex = 6;
            this.text04.Text = "500원 ===> ";
            // 
            // text05
            // 
            this.text05.AutoSize = true;
            this.text05.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text05.Location = new System.Drawing.Point(159, 256);
            this.text05.Name = "text05";
            this.text05.Size = new System.Drawing.Size(129, 19);
            this.text05.TabIndex = 7;
            this.text05.Text = "100원 ===> ";
            // 
            // text06
            // 
            this.text06.AutoSize = true;
            this.text06.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text06.Location = new System.Drawing.Point(170, 313);
            this.text06.Name = "text06";
            this.text06.Size = new System.Drawing.Size(118, 19);
            this.text06.TabIndex = 8;
            this.text06.Text = "50원 ===> ";
            // 
            // text07
            // 
            this.text07.AutoSize = true;
            this.text07.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text07.Location = new System.Drawing.Point(170, 372);
            this.text07.Name = "text07";
            this.text07.Size = new System.Drawing.Size(118, 19);
            this.text07.TabIndex = 9;
            this.text07.Text = "10원 ===> ";
            // 
            // fivehundred_ouput
            // 
            this.fivehundred_ouput.AutoSize = true;
            this.fivehundred_ouput.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fivehundred_ouput.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fivehundred_ouput.Location = new System.Drawing.Point(323, 201);
            this.fivehundred_ouput.Name = "fivehundred_ouput";
            this.fivehundred_ouput.Size = new System.Drawing.Size(0, 21);
            this.fivehundred_ouput.TabIndex = 10;
            // 
            // hundred_output
            // 
            this.hundred_output.AutoSize = true;
            this.hundred_output.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hundred_output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.hundred_output.Location = new System.Drawing.Point(323, 256);
            this.hundred_output.Name = "hundred_output";
            this.hundred_output.Size = new System.Drawing.Size(0, 21);
            this.hundred_output.TabIndex = 11;
            // 
            // fifty_output
            // 
            this.fifty_output.AutoSize = true;
            this.fifty_output.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fifty_output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fifty_output.Location = new System.Drawing.Point(323, 313);
            this.fifty_output.Name = "fifty_output";
            this.fifty_output.Size = new System.Drawing.Size(0, 21);
            this.fifty_output.TabIndex = 12;
            // 
            // ten_output
            // 
            this.ten_output.AutoSize = true;
            this.ten_output.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ten_output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ten_output.Location = new System.Drawing.Point(323, 372);
            this.ten_output.Name = "ten_output";
            this.ten_output.Size = new System.Drawing.Size(0, 21);
            this.ten_output.TabIndex = 13;
            // 
            // operate_button
            // 
            this.operate_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.operate_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.operate_button.Location = new System.Drawing.Point(302, 121);
            this.operate_button.Name = "operate_button";
            this.operate_button.Size = new System.Drawing.Size(75, 34);
            this.operate_button.TabIndex = 14;
            this.operate_button.Text = "Operate";
            this.operate_button.UseVisualStyleBackColor = true;
            this.operate_button.Click += new System.EventHandler(this.operate_button_Click);
            // 
            // text08
            // 
            this.text08.AutoSize = true;
            this.text08.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text08.Location = new System.Drawing.Point(411, 201);
            this.text08.Name = "text08";
            this.text08.Size = new System.Drawing.Size(115, 19);
            this.text08.TabIndex = 15;
            this.text08.Text = "개 입니다.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(411, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "개 입니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(411, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "개 입니다.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(411, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "개 입니다.";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text08);
            this.Controls.Add(this.operate_button);
            this.Controls.Add(this.ten_output);
            this.Controls.Add(this.fifty_output);
            this.Controls.Add(this.hundred_output);
            this.Controls.Add(this.fivehundred_ouput);
            this.Controls.Add(this.text07);
            this.Controls.Add(this.text06);
            this.Controls.Add(this.text05);
            this.Controls.Add(this.text04);
            this.Controls.Add(this.text03);
            this.Controls.Add(this.text02);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.input_amount);
            this.Controls.Add(this.text01);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "MainFrame";
            this.Text = "동전 교환기 프로그램 V1.0.1";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label text01;
        private System.Windows.Forms.TextBox input_amount;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label text02;
        private System.Windows.Forms.Label text03;
        private System.Windows.Forms.Label text04;
        private System.Windows.Forms.Label text05;
        private System.Windows.Forms.Label text06;
        private System.Windows.Forms.Label text07;
        private System.Windows.Forms.Label fivehundred_ouput;
        private System.Windows.Forms.Label hundred_output;
        private System.Windows.Forms.Label fifty_output;
        private System.Windows.Forms.Label ten_output;
        private System.Windows.Forms.Button operate_button;
        private System.Windows.Forms.Label text08;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

