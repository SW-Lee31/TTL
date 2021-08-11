
namespace View_structure_0811.UI.UI_contents.Sign
{
    partial class Sign_in
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
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.link_sign_found = new Sunny.UI.UILinkLabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.input_pw = new Sunny.UI.UITextBox();
            this.input_id = new Sunny.UI.UITextBox();
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
            this.Top_panel.Size = new System.Drawing.Size(380, 66);
            this.Top_panel.Style = Sunny.UI.UIStyle.Custom;
            this.Top_panel.TabIndex = 1;
            this.Top_panel.Text = "uiFlowLayoutPanel1";
            this.Top_panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_close
            // 
            this.but_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_close.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_close.Location = new System.Drawing.Point(343, 2);
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
            this.uiLabel1.Size = new System.Drawing.Size(378, 62);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 18;
            this.uiLabel1.Text = "로그인";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiLinkLabel1.Font = new System.Drawing.Font("양재벨라체M", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.uiLinkLabel1.Location = new System.Drawing.Point(101, 349);
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.Size = new System.Drawing.Size(188, 23);
            this.uiLinkLabel1.TabIndex = 58;
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.Text = "아직 가입하지 않았습니까?";
            this.uiLinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiLinkLabel1.Click += new System.EventHandler(this.uiLinkLabel1_Click_1);
            // 
            // link_sign_found
            // 
            this.link_sign_found.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.link_sign_found.Font = new System.Drawing.Font("양재벨라체M", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.link_sign_found.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.link_sign_found.LinkColor = System.Drawing.Color.RoyalBlue;
            this.link_sign_found.Location = new System.Drawing.Point(101, 384);
            this.link_sign_found.Name = "link_sign_found";
            this.link_sign_found.Size = new System.Drawing.Size(188, 23);
            this.link_sign_found.TabIndex = 57;
            this.link_sign_found.TabStop = true;
            this.link_sign_found.Text = "아이디/ 비밀번호를 잊었습니까?";
            this.link_sign_found.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_sign_found.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.Black;
            this.uiButton1.Font = new System.Drawing.Font("양재벨라체M", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiButton1.Location = new System.Drawing.Point(133, 244);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 30;
            this.uiButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiButton1.Size = new System.Drawing.Size(117, 38);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 52;
            this.uiButton1.Text = "LOGIN";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Black;
            this.uiLabel3.Location = new System.Drawing.Point(62, 176);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(84, 40);
            this.uiLabel3.TabIndex = 56;
            this.uiLabel3.Text = "Password";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(99, 105);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(28, 40);
            this.uiLabel2.TabIndex = 55;
            this.uiLabel2.Text = "ID";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_pw
            // 
            this.input_pw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_pw.FillColor = System.Drawing.Color.White;
            this.input_pw.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_pw.Location = new System.Drawing.Point(151, 183);
            this.input_pw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_pw.Maximum = 2147483647D;
            this.input_pw.Minimum = -2147483648D;
            this.input_pw.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_pw.Name = "input_pw";
            this.input_pw.PasswordChar = '*';
            this.input_pw.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.input_pw.Size = new System.Drawing.Size(150, 29);
            this.input_pw.Style = Sunny.UI.UIStyle.Custom;
            this.input_pw.TabIndex = 54;
            this.input_pw.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_id
            // 
            this.input_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_id.FillColor = System.Drawing.Color.White;
            this.input_id.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_id.Location = new System.Drawing.Point(151, 111);
            this.input_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_id.Maximum = 2147483647D;
            this.input_id.Minimum = -2147483648D;
            this.input_id.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_id.Name = "input_id";
            this.input_id.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.input_id.Size = new System.Drawing.Size(150, 29);
            this.input_id.Style = Sunny.UI.UIStyle.Custom;
            this.input_id.TabIndex = 53;
            this.input_id.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.uiLinkLabel1);
            this.Controls.Add(this.link_sign_found);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.input_pw);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.Top_panel);
            this.Name = "Sign_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sign_in_Load);
            this.Top_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel Top_panel;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton but_close;
        private Sunny.UI.UILinkLabel uiLinkLabel1;
        private Sunny.UI.UILinkLabel link_sign_found;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox input_pw;
        private Sunny.UI.UITextBox input_id;
    }
}