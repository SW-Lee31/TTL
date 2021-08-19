
namespace Class0727_03_Winform.UI
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
            this.but_back = new Sunny.UI.UISymbolButton();
            this.input_id = new Sunny.UI.UITextBox();
            this.input_pw = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.link_sign_found = new Sunny.UI.UILinkLabel();
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // but_back
            // 
            this.but_back.BackColor = System.Drawing.Color.Transparent;
            this.but_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_back.FillColor = System.Drawing.Color.Transparent;
            this.but_back.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.but_back.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.but_back.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.but_back.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_back.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_back.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_back.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_back.Location = new System.Drawing.Point(12, 12);
            this.but_back.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_back.Name = "but_back";
            this.but_back.RectColor = System.Drawing.Color.White;
            this.but_back.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_back.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_back.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_back.Size = new System.Drawing.Size(41, 39);
            this.but_back.Style = Sunny.UI.UIStyle.Custom;
            this.but_back.Symbol = 61536;
            this.but_back.SymbolSize = 30;
            this.but_back.TabIndex = 42;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // input_id
            // 
            this.input_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_id.FillColor = System.Drawing.Color.White;
            this.input_id.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_id.Location = new System.Drawing.Point(138, 134);
            this.input_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_id.Maximum = 2147483647D;
            this.input_id.Minimum = -2147483648D;
            this.input_id.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_id.Name = "input_id";
            this.input_id.RectColor = System.Drawing.Color.Transparent;
            this.input_id.Size = new System.Drawing.Size(150, 29);
            this.input_id.Style = Sunny.UI.UIStyle.Custom;
            this.input_id.TabIndex = 43;
            this.input_id.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_pw
            // 
            this.input_pw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_pw.FillColor = System.Drawing.Color.White;
            this.input_pw.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_pw.Location = new System.Drawing.Point(138, 206);
            this.input_pw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_pw.Maximum = 2147483647D;
            this.input_pw.Minimum = -2147483648D;
            this.input_pw.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_pw.Name = "input_pw";
            this.input_pw.PasswordChar = '*';
            this.input_pw.RectColor = System.Drawing.Color.Transparent;
            this.input_pw.Size = new System.Drawing.Size(150, 29);
            this.input_pw.Style = Sunny.UI.UIStyle.Custom;
            this.input_pw.TabIndex = 44;
            this.input_pw.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(86, 128);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(28, 40);
            this.uiLabel2.TabIndex = 46;
            this.uiLabel2.Text = "ID";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Black;
            this.uiLabel3.Location = new System.Drawing.Point(49, 199);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(84, 40);
            this.uiLabel3.TabIndex = 47;
            this.uiLabel3.Text = "Password";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.Black;
            this.uiButton1.Font = new System.Drawing.Font("양재벨라체M", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiButton1.Location = new System.Drawing.Point(120, 267);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 30;
            this.uiButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiButton1.Size = new System.Drawing.Size(117, 38);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 2;
            this.uiButton1.Text = "LOGIN";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // link_sign_found
            // 
            this.link_sign_found.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.link_sign_found.Font = new System.Drawing.Font("양재벨라체M", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.link_sign_found.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.link_sign_found.LinkColor = System.Drawing.Color.RoyalBlue;
            this.link_sign_found.Location = new System.Drawing.Point(88, 407);
            this.link_sign_found.Name = "link_sign_found";
            this.link_sign_found.Size = new System.Drawing.Size(188, 23);
            this.link_sign_found.TabIndex = 49;
            this.link_sign_found.TabStop = true;
            this.link_sign_found.Text = "아이디/ 비밀번호를 잊었습니까?";
            this.link_sign_found.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_sign_found.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiLinkLabel1.Font = new System.Drawing.Font("양재벨라체M", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.uiLinkLabel1.Location = new System.Drawing.Point(88, 372);
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.Size = new System.Drawing.Size(188, 23);
            this.uiLinkLabel1.TabIndex = 51;
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.Text = "아직 가입하지 않았습니까?";
            this.uiLinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiLinkLabel1.Click += new System.EventHandler(this.uiLinkLabel1_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("양재벨라체M", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel4.ForeColor = System.Drawing.Color.White;
            this.uiLabel4.Location = new System.Drawing.Point(107, 9);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(145, 53);
            this.uiLabel4.TabIndex = 52;
            this.uiLabel4.Text = "SIGN IN";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.ControlBox = false;
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLinkLabel1);
            this.Controls.Add(this.link_sign_found);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.input_pw);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.but_back);
            this.Name = "Sign_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Add_customer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton but_back;
        private Sunny.UI.UITextBox input_id;
        private Sunny.UI.UITextBox input_pw;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILinkLabel link_sign_found;
        private Sunny.UI.UILinkLabel uiLinkLabel1;
        private Sunny.UI.UILabel uiLabel4;
    }
}