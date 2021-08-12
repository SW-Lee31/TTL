
namespace View_structure_0811.UI.UI_contents.Add_person_name_search
{
    partial class Add_person_name_search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Top_panel = new Sunny.UI.UIFlowLayoutPanel();
            this.but_close = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.output_memberdigit = new Sunny.UI.UILabel();
            this.input_name = new Sunny.UI.UITextBox();
            this.confirm = new Sunny.UI.UISymbolButton();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.Top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.White;
            this.Top_panel.Controls.Add(this.but_close);
            this.Top_panel.Controls.Add(this.uiLabel1);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.FillColor = System.Drawing.Color.Transparent;
            this.Top_panel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Top_panel.MinimumSize = new System.Drawing.Size(1, 1);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Padding = new System.Windows.Forms.Padding(2);
            this.Top_panel.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Top_panel.RectColor = System.Drawing.Color.Transparent;
            this.Top_panel.Size = new System.Drawing.Size(362, 66);
            this.Top_panel.Style = Sunny.UI.UIStyle.Custom;
            this.Top_panel.TabIndex = 2;
            this.Top_panel.Text = "uiFlowLayoutPanel1";
            this.Top_panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_close
            // 
            this.but_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_close.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_close.Location = new System.Drawing.Point(325, 2);
            this.but_close.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(35, 62);
            this.but_close.Style = Sunny.UI.UIStyle.Custom;
            this.but_close.TabIndex = 3;
            this.but_close.Text = "X";
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Location = new System.Drawing.Point(2, 2);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(360, 62);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 18;
            this.uiLabel1.Text = "이름으로 찾기";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_memberdigit
            // 
            this.output_memberdigit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.output_memberdigit.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_memberdigit.ForeColor = System.Drawing.Color.Black;
            this.output_memberdigit.Location = new System.Drawing.Point(8, 200);
            this.output_memberdigit.Name = "output_memberdigit";
            this.output_memberdigit.Size = new System.Drawing.Size(342, 81);
            this.output_memberdigit.TabIndex = 154;
            this.output_memberdigit.Text = "data";
            this.output_memberdigit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_name
            // 
            this.input_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_name.FillColor = System.Drawing.Color.White;
            this.input_name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_name.Location = new System.Drawing.Point(68, 115);
            this.input_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_name.Maximum = 2147483647D;
            this.input_name.Minimum = -2147483648D;
            this.input_name.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_name.Name = "input_name";
            this.input_name.RectColor = System.Drawing.Color.Black;
            this.input_name.Size = new System.Drawing.Size(150, 29);
            this.input_name.Style = Sunny.UI.UIStyle.Custom;
            this.input_name.TabIndex = 152;
            this.input_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirm
            // 
            this.confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm.FillColor = System.Drawing.Color.White;
            this.confirm.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.confirm.FillPressColor = System.Drawing.Color.Lime;
            this.confirm.FillSelectedColor = System.Drawing.Color.White;
            this.confirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.confirm.ForeColor = System.Drawing.Color.Black;
            this.confirm.ForeHoverColor = System.Drawing.Color.DarkRed;
            this.confirm.ForePressColor = System.Drawing.Color.Red;
            this.confirm.Location = new System.Drawing.Point(225, 119);
            this.confirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.confirm.Name = "confirm";
            this.confirm.RectColor = System.Drawing.Color.Black;
            this.confirm.RectDisableColor = System.Drawing.Color.Transparent;
            this.confirm.RectHoverColor = System.Drawing.Color.Lime;
            this.confirm.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.confirm.RectSelectedColor = System.Drawing.Color.Lime;
            this.confirm.Size = new System.Drawing.Size(71, 25);
            this.confirm.Style = Sunny.UI.UIStyle.Custom;
            this.confirm.StyleCustomMode = true;
            this.confirm.TabIndex = 149;
            this.confirm.Text = "확인";
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel7.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel7.Location = new System.Drawing.Point(-113, 83);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(585, 29);
            this.uiLabel7.TabIndex = 142;
            this.uiLabel7.Text = "이름을 입력해주세요.";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel2.Location = new System.Drawing.Point(-112, 160);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(585, 29);
            this.uiLabel2.TabIndex = 155;
            this.uiLabel2.Text = "회원님의 이름으로 검색된 고객번호입니다.";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_person_name_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 290);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.output_memberdigit);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.Top_panel);
            this.Name = "Add_person_name_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Add_person_name_search_Load);
            this.Top_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel Top_panel;
        private Sunny.UI.UIButton but_close;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel output_memberdigit;
        private Sunny.UI.UITextBox input_name;
        private Sunny.UI.UISymbolButton confirm;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel2;
    }
}