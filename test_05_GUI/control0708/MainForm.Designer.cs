
namespace control0708
{
    partial class te
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
            this.cal_group = new System.Windows.Forms.GroupBox();
            this.result_output = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.ouput_oper = new System.Windows.Forms.Label();
            this.nanu = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.num2_input = new System.Windows.Forms.TextBox();
            this.num1_input = new System.Windows.Forms.TextBox();
            this.manage = new System.Windows.Forms.GroupBox();
            this.kor_input = new System.Windows.Forms.TextBox();
            this.eng_input = new System.Windows.Forms.TextBox();
            this.math_input = new System.Windows.Forms.TextBox();
            this.soci_input = new System.Windows.Forms.TextBox();
            this.sci_input = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text6 = new System.Windows.Forms.Label();
            this.oper_button2 = new System.Windows.Forms.Button();
            this.text8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text10 = new System.Windows.Forms.Label();
            this.sum_result = new System.Windows.Forms.Label();
            this.avg_result = new System.Windows.Forms.Label();
            this.level_result = new System.Windows.Forms.Label();
            this.cal_group.SuspendLayout();
            this.manage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cal_group
            // 
            this.cal_group.Controls.Add(this.result_output);
            this.cal_group.Controls.Add(this.text);
            this.cal_group.Controls.Add(this.ouput_oper);
            this.cal_group.Controls.Add(this.nanu);
            this.cal_group.Controls.Add(this.multiple);
            this.cal_group.Controls.Add(this.minus);
            this.cal_group.Controls.Add(this.plus_button);
            this.cal_group.Controls.Add(this.num2_input);
            this.cal_group.Controls.Add(this.num1_input);
            this.cal_group.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cal_group.Location = new System.Drawing.Point(12, 21);
            this.cal_group.Name = "cal_group";
            this.cal_group.Size = new System.Drawing.Size(322, 248);
            this.cal_group.TabIndex = 0;
            this.cal_group.TabStop = false;
            this.cal_group.Text = "Simple Calculator v1.0.1";
            this.cal_group.Enter += new System.EventHandler(this.cal_group_Enter);
            // 
            // result_output
            // 
            this.result_output.AutoSize = true;
            this.result_output.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result_output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.result_output.Location = new System.Drawing.Point(128, 205);
            this.result_output.Name = "result_output";
            this.result_output.Size = new System.Drawing.Size(0, 21);
            this.result_output.TabIndex = 8;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text.Location = new System.Drawing.Point(126, 172);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(68, 21);
            this.text.TabIndex = 7;
            this.text.Text = "Result";
            // 
            // ouput_oper
            // 
            this.ouput_oper.AutoSize = true;
            this.ouput_oper.Location = new System.Drawing.Point(149, 66);
            this.ouput_oper.Name = "ouput_oper";
            this.ouput_oper.Size = new System.Drawing.Size(0, 13);
            this.ouput_oper.TabIndex = 6;
            // 
            // nanu
            // 
            this.nanu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nanu.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nanu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nanu.Location = new System.Drawing.Point(253, 107);
            this.nanu.Name = "nanu";
            this.nanu.Size = new System.Drawing.Size(38, 39);
            this.nanu.TabIndex = 5;
            this.nanu.Text = "÷";
            this.nanu.UseVisualStyleBackColor = false;
            this.nanu.Click += new System.EventHandler(this.nanu_Click);
            // 
            // multiple
            // 
            this.multiple.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.multiple.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.multiple.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiple.Location = new System.Drawing.Point(177, 107);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(38, 39);
            this.multiple.TabIndex = 4;
            this.multiple.Text = "x";
            this.multiple.UseVisualStyleBackColor = false;
            this.multiple.Click += new System.EventHandler(this.multiple_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minus.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minus.Location = new System.Drawing.Point(101, 107);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(38, 39);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus_button
            // 
            this.plus_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plus_button.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plus_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plus_button.Location = new System.Drawing.Point(24, 107);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(38, 39);
            this.plus_button.TabIndex = 2;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = false;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // num2_input
            // 
            this.num2_input.Location = new System.Drawing.Point(178, 60);
            this.num2_input.Name = "num2_input";
            this.num2_input.Size = new System.Drawing.Size(57, 22);
            this.num2_input.TabIndex = 1;
            this.num2_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num2_input.TextChanged += new System.EventHandler(this.num2_input_TextChanged);
            // 
            // num1_input
            // 
            this.num1_input.Location = new System.Drawing.Point(80, 60);
            this.num1_input.Name = "num1_input";
            this.num1_input.Size = new System.Drawing.Size(57, 22);
            this.num1_input.TabIndex = 0;
            this.num1_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num1_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // manage
            // 
            this.manage.Controls.Add(this.level_result);
            this.manage.Controls.Add(this.avg_result);
            this.manage.Controls.Add(this.sum_result);
            this.manage.Controls.Add(this.text10);
            this.manage.Controls.Add(this.label3);
            this.manage.Controls.Add(this.text8);
            this.manage.Controls.Add(this.oper_button2);
            this.manage.Controls.Add(this.text6);
            this.manage.Controls.Add(this.label2);
            this.manage.Controls.Add(this.label1);
            this.manage.Controls.Add(this.text4);
            this.manage.Controls.Add(this.text3);
            this.manage.Controls.Add(this.text2);
            this.manage.Controls.Add(this.sci_input);
            this.manage.Controls.Add(this.soci_input);
            this.manage.Controls.Add(this.math_input);
            this.manage.Controls.Add(this.eng_input);
            this.manage.Controls.Add(this.kor_input);
            this.manage.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.manage.Location = new System.Drawing.Point(340, 21);
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(336, 248);
            this.manage.TabIndex = 1;
            this.manage.TabStop = false;
            this.manage.Text = "Test Result Management V.1.0.1";
            this.manage.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // kor_input
            // 
            this.kor_input.Location = new System.Drawing.Point(93, 41);
            this.kor_input.Name = "kor_input";
            this.kor_input.Size = new System.Drawing.Size(57, 22);
            this.kor_input.TabIndex = 9;
            this.kor_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kor_input.TextChanged += new System.EventHandler(this.kor_input_TextChanged);
            // 
            // eng_input
            // 
            this.eng_input.Location = new System.Drawing.Point(93, 80);
            this.eng_input.Name = "eng_input";
            this.eng_input.Size = new System.Drawing.Size(57, 22);
            this.eng_input.TabIndex = 10;
            this.eng_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eng_input.TextChanged += new System.EventHandler(this.eng_input_TextChanged);
            // 
            // math_input
            // 
            this.math_input.Location = new System.Drawing.Point(93, 120);
            this.math_input.Name = "math_input";
            this.math_input.Size = new System.Drawing.Size(57, 22);
            this.math_input.TabIndex = 11;
            this.math_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.math_input.TextChanged += new System.EventHandler(this.math_input_TextChanged);
            // 
            // soci_input
            // 
            this.soci_input.Location = new System.Drawing.Point(94, 162);
            this.soci_input.Name = "soci_input";
            this.soci_input.Size = new System.Drawing.Size(57, 22);
            this.soci_input.TabIndex = 12;
            this.soci_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soci_input.TextChanged += new System.EventHandler(this.soci_input_TextChanged);
            // 
            // sci_input
            // 
            this.sci_input.Location = new System.Drawing.Point(94, 200);
            this.sci_input.Name = "sci_input";
            this.sci_input.Size = new System.Drawing.Size(57, 22);
            this.sci_input.TabIndex = 13;
            this.sci_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sci_input.TextChanged += new System.EventHandler(this.sci_input_TextChanged);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.Location = new System.Drawing.Point(7, 45);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(76, 13);
            this.text2.TabIndex = 9;
            this.text2.Text = "○ Korean";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text3.Location = new System.Drawing.Point(7, 83);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(78, 13);
            this.text3.TabIndex = 14;
            this.text3.Text = "○ English";
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text4.Location = new System.Drawing.Point(7, 124);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(59, 13);
            this.text4.TabIndex = 15;
            this.text4.Text = "○ Math";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "○ Society";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(8, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "○ Science";
            // 
            // text6
            // 
            this.text6.AutoSize = true;
            this.text6.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.text6.Location = new System.Drawing.Point(218, 101);
            this.text6.Name = "text6";
            this.text6.Size = new System.Drawing.Size(76, 30);
            this.text6.TabIndex = 9;
            this.text6.Text = "Result";
            // 
            // oper_button2
            // 
            this.oper_button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.oper_button2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.oper_button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oper_button2.Location = new System.Drawing.Point(194, 48);
            this.oper_button2.Name = "oper_button2";
            this.oper_button2.Size = new System.Drawing.Size(113, 39);
            this.oper_button2.TabIndex = 9;
            this.oper_button2.Text = "Operate";
            this.oper_button2.UseVisualStyleBackColor = false;
            this.oper_button2.Click += new System.EventHandler(this.oper_button2_Click);
            // 
            // text8
            // 
            this.text8.AutoSize = true;
            this.text8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.text8.Location = new System.Drawing.Point(189, 139);
            this.text8.Name = "text8";
            this.text8.Size = new System.Drawing.Size(42, 20);
            this.text8.TabIndex = 18;
            this.text8.Text = "SUM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(189, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "AVG";
            // 
            // text10
            // 
            this.text10.AutoSize = true;
            this.text10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.text10.Location = new System.Drawing.Point(198, 202);
            this.text10.Name = "text10";
            this.text10.Size = new System.Drawing.Size(27, 20);
            this.text10.TabIndex = 20;
            this.text10.Text = "LV";
            this.text10.Click += new System.EventHandler(this.text10_Click);
            // 
            // sum_result
            // 
            this.sum_result.AutoSize = true;
            this.sum_result.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum_result.Location = new System.Drawing.Point(241, 144);
            this.sum_result.Name = "sum_result";
            this.sum_result.Size = new System.Drawing.Size(0, 13);
            this.sum_result.TabIndex = 21;
            // 
            // avg_result
            // 
            this.avg_result.AutoSize = true;
            this.avg_result.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.avg_result.Location = new System.Drawing.Point(246, 175);
            this.avg_result.Name = "avg_result";
            this.avg_result.Size = new System.Drawing.Size(0, 13);
            this.avg_result.TabIndex = 22;
            // 
            // level_result
            // 
            this.level_result.AutoSize = true;
            this.level_result.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.level_result.Location = new System.Drawing.Point(252, 207);
            this.level_result.Name = "level_result";
            this.level_result.Size = new System.Drawing.Size(0, 13);
            this.level_result.TabIndex = 23;
            // 
            // te
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 283);
            this.Controls.Add(this.manage);
            this.Controls.Add(this.cal_group);
            this.Name = "te";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.cal_group.ResumeLayout(false);
            this.cal_group.PerformLayout();
            this.manage.ResumeLayout(false);
            this.manage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cal_group;
        private System.Windows.Forms.GroupBox manage;
        private System.Windows.Forms.TextBox num2_input;
        private System.Windows.Forms.TextBox num1_input;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label ouput_oper;
        private System.Windows.Forms.Button nanu;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Label result_output;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.TextBox sci_input;
        private System.Windows.Forms.TextBox soci_input;
        private System.Windows.Forms.TextBox math_input;
        private System.Windows.Forms.TextBox eng_input;
        private System.Windows.Forms.TextBox kor_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label text8;
        private System.Windows.Forms.Button oper_button2;
        private System.Windows.Forms.Label text6;
        private System.Windows.Forms.Label level_result;
        private System.Windows.Forms.Label avg_result;
        private System.Windows.Forms.Label sum_result;
    }
}

