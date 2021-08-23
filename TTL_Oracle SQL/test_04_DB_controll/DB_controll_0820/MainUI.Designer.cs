
namespace DB_controll_0820
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
            this.but_create_table = new System.Windows.Forms.Button();
            this.input_table_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.input_cel = new System.Windows.Forms.TextBox();
            this.input_effect = new System.Windows.Forms.TextBox();
            this.input_dev = new System.Windows.Forms.TextBox();
            this.input_fuct = new System.Windows.Forms.TextBox();
            this.but_show = new System.Windows.Forms.Button();
            this.but_drop_table = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_create_table
            // 
            this.but_create_table.Location = new System.Drawing.Point(111, 12);
            this.but_create_table.Name = "but_create_table";
            this.but_create_table.Size = new System.Drawing.Size(109, 38);
            this.but_create_table.TabIndex = 0;
            this.but_create_table.Text = "테이블 생성";
            this.but_create_table.UseVisualStyleBackColor = true;
            this.but_create_table.Click += new System.EventHandler(this.but_create_table_Click);
            // 
            // input_table_name
            // 
            this.input_table_name.Location = new System.Drawing.Point(5, 22);
            this.input_table_name.Name = "input_table_name";
            this.input_table_name.Size = new System.Drawing.Size(100, 21);
            this.input_table_name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "데이터 입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.input_fuct);
            this.panel1.Controls.Add(this.but_show);
            this.panel1.Controls.Add(this.input_dev);
            this.panel1.Controls.Add(this.input_effect);
            this.panel1.Controls.Add(this.input_cel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 254);
            this.panel1.TabIndex = 3;
            // 
            // input_cel
            // 
            this.input_cel.Location = new System.Drawing.Point(175, 23);
            this.input_cel.Name = "input_cel";
            this.input_cel.Size = new System.Drawing.Size(100, 21);
            this.input_cel.TabIndex = 4;
            // 
            // input_effect
            // 
            this.input_effect.Location = new System.Drawing.Point(175, 69);
            this.input_effect.Name = "input_effect";
            this.input_effect.Size = new System.Drawing.Size(100, 21);
            this.input_effect.TabIndex = 5;
            this.input_effect.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // input_dev
            // 
            this.input_dev.Location = new System.Drawing.Point(175, 119);
            this.input_dev.Name = "input_dev";
            this.input_dev.Size = new System.Drawing.Size(100, 21);
            this.input_dev.TabIndex = 6;
            // 
            // input_fuct
            // 
            this.input_fuct.Location = new System.Drawing.Point(175, 172);
            this.input_fuct.Name = "input_fuct";
            this.input_fuct.Size = new System.Drawing.Size(100, 21);
            this.input_fuct.TabIndex = 7;
            // 
            // but_show
            // 
            this.but_show.Location = new System.Drawing.Point(442, 23);
            this.but_show.Name = "but_show";
            this.but_show.Size = new System.Drawing.Size(109, 38);
            this.but_show.TabIndex = 4;
            this.but_show.Text = "데이터 출력";
            this.but_show.UseVisualStyleBackColor = true;
            this.but_show.Click += new System.EventHandler(this.but_show_Click);
            // 
            // but_drop_table
            // 
            this.but_drop_table.Location = new System.Drawing.Point(111, 96);
            this.but_drop_table.Name = "but_drop_table";
            this.but_drop_table.Size = new System.Drawing.Size(109, 38);
            this.but_drop_table.TabIndex = 8;
            this.but_drop_table.Text = "데이터 입력";
            this.but_drop_table.UseVisualStyleBackColor = true;
            this.but_drop_table.Click += new System.EventHandler(this.but_drop_table_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_drop_table);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.input_table_name);
            this.Controls.Add(this.but_create_table);
            this.Name = "MainUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_create_table;
        private System.Windows.Forms.TextBox input_table_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox input_fuct;
        private System.Windows.Forms.TextBox input_dev;
        private System.Windows.Forms.TextBox input_effect;
        private System.Windows.Forms.TextBox input_cel;
        private System.Windows.Forms.Button but_show;
        private System.Windows.Forms.Button but_drop_table;
    }
}

