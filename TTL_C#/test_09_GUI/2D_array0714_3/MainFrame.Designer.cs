
namespace _2D_array0714_3
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
            this.name_create_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.print_button = new System.Windows.Forms.Button();
            this.print_index_input = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.drop_index_input = new System.Windows.Forms.TextBox();
            this.drop_button = new System.Windows.Forms.Button();
            this.text3 = new System.Windows.Forms.Label();
            this.name_output = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.commit_button = new System.Windows.Forms.Button();
            this.text4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("경기천년제목V Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.title.Location = new System.Drawing.Point(9, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(417, 24);
            this.title.TabIndex = 3;
            this.title.Text = "Name Management Program V1.0.1";
            // 
            // name_create_button
            // 
            this.name_create_button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_create_button.Location = new System.Drawing.Point(109, 71);
            this.name_create_button.Name = "name_create_button";
            this.name_create_button.Size = new System.Drawing.Size(231, 68);
            this.name_create_button.TabIndex = 4;
            this.name_create_button.Text = "Name Create and Store";
            this.name_create_button.UseVisualStyleBackColor = true;
            this.name_create_button.Click += new System.EventHandler(this.name_create_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_button.Location = new System.Drawing.Point(180, 639);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // print_button
            // 
            this.print_button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.print_button.Location = new System.Drawing.Point(215, 194);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(125, 68);
            this.print_button.TabIndex = 6;
            this.print_button.Text = "Stored Name Print";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // print_index_input
            // 
            this.print_index_input.Location = new System.Drawing.Point(109, 212);
            this.print_index_input.Name = "print_index_input";
            this.print_index_input.Size = new System.Drawing.Size(100, 21);
            this.print_index_input.TabIndex = 7;
            this.print_index_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text1.Location = new System.Drawing.Point(-2, 156);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(441, 25);
            this.text1.TabIndex = 8;
            this.text1.Text = "Choose index number which you want to print";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.Location = new System.Drawing.Point(-2, 280);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(441, 25);
            this.text2.TabIndex = 11;
            this.text2.Text = "Choose index number which you want to drop";
            // 
            // drop_index_input
            // 
            this.drop_index_input.Location = new System.Drawing.Point(109, 336);
            this.drop_index_input.Name = "drop_index_input";
            this.drop_index_input.Size = new System.Drawing.Size(100, 21);
            this.drop_index_input.TabIndex = 10;
            this.drop_index_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drop_button
            // 
            this.drop_button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drop_button.Location = new System.Drawing.Point(215, 315);
            this.drop_button.Name = "drop_button";
            this.drop_button.Size = new System.Drawing.Size(125, 68);
            this.drop_button.TabIndex = 9;
            this.drop_button.Text = "Drop Stored  Name";
            this.drop_button.UseVisualStyleBackColor = true;
            this.drop_button.Click += new System.EventHandler(this.drop_button_Click);
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text3.Location = new System.Drawing.Point(35, 550);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(358, 25);
            this.text3.TabIndex = 12;
            this.text3.Text = "Created name will be added in textfile";
            // 
            // name_output
            // 
            this.name_output.AutoSize = true;
            this.name_output.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_output.Location = new System.Drawing.Point(130, 598);
            this.name_output.Name = "name_output";
            this.name_output.Size = new System.Drawing.Size(0, 25);
            this.name_output.TabIndex = 13;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_button.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(367, 340);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(58, 43);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "delete all";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // commit_button
            // 
            this.commit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.commit_button.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.commit_button.ForeColor = System.Drawing.Color.White;
            this.commit_button.Location = new System.Drawing.Point(109, 462);
            this.commit_button.Name = "commit_button";
            this.commit_button.Size = new System.Drawing.Size(231, 58);
            this.commit_button.TabIndex = 15;
            this.commit_button.Text = "Commit";
            this.commit_button.UseVisualStyleBackColor = false;
            this.commit_button.Click += new System.EventHandler(this.commit_button_Click);
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text4.Location = new System.Drawing.Point(22, 429);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(385, 25);
            this.text4.TabIndex = 16;
            this.text4.Text = "Commit and store name list as a text file";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 674);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.commit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.name_output);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.drop_index_input);
            this.Controls.Add(this.drop_button);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.print_index_input);
            this.Controls.Add(this.print_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.name_create_button);
            this.Controls.Add(this.title);
            this.Name = "MainFrame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button name_create_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.TextBox print_index_input;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.TextBox drop_index_input;
        private System.Windows.Forms.Button drop_button;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label name_output;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button commit_button;
        private System.Windows.Forms.Label text4;
    }
}

