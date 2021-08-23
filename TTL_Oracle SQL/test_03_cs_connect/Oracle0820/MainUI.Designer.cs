
namespace Oracle0820
{
    partial class MainUI
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
            this.but_oracle_close = new System.Windows.Forms.Button();
            this.but_create_table = new System.Windows.Forms.Button();
            this.but_drop_table = new System.Windows.Forms.Button();
            this.input_table_name = new System.Windows.Forms.TextBox();
            this.input_seq_name = new System.Windows.Forms.TextBox();
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_age = new System.Windows.Forms.TextBox();
            this.input_addr = new System.Windows.Forms.TextBox();
            this.but_insert = new System.Windows.Forms.Button();
            this.input_grade = new System.Windows.Forms.TextBox();
            this.but_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_oracle_close
            // 
            this.but_oracle_close.Location = new System.Drawing.Point(319, 396);
            this.but_oracle_close.Name = "but_oracle_close";
            this.but_oracle_close.Size = new System.Drawing.Size(121, 23);
            this.but_oracle_close.TabIndex = 0;
            this.but_oracle_close.Text = "종료";
            this.but_oracle_close.UseVisualStyleBackColor = true;
            this.but_oracle_close.Click += new System.EventHandler(this.but_oracle_close_Click);
            // 
            // but_create_table
            // 
            this.but_create_table.Location = new System.Drawing.Point(33, 155);
            this.but_create_table.Name = "but_create_table";
            this.but_create_table.Size = new System.Drawing.Size(182, 23);
            this.but_create_table.TabIndex = 1;
            this.but_create_table.Text = "테이블 | 시퀀스 생성";
            this.but_create_table.UseVisualStyleBackColor = true;
            this.but_create_table.Click += new System.EventHandler(this.but_create_table_Click);
            // 
            // but_drop_table
            // 
            this.but_drop_table.Location = new System.Drawing.Point(33, 194);
            this.but_drop_table.Name = "but_drop_table";
            this.but_drop_table.Size = new System.Drawing.Size(182, 23);
            this.but_drop_table.TabIndex = 2;
            this.but_drop_table.Text = "테이블 | 시퀀스 삭제";
            this.but_drop_table.UseVisualStyleBackColor = true;
            this.but_drop_table.Click += new System.EventHandler(this.but_drop_table_Click);
            // 
            // input_table_name
            // 
            this.input_table_name.Location = new System.Drawing.Point(33, 66);
            this.input_table_name.Name = "input_table_name";
            this.input_table_name.Size = new System.Drawing.Size(100, 21);
            this.input_table_name.TabIndex = 3;
            this.input_table_name.TextChanged += new System.EventHandler(this.input_table_name_TextChanged);
            // 
            // input_seq_name
            // 
            this.input_seq_name.Location = new System.Drawing.Point(33, 109);
            this.input_seq_name.Name = "input_seq_name";
            this.input_seq_name.Size = new System.Drawing.Size(100, 21);
            this.input_seq_name.TabIndex = 4;
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(356, 66);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(100, 21);
            this.input_name.TabIndex = 5;
            // 
            // input_age
            // 
            this.input_age.Location = new System.Drawing.Point(356, 109);
            this.input_age.Name = "input_age";
            this.input_age.Size = new System.Drawing.Size(100, 21);
            this.input_age.TabIndex = 6;
            // 
            // input_addr
            // 
            this.input_addr.Location = new System.Drawing.Point(356, 155);
            this.input_addr.Name = "input_addr";
            this.input_addr.Size = new System.Drawing.Size(100, 21);
            this.input_addr.TabIndex = 7;
            // 
            // but_insert
            // 
            this.but_insert.Location = new System.Drawing.Point(334, 234);
            this.but_insert.Name = "but_insert";
            this.but_insert.Size = new System.Drawing.Size(182, 23);
            this.but_insert.TabIndex = 9;
            this.but_insert.Text = "정보 입력";
            this.but_insert.UseVisualStyleBackColor = true;
            this.but_insert.Click += new System.EventHandler(this.but_insert_Click);
            // 
            // input_grade
            // 
            this.input_grade.Location = new System.Drawing.Point(356, 196);
            this.input_grade.Name = "input_grade";
            this.input_grade.Size = new System.Drawing.Size(100, 21);
            this.input_grade.TabIndex = 10;
            // 
            // but_show
            // 
            this.but_show.Location = new System.Drawing.Point(33, 348);
            this.but_show.Name = "but_show";
            this.but_show.Size = new System.Drawing.Size(182, 23);
            this.but_show.TabIndex = 11;
            this.but_show.Text = "정보 출력";
            this.but_show.UseVisualStyleBackColor = true;
            this.but_show.Click += new System.EventHandler(this.but_show_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_show);
            this.Controls.Add(this.input_grade);
            this.Controls.Add(this.but_insert);
            this.Controls.Add(this.input_addr);
            this.Controls.Add(this.input_age);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.input_seq_name);
            this.Controls.Add(this.input_table_name);
            this.Controls.Add(this.but_drop_table);
            this.Controls.Add(this.but_create_table);
            this.Controls.Add(this.but_oracle_close);
            this.Name = "MainUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_oracle_close;
        private System.Windows.Forms.Button but_create_table;
        private System.Windows.Forms.Button but_drop_table;
        private System.Windows.Forms.TextBox input_table_name;
        private System.Windows.Forms.TextBox input_seq_name;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.TextBox input_age;
        private System.Windows.Forms.TextBox input_addr;
        private System.Windows.Forms.Button but_insert;
        private System.Windows.Forms.TextBox input_grade;
        private System.Windows.Forms.Button but_show;
    }
}

