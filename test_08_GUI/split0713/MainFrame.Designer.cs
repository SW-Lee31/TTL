
namespace split0713
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
            this.output = new System.Windows.Forms.Label();
            this.div_button = new System.Windows.Forms.Button();
            this.multi_button = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.equal_button = new System.Windows.Forms.Button();
            this.num0_button = new System.Windows.Forms.Button();
            this.num9_button = new System.Windows.Forms.Button();
            this.num8_button = new System.Windows.Forms.Button();
            this.num7_button = new System.Windows.Forms.Button();
            this.num6_button = new System.Windows.Forms.Button();
            this.num5_button = new System.Windows.Forms.Button();
            this.num4_button = new System.Windows.Forms.Button();
            this.num3_button = new System.Windows.Forms.Button();
            this.num2_button = new System.Windows.Forms.Button();
            this.num1_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dot_button = new System.Windows.Forms.Button();
            this.route_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.output.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.output.Location = new System.Drawing.Point(26, 80);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(325, 59);
            this.output.TabIndex = 35;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // div_button
            // 
            this.div_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.div_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.div_button.ForeColor = System.Drawing.SystemColors.Window;
            this.div_button.Location = new System.Drawing.Point(310, 341);
            this.div_button.Name = "div_button";
            this.div_button.Size = new System.Drawing.Size(60, 59);
            this.div_button.TabIndex = 34;
            this.div_button.Text = "÷";
            this.div_button.UseVisualStyleBackColor = false;
            this.div_button.Click += new System.EventHandler(this.div_button_Click);
            // 
            // multi_button
            // 
            this.multi_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.multi_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.multi_button.ForeColor = System.Drawing.SystemColors.Window;
            this.multi_button.Location = new System.Drawing.Point(244, 341);
            this.multi_button.Name = "multi_button";
            this.multi_button.Size = new System.Drawing.Size(60, 59);
            this.multi_button.TabIndex = 33;
            this.multi_button.Text = "x";
            this.multi_button.UseVisualStyleBackColor = false;
            this.multi_button.Click += new System.EventHandler(this.multi_button_Click);
            // 
            // minus_button
            // 
            this.minus_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minus_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minus_button.ForeColor = System.Drawing.SystemColors.Window;
            this.minus_button.Location = new System.Drawing.Point(310, 258);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(60, 59);
            this.minus_button.TabIndex = 32;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = false;
            this.minus_button.Click += new System.EventHandler(this.minus_button_Click);
            // 
            // plus_button
            // 
            this.plus_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plus_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plus_button.ForeColor = System.Drawing.SystemColors.Window;
            this.plus_button.Location = new System.Drawing.Point(244, 258);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(60, 59);
            this.plus_button.TabIndex = 31;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = false;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // equal_button
            // 
            this.equal_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.equal_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.equal_button.ForeColor = System.Drawing.SystemColors.Window;
            this.equal_button.Location = new System.Drawing.Point(273, 177);
            this.equal_button.Name = "equal_button";
            this.equal_button.Size = new System.Drawing.Size(62, 55);
            this.equal_button.TabIndex = 30;
            this.equal_button.Text = "=";
            this.equal_button.UseVisualStyleBackColor = false;
            this.equal_button.Click += new System.EventHandler(this.equal_button_Click);
            // 
            // num0_button
            // 
            this.num0_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num0_button.Location = new System.Drawing.Point(99, 352);
            this.num0_button.Name = "num0_button";
            this.num0_button.Size = new System.Drawing.Size(57, 48);
            this.num0_button.TabIndex = 29;
            this.num0_button.Text = "0";
            this.num0_button.UseVisualStyleBackColor = true;
            this.num0_button.Click += new System.EventHandler(this.num1_button_Click);
            // 
            // num9_button
            // 
            this.num9_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num9_button.Location = new System.Drawing.Point(174, 289);
            this.num9_button.Name = "num9_button";
            this.num9_button.Size = new System.Drawing.Size(57, 48);
            this.num9_button.TabIndex = 28;
            this.num9_button.Text = "9";
            this.num9_button.UseVisualStyleBackColor = true;
            this.num9_button.Click += new System.EventHandler(this.num1_button_Click);
            // 
            // num8_button
            // 
            this.num8_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num8_button.Location = new System.Drawing.Point(99, 289);
            this.num8_button.Name = "num8_button";
            this.num8_button.Size = new System.Drawing.Size(57, 48);
            this.num8_button.TabIndex = 27;
            this.num8_button.Text = "8";
            this.num8_button.UseVisualStyleBackColor = true;
            this.num8_button.Click += new System.EventHandler(this.num1_button_Click);
            // 
            // num7_button
            // 
            this.num7_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num7_button.Location = new System.Drawing.Point(26, 289);
            this.num7_button.Name = "num7_button";
            this.num7_button.Size = new System.Drawing.Size(57, 48);
            this.num7_button.TabIndex = 26;
            this.num7_button.Text = "7";
            this.num7_button.UseVisualStyleBackColor = true;
            this.num7_button.Click += new System.EventHandler(this.num1_button_Click);
            // 
            // num6_button
            // 
            this.num6_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num6_button.Location = new System.Drawing.Point(174, 224);
            this.num6_button.Name = "num6_button";
            this.num6_button.Size = new System.Drawing.Size(57, 48);
            this.num6_button.TabIndex = 25;
            this.num6_button.Text = "6";
            this.num6_button.UseVisualStyleBackColor = true;
            this.num6_button.Click += new System.EventHandler(this.num1_button_Click);
            // 
            // num5_button
            // 
            this.num5_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num5_button.Location = new System.Drawing.Point(99, 224);
            this.num5_button.Name = "num5_button";
            this.num5_button.Size = new System.Drawing.Size(57, 48);
            this.num5_button.TabIndex = 24;
            this.num5_button.Text = "5";
            this.num5_button.UseVisualStyleBackColor = true;
            this.num5_button.Click += new System.EventHandler(this.num1_button_Click);
            // 
            // num4_button
            // 
            this.num4_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num4_button.Location = new System.Drawing.Point(26, 224);
            this.num4_button.Name = "num4_button";
            this.num4_button.Size = new System.Drawing.Size(57, 48);
            this.num4_button.TabIndex = 23;
            this.num4_button.Text = "4";
            this.num4_button.UseVisualStyleBackColor = true;
            this.num4_button.Click += new System.EventHandler(this.num1_button_Click);
            // 
            // num3_button
            // 
            this.num3_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num3_button.Location = new System.Drawing.Point(174, 158);
            this.num3_button.Name = "num3_button";
            this.num3_button.Size = new System.Drawing.Size(57, 48);
            this.num3_button.TabIndex = 22;
            this.num3_button.Text = "3";
            this.num3_button.UseVisualStyleBackColor = true;
            this.num3_button.Click += new System.EventHandler(this.num1_button_Click);
            // 
            // num2_button
            // 
            this.num2_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num2_button.Location = new System.Drawing.Point(99, 158);
            this.num2_button.Name = "num2_button";
            this.num2_button.Size = new System.Drawing.Size(57, 48);
            this.num2_button.TabIndex = 21;
            this.num2_button.Text = "2";
            this.num2_button.UseVisualStyleBackColor = true;
            this.num2_button.Click += new System.EventHandler(this.num1_button_Click);
            // 
            // num1_button
            // 
            this.num1_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num1_button.Location = new System.Drawing.Point(26, 158);
            this.num1_button.Name = "num1_button";
            this.num1_button.Size = new System.Drawing.Size(57, 48);
            this.num1_button.TabIndex = 20;
            this.num1_button.Text = "1";
            this.num1_button.UseVisualStyleBackColor = true;
            this.num1_button.Click += new System.EventHandler(this.num1_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_button.Location = new System.Drawing.Point(147, 417);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 19;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(83, 11);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(221, 32);
            this.title.TabIndex = 18;
            this.title.Text = "계산기 어플 V1.0.1";
            // 
            // dot_button
            // 
            this.dot_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dot_button.Location = new System.Drawing.Point(174, 352);
            this.dot_button.Name = "dot_button";
            this.dot_button.Size = new System.Drawing.Size(57, 48);
            this.dot_button.TabIndex = 36;
            this.dot_button.Text = ".";
            this.dot_button.UseVisualStyleBackColor = true;
            this.dot_button.Click += new System.EventHandler(this.num1_button_Click);
            // 
            // route_button
            // 
            this.route_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.route_button.Location = new System.Drawing.Point(26, 352);
            this.route_button.Name = "route_button";
            this.route_button.Size = new System.Drawing.Size(57, 48);
            this.route_button.TabIndex = 37;
            this.route_button.Text = "√";
            this.route_button.UseVisualStyleBackColor = true;
            this.route_button.Click += new System.EventHandler(this.route_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clear_button.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clear_button.ForeColor = System.Drawing.SystemColors.InfoText;
            this.clear_button.Location = new System.Drawing.Point(26, 80);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(55, 59);
            this.clear_button.TabIndex = 39;
            this.clear_button.Text = "C";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.num1_button_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.route_button);
            this.Controls.Add(this.dot_button);
            this.Controls.Add(this.output);
            this.Controls.Add(this.div_button);
            this.Controls.Add(this.multi_button);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.equal_button);
            this.Controls.Add(this.num0_button);
            this.Controls.Add(this.num9_button);
            this.Controls.Add(this.num8_button);
            this.Controls.Add(this.num7_button);
            this.Controls.Add(this.num6_button);
            this.Controls.Add(this.num5_button);
            this.Controls.Add(this.num4_button);
            this.Controls.Add(this.num3_button);
            this.Controls.Add(this.num2_button);
            this.Controls.Add(this.num1_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.title);
            this.Name = "MainFrame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button div_button;
        private System.Windows.Forms.Button multi_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button equal_button;
        private System.Windows.Forms.Button num0_button;
        private System.Windows.Forms.Button num9_button;
        private System.Windows.Forms.Button num8_button;
        private System.Windows.Forms.Button num7_button;
        private System.Windows.Forms.Button num6_button;
        private System.Windows.Forms.Button num5_button;
        private System.Windows.Forms.Button num4_button;
        private System.Windows.Forms.Button num3_button;
        private System.Windows.Forms.Button num2_button;
        private System.Windows.Forms.Button num1_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button dot_button;
        private System.Windows.Forms.Button route_button;
        private System.Windows.Forms.Button clear_button;
    }
}

