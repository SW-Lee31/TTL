
namespace control0707_3
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
            this.exit_button = new System.Windows.Forms.Button();
            this.operation_button = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(49, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(221, 32);
            this.title.TabIndex = 0;
            this.title.Text = "윤년 계산기 V1.0.1";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_button.Location = new System.Drawing.Point(118, 415);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // operation_button
            // 
            this.operation_button.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.operation_button.Location = new System.Drawing.Point(78, 216);
            this.operation_button.Name = "operation_button";
            this.operation_button.Size = new System.Drawing.Size(142, 46);
            this.operation_button.TabIndex = 2;
            this.operation_button.Text = "윤년계산 실행";
            this.operation_button.UseVisualStyleBackColor = true;
            this.operation_button.Click += new System.EventHandler(this.operation_button_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(88, 155);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 21);
            this.input.TabIndex = 3;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.output.Location = new System.Drawing.Point(9, 341);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 32);
            this.output.TabIndex = 4;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.Location = new System.Drawing.Point(40, 106);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(240, 25);
            this.text2.TabIndex = 6;
            this.text2.Text = "원하는 년도를 입력하세요.";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text3.Location = new System.Drawing.Point(189, 149);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(39, 32);
            this.text3.TabIndex = 7;
            this.text3.Text = "년";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 450);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.operation_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.title);
            this.Name = "MainFrame";
            this.Text = "윤년 계산기 V1.0.1";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button operation_button;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text3;
    }
}

