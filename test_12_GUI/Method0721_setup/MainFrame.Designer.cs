
namespace Method0721_setup
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
            this.text1 = new System.Windows.Forms.Label();
            this.path_input = new System.Windows.Forms.TextBox();
            this.store_buttton = new System.Windows.Forms.Button();
            this.print_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.output_listbox = new System.Windows.Forms.ListBox();
            this.input_index_input = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.Label();
            this.print_index_input = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.Label();
            this.text5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text1.Location = new System.Drawing.Point(6, 77);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(307, 21);
            this.text1.TabIndex = 0;
            this.text1.Text = "※ 저장할 파일을 생성위치를 입력하세요.";
            // 
            // path_input
            // 
            this.path_input.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.path_input.Location = new System.Drawing.Point(18, 140);
            this.path_input.Name = "path_input";
            this.path_input.Size = new System.Drawing.Size(287, 29);
            this.path_input.TabIndex = 1;
            // 
            // store_buttton
            // 
            this.store_buttton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.store_buttton.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.store_buttton.Location = new System.Drawing.Point(38, 274);
            this.store_buttton.Name = "store_buttton";
            this.store_buttton.Size = new System.Drawing.Size(231, 45);
            this.store_buttton.TabIndex = 3;
            this.store_buttton.Text = "주소록 저장";
            this.store_buttton.UseVisualStyleBackColor = false;
            this.store_buttton.Click += new System.EventHandler(this.store_buttton_Click);
            // 
            // print_button
            // 
            this.print_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.print_button.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.print_button.Location = new System.Drawing.Point(35, 450);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(231, 45);
            this.print_button.TabIndex = 4;
            this.print_button.Text = "주소록 보기";
            this.print_button.UseVisualStyleBackColor = false;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // info_button
            // 
            this.info_button.BackColor = System.Drawing.Color.White;
            this.info_button.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.info_button.Location = new System.Drawing.Point(27, 526);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(112, 45);
            this.info_button.TabIndex = 5;
            this.info_button.Text = "도움말";
            this.info_button.UseVisualStyleBackColor = false;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.White;
            this.exit_button.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_button.Location = new System.Drawing.Point(162, 526);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(112, 45);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "종료";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("경기천년제목V Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(202, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(370, 37);
            this.title.TabIndex = 7;
            this.title.Text = "주소록 관리 프로그램";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.Location = new System.Drawing.Point(35, 112);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(219, 17);
            this.text2.TabIndex = 8;
            this.text2.Text = "[사용 예] C:\\\\temp\\\\(파일명).txt";
            // 
            // output_listbox
            // 
            this.output_listbox.FormattingEnabled = true;
            this.output_listbox.HorizontalScrollbar = true;
            this.output_listbox.ItemHeight = 12;
            this.output_listbox.Location = new System.Drawing.Point(317, 75);
            this.output_listbox.Name = "output_listbox";
            this.output_listbox.ScrollAlwaysVisible = true;
            this.output_listbox.Size = new System.Drawing.Size(442, 496);
            this.output_listbox.TabIndex = 9;
            // 
            // input_index_input
            // 
            this.input_index_input.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_index_input.Location = new System.Drawing.Point(93, 232);
            this.input_index_input.Name = "input_index_input";
            this.input_index_input.Size = new System.Drawing.Size(117, 29);
            this.input_index_input.TabIndex = 22;
            this.input_index_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text3.Location = new System.Drawing.Point(34, 199);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(243, 21);
            this.text3.TabIndex = 23;
            this.text3.Text = "※ 생성할 인원 수를 입력하세요.";
            // 
            // print_index_input
            // 
            this.print_index_input.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.print_index_input.Location = new System.Drawing.Point(90, 411);
            this.print_index_input.Name = "print_index_input";
            this.print_index_input.Size = new System.Drawing.Size(117, 29);
            this.print_index_input.TabIndex = 25;
            this.print_index_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text4.Location = new System.Drawing.Point(15, 347);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(291, 21);
            this.text4.TabIndex = 26;
            this.text4.Text = "※ 출력하고 싶은 번호를 입력해주세요.";
            // 
            // text5
            // 
            this.text5.AutoSize = true;
            this.text5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text5.Location = new System.Drawing.Point(27, 380);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(265, 17);
            this.text5.TabIndex = 27;
            this.text5.Text = "미입력시 저장된 전원의 정보가 출력됩니다.";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(771, 584);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.print_index_input);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.input_index_input);
            this.Controls.Add(this.output_listbox);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.print_button);
            this.Controls.Add(this.store_buttton);
            this.Controls.Add(this.path_input);
            this.Controls.Add(this.text1);
            this.Name = "MainFrame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.TextBox path_input;
        private System.Windows.Forms.Button store_buttton;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.ListBox output_listbox;
        private System.Windows.Forms.TextBox input_index_input;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.TextBox print_index_input;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.Label text5;
    }
}

