
namespace input0705_GUI
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
            this.summary = new System.Windows.Forms.Label();
            this.output_value = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.label_output = new System.Windows.Forms.Button();
            this.input_value = new System.Windows.Forms.TextBox();
            this.text_add = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("襟 컲?", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(95, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(512, 48);
            this.title.TabIndex = 0;
            this.title.Text = "원 면적 산출 프로그램";
            // 
            // summary
            // 
            this.summary.AutoSize = true;
            this.summary.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.summary.Location = new System.Drawing.Point(177, 110);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(301, 32);
            this.summary.TabIndex = 1;
            this.summary.Text = "반지름 값을 입력해주세요.";
            this.summary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.summary.Click += new System.EventHandler(this.summary_Click);
            // 
            // output_value
            // 
            this.output_value.AutoSize = true;
            this.output_value.BackColor = System.Drawing.SystemColors.Menu;
            this.output_value.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_value.Location = new System.Drawing.Point(244, 306);
            this.output_value.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.output_value.Name = "output_value";
            this.output_value.Size = new System.Drawing.Size(0, 48);
            this.output_value.TabIndex = 3;
            this.output_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.output_value.Click += new System.EventHandler(this.output_value_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output.Location = new System.Drawing.Point(246, 260);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(167, 32);
            this.output.TabIndex = 4;
            this.output.Text = "원의 면적값은";
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.output.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_button.Location = new System.Drawing.Point(290, 405);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(73, 27);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label_output
            // 
            this.label_output.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_output.Location = new System.Drawing.Point(275, 202);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(106, 41);
            this.label_output.TabIndex = 6;
            this.label_output.Text = "값 출력";
            this.label_output.UseVisualStyleBackColor = true;
            this.label_output.Click += new System.EventHandler(this.label_output_Click);
            // 
            // input_value
            // 
            this.input_value.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_value.Location = new System.Drawing.Point(275, 151);
            this.input_value.Multiline = true;
            this.input_value.Name = "input_value";
            this.input_value.Size = new System.Drawing.Size(106, 30);
            this.input_value.TabIndex = 7;
            this.input_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_value.TextChanged += new System.EventHandler(this.input_value_TextChanged);
            // 
            // text_add
            // 
            this.text_add.AutoSize = true;
            this.text_add.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_add.Location = new System.Drawing.Point(278, 362);
            this.text_add.Name = "text_add";
            this.text_add.Size = new System.Drawing.Size(93, 32);
            this.text_add.TabIndex = 8;
            this.text_add.Text = "입니다.";
            this.text_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.text_add);
            this.Controls.Add(this.input_value);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.output);
            this.Controls.Add(this.output_value);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.title);
            this.Name = "MainForm";
            this.Text = "원 면적 산출 프로그램 V1.0.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label summary;
        private System.Windows.Forms.Label output_value;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button label_output;
        private System.Windows.Forms.TextBox input_value;
        private System.Windows.Forms.Label text_add;
    }
}

