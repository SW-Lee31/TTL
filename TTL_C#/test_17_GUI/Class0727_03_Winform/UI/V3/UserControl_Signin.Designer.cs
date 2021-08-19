
namespace Class0727_03_Winform.UI
{
    partial class UserControl_Signin
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.link_sign_found = new Sunny.UI.UILinkLabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.input_pw = new Sunny.UI.UITextBox();
            this.input_id = new Sunny.UI.UITextBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.but_back = new Sunny.UI.UISymbolButton();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.uiLinkLabel1.Font = new System.Drawing.Font("양재벨라체M", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.uiLinkLabel1.Location = new System.Drawing.Point(70, 388);
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.Size = new System.Drawing.Size(188, 23);
            this.uiLinkLabel1.TabIndex = 60;
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.Text = "아직 가입하지 않았습니까?";
            this.uiLinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // link_sign_found
            // 
            this.link_sign_found.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link_sign_found.Font = new System.Drawing.Font("양재벨라체M", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.link_sign_found.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.link_sign_found.LinkColor = System.Drawing.Color.Gray;
            this.link_sign_found.Location = new System.Drawing.Point(70, 423);
            this.link_sign_found.Name = "link_sign_found";
            this.link_sign_found.Size = new System.Drawing.Size(188, 23);
            this.link_sign_found.TabIndex = 59;
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
            this.uiButton1.Location = new System.Drawing.Point(102, 283);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 30;
            this.uiButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiButton1.Size = new System.Drawing.Size(117, 38);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 53;
            this.uiButton1.Text = "로그인";
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Black;
            this.uiLabel3.Location = new System.Drawing.Point(31, 215);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(82, 40);
            this.uiLabel3.TabIndex = 58;
            this.uiLabel3.Text = "비밀번호";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(68, 144);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(28, 40);
            this.uiLabel2.TabIndex = 57;
            this.uiLabel2.Text = "ID";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_pw
            // 
            this.input_pw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_pw.FillColor = System.Drawing.Color.White;
            this.input_pw.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_pw.Location = new System.Drawing.Point(120, 222);
            this.input_pw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_pw.Maximum = 2147483647D;
            this.input_pw.Minimum = -2147483648D;
            this.input_pw.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_pw.Name = "input_pw";
            this.input_pw.PasswordChar = '*';
            this.input_pw.RectColor = System.Drawing.Color.Transparent;
            this.input_pw.Size = new System.Drawing.Size(150, 29);
            this.input_pw.Style = Sunny.UI.UIStyle.Custom;
            this.input_pw.TabIndex = 56;
            this.input_pw.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_id
            // 
            this.input_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_id.FillColor = System.Drawing.Color.White;
            this.input_id.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_id.Location = new System.Drawing.Point(120, 150);
            this.input_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_id.Maximum = 2147483647D;
            this.input_id.Minimum = -2147483648D;
            this.input_id.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_id.Name = "input_id";
            this.input_id.RectColor = System.Drawing.Color.Transparent;
            this.input_id.Size = new System.Drawing.Size(150, 29);
            this.input_id.Style = Sunny.UI.UIStyle.Custom;
            this.input_id.TabIndex = 55;
            this.input_id.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel4);
            this.uiPanel1.Controls.Add(this.but_back);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.SeaGreen;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Silver;
            this.uiPanel1.Size = new System.Drawing.Size(312, 63);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 62;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("양재벨라체M", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel4.Location = new System.Drawing.Point(109, 10);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(110, 53);
            this.uiLabel4.TabIndex = 63;
            this.uiLabel4.Text = "로그인";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // but_back
            // 
            this.but_back.BackColor = System.Drawing.Color.Transparent;
            this.but_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_back.FillColor = System.Drawing.Color.White;
            this.but_back.FillHoverColor = System.Drawing.Color.Silver;
            this.but_back.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.but_back.FillSelectedColor = System.Drawing.Color.White;
            this.but_back.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_back.ForeColor = System.Drawing.Color.Black;
            this.but_back.Location = new System.Drawing.Point(14, 10);
            this.but_back.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_back.Name = "but_back";
            this.but_back.RectColor = System.Drawing.Color.Transparent;
            this.but_back.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_back.RectPressColor = System.Drawing.Color.Transparent;
            this.but_back.RectSelectedColor = System.Drawing.Color.Transparent;
            this.but_back.Size = new System.Drawing.Size(41, 39);
            this.but_back.Style = Sunny.UI.UIStyle.Custom;
            this.but_back.Symbol = 61536;
            this.but_back.SymbolSize = 30;
            this.but_back.TabIndex = 62;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // UserControl_Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiLinkLabel1);
            this.Controls.Add(this.link_sign_found);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.input_pw);
            this.Controls.Add(this.input_id);
            this.Name = "UserControl_Signin";
            this.Size = new System.Drawing.Size(312, 471);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILinkLabel uiLinkLabel1;
        private Sunny.UI.UILinkLabel link_sign_found;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox input_pw;
        private Sunny.UI.UITextBox input_id;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UISymbolButton but_back;
    }
}
