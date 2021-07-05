
namespace input_03
{
    partial class MainForm_02
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
            this.t_temp = new System.Windows.Forms.Label();
            this.c_temp = new System.Windows.Forms.Label();
            this.t_temp_input = new System.Windows.Forms.TextBox();
            this.c_temp_input = new System.Windows.Forms.TextBox();
            this.t_temp_to_c_temp = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.c_temp_to_t_temp = new System.Windows.Forms.Button();
            this.c_temp_value = new System.Windows.Forms.Label();
            this.t_temp_value = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(233, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(331, 50);
            this.title.TabIndex = 0;
            this.title.Text = "온도치환 프로그램";
            // 
            // t_temp
            // 
            this.t_temp.AutoSize = true;
            this.t_temp.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t_temp.Location = new System.Drawing.Point(37, 100);
            this.t_temp.Name = "t_temp";
            this.t_temp.Size = new System.Drawing.Size(230, 30);
            this.t_temp.TabIndex = 2;
            this.t_temp.Text = "화씨온도를 입력하세요";
            // 
            // c_temp
            // 
            this.c_temp.AutoSize = true;
            this.c_temp.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c_temp.Location = new System.Drawing.Point(37, 270);
            this.c_temp.Name = "c_temp";
            this.c_temp.Size = new System.Drawing.Size(230, 30);
            this.c_temp.TabIndex = 3;
            this.c_temp.Text = "섭씨온도를 입력하세요";
            // 
            // t_temp_input
            // 
            this.t_temp_input.Location = new System.Drawing.Point(86, 143);
            this.t_temp_input.Name = "t_temp_input";
            this.t_temp_input.Size = new System.Drawing.Size(100, 21);
            this.t_temp_input.TabIndex = 4;
            this.t_temp_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c_temp_input
            // 
            this.c_temp_input.Location = new System.Drawing.Point(86, 313);
            this.c_temp_input.Name = "c_temp_input";
            this.c_temp_input.Size = new System.Drawing.Size(100, 21);
            this.c_temp_input.TabIndex = 5;
            this.c_temp_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t_temp_to_c_temp
            // 
            this.t_temp_to_c_temp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t_temp_to_c_temp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.t_temp_to_c_temp.Location = new System.Drawing.Point(85, 179);
            this.t_temp_to_c_temp.Name = "t_temp_to_c_temp";
            this.t_temp_to_c_temp.Size = new System.Drawing.Size(251, 23);
            this.t_temp_to_c_temp.TabIndex = 6;
            this.t_temp_to_c_temp.Text = "섭씨 온도로 전환 ----->";
            this.t_temp_to_c_temp.UseVisualStyleBackColor = true;
            this.t_temp_to_c_temp.Click += new System.EventHandler(this.t_temp_to_c_temp_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Location = new System.Drawing.Point(355, 405);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 33);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // c_temp_to_t_temp
            // 
            this.c_temp_to_t_temp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c_temp_to_t_temp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.c_temp_to_t_temp.Location = new System.Drawing.Point(86, 352);
            this.c_temp_to_t_temp.Name = "c_temp_to_t_temp";
            this.c_temp_to_t_temp.Size = new System.Drawing.Size(251, 23);
            this.c_temp_to_t_temp.TabIndex = 9;
            this.c_temp_to_t_temp.Text = "화씨 온도로 전환 ----->";
            this.c_temp_to_t_temp.UseVisualStyleBackColor = true;
            this.c_temp_to_t_temp.Click += new System.EventHandler(this.c_temp_to_t_temp_Click);
            // 
            // c_temp_value
            // 
            this.c_temp_value.AutoSize = true;
            this.c_temp_value.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c_temp_value.Location = new System.Drawing.Point(408, 153);
            this.c_temp_value.Name = "c_temp_value";
            this.c_temp_value.Size = new System.Drawing.Size(0, 30);
            this.c_temp_value.TabIndex = 10;
            // 
            // t_temp_value
            // 
            this.t_temp_value.AutoSize = true;
            this.t_temp_value.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t_temp_value.Location = new System.Drawing.Point(408, 332);
            this.t_temp_value.Name = "t_temp_value";
            this.t_temp_value.Size = new System.Drawing.Size(0, 30);
            this.t_temp_value.TabIndex = 11;
            this.t_temp_value.Click += new System.EventHandler(this.label2_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.Location = new System.Drawing.Point(563, 332);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(108, 30);
            this.text2.TabIndex = 12;
            this.text2.Text = "℉ 입니다.";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text1.Location = new System.Drawing.Point(563, 153);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(108, 30);
            this.text1.TabIndex = 13;
            this.text1.Text = "℃ 입니다.";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text3.Location = new System.Drawing.Point(192, 137);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(33, 30);
            this.text3.TabIndex = 14;
            this.text3.Text = "℉";
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text4.Location = new System.Drawing.Point(192, 307);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(33, 30);
            this.text4.TabIndex = 15;
            this.text4.Text = "℃";
            // 
            // MainForm_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.t_temp_value);
            this.Controls.Add(this.c_temp_value);
            this.Controls.Add(this.c_temp_to_t_temp);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.t_temp_to_c_temp);
            this.Controls.Add(this.c_temp_input);
            this.Controls.Add(this.t_temp_input);
            this.Controls.Add(this.c_temp);
            this.Controls.Add(this.t_temp);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "MainForm_02";
            this.Text = "섭씨, 화씨 온도 치환 프로그램 V1.0.1";
            this.Load += new System.EventHandler(this.MainForm_02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label t_temp;
        private System.Windows.Forms.Label c_temp;
        private System.Windows.Forms.TextBox t_temp_input;
        private System.Windows.Forms.TextBox c_temp_input;
        private System.Windows.Forms.Button t_temp_to_c_temp;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button c_temp_to_t_temp;
        private System.Windows.Forms.Label c_temp_value;
        private System.Windows.Forms.Label t_temp_value;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text4;
    }
}

