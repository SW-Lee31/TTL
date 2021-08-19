
namespace Class0727_03_Winform.UI
{
    partial class UserControl_Home
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
            this.uiLinkLabel2 = new Sunny.UI.UILinkLabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.uiSymbolButton4 = new Sunny.UI.UISymbolButton();
            this.uiHeaderButton9 = new Sunny.UI.UIHeaderButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.uiHeaderButton8 = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton7 = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton6 = new Sunny.UI.UIHeaderButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.uiLinkLabel3 = new Sunny.UI.UILinkLabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiPanel5.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLinkLabel2
            // 
            this.uiLinkLabel2.ActiveLinkColor = System.Drawing.Color.SeaGreen;
            this.uiLinkLabel2.BackColor = System.Drawing.Color.White;
            this.uiLinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiLinkLabel2.DisabledLinkColor = System.Drawing.Color.White;
            this.uiLinkLabel2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLinkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.uiLinkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel2.Location = new System.Drawing.Point(699, 366);
            this.uiLinkLabel2.Name = "uiLinkLabel2";
            this.uiLinkLabel2.Size = new System.Drawing.Size(138, 21);
            this.uiLinkLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLinkLabel2.TabIndex = 37;
            this.uiLinkLabel2.TabStop = true;
            this.uiLinkLabel2.Text = "보안 상태 점검  > ";
            this.uiLinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.White;
            this.uiLabel5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel5.Location = new System.Drawing.Point(266, 308);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(337, 28);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 34;
            this.uiLabel5.Text = "최근 업데이트: 조금 전 | 최근 검사: 15일 전";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.White;
            this.uiLabel4.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel4.Location = new System.Drawing.Point(207, 247);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(462, 54);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 32;
            this.uiLabel4.Text = "PC의 보안 상태가 안전합니다.";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.Click += new System.EventHandler(this.uiLabel4_Click);
            // 
            // uiPanel5
            // 
            this.uiPanel5.Controls.Add(this.uiSymbolButton4);
            this.uiPanel5.Controls.Add(this.uiHeaderButton9);
            this.uiPanel5.Controls.Add(this.uiSymbolButton3);
            this.uiPanel5.Controls.Add(this.uiHeaderButton8);
            this.uiPanel5.Controls.Add(this.uiHeaderButton7);
            this.uiPanel5.Controls.Add(this.uiHeaderButton6);
            this.uiPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel5.FillColor = System.Drawing.Color.White;
            this.uiPanel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel5.Location = new System.Drawing.Point(0, 407);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.RectColor = System.Drawing.Color.Gray;
            this.uiPanel5.Size = new System.Drawing.Size(851, 149);
            this.uiPanel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel5.TabIndex = 31;
            this.uiPanel5.Text = null;
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolButton4
            // 
            this.uiSymbolButton4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton4.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiSymbolButton4.FillColor = System.Drawing.Color.White;
            this.uiSymbolButton4.FillHoverColor = System.Drawing.Color.White;
            this.uiSymbolButton4.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiSymbolButton4.FillSelectedColor = System.Drawing.Color.White;
            this.uiSymbolButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton4.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolButton4.ForeHoverColor = System.Drawing.Color.Black;
            this.uiSymbolButton4.ForePressColor = System.Drawing.Color.Black;
            this.uiSymbolButton4.ForeSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.Location = new System.Drawing.Point(529, 0);
            this.uiSymbolButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton4.Name = "uiSymbolButton4";
            this.uiSymbolButton4.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.Size = new System.Drawing.Size(31, 149);
            this.uiSymbolButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton4.Symbol = 61700;
            this.uiSymbolButton4.SymbolSize = 30;
            this.uiSymbolButton4.TabIndex = 19;
            this.uiSymbolButton4.Click += new System.EventHandler(this.uiSymbolButton4_Click);
            // 
            // uiHeaderButton9
            // 
            this.uiHeaderButton9.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton9.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton9.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiHeaderButton9.FillColor = System.Drawing.Color.White;
            this.uiHeaderButton9.FillHoverColor = System.Drawing.Color.White;
            this.uiHeaderButton9.FillPressColor = System.Drawing.Color.White;
            this.uiHeaderButton9.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiHeaderButton9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiHeaderButton9.ForeColor = System.Drawing.Color.Black;
            this.uiHeaderButton9.ForeHoverColor = System.Drawing.Color.Black;
            this.uiHeaderButton9.ForePressColor = System.Drawing.Color.Black;
            this.uiHeaderButton9.ForeSelectedColor = System.Drawing.Color.Black;
            this.uiHeaderButton9.Location = new System.Drawing.Point(560, 0);
            this.uiHeaderButton9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton9.Name = "uiHeaderButton9";
            this.uiHeaderButton9.Padding = new System.Windows.Forms.Padding(10, 35, 10, 20);
            this.uiHeaderButton9.Radius = 0;
            this.uiHeaderButton9.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton9.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.uiHeaderButton9.Size = new System.Drawing.Size(262, 149);
            this.uiHeaderButton9.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton9.Symbol = 61689;
            this.uiHeaderButton9.SymbolColor = System.Drawing.Color.Black;
            this.uiHeaderButton9.SymbolSize = 55;
            this.uiHeaderButton9.TabIndex = 18;
            this.uiHeaderButton9.Text = "PC 주치의";
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.White;
            this.uiSymbolButton3.FillHoverColor = System.Drawing.Color.White;
            this.uiSymbolButton3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiSymbolButton3.FillSelectedColor = System.Drawing.Color.White;
            this.uiSymbolButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton3.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolButton3.ForeHoverColor = System.Drawing.Color.Black;
            this.uiSymbolButton3.ForePressColor = System.Drawing.Color.Black;
            this.uiSymbolButton3.ForeSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Location = new System.Drawing.Point(822, 0);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Size = new System.Drawing.Size(29, 149);
            this.uiSymbolButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton3.Symbol = 61701;
            this.uiSymbolButton3.SymbolSize = 30;
            this.uiSymbolButton3.TabIndex = 17;
            // 
            // uiHeaderButton8
            // 
            this.uiHeaderButton8.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton8.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton8.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiHeaderButton8.FillColor = System.Drawing.Color.White;
            this.uiHeaderButton8.FillHoverColor = System.Drawing.Color.White;
            this.uiHeaderButton8.FillPressColor = System.Drawing.Color.White;
            this.uiHeaderButton8.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiHeaderButton8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiHeaderButton8.ForeColor = System.Drawing.Color.Black;
            this.uiHeaderButton8.ForeHoverColor = System.Drawing.Color.Black;
            this.uiHeaderButton8.ForePressColor = System.Drawing.Color.Black;
            this.uiHeaderButton8.ForeSelectedColor = System.Drawing.Color.Black;
            this.uiHeaderButton8.Location = new System.Drawing.Point(356, 0);
            this.uiHeaderButton8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton8.Name = "uiHeaderButton8";
            this.uiHeaderButton8.Padding = new System.Windows.Forms.Padding(10, 35, 10, 20);
            this.uiHeaderButton8.Radius = 0;
            this.uiHeaderButton8.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton8.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton8.Size = new System.Drawing.Size(178, 149);
            this.uiHeaderButton8.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton8.Symbol = 261606;
            this.uiHeaderButton8.SymbolColor = System.Drawing.Color.Black;
            this.uiHeaderButton8.SymbolSize = 55;
            this.uiHeaderButton8.TabIndex = 4;
            this.uiHeaderButton8.Text = "ONE CLICK";
            // 
            // uiHeaderButton7
            // 
            this.uiHeaderButton7.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton7.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton7.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiHeaderButton7.FillColor = System.Drawing.Color.White;
            this.uiHeaderButton7.FillHoverColor = System.Drawing.Color.White;
            this.uiHeaderButton7.FillPressColor = System.Drawing.Color.White;
            this.uiHeaderButton7.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiHeaderButton7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiHeaderButton7.ForeColor = System.Drawing.Color.Black;
            this.uiHeaderButton7.ForeHoverColor = System.Drawing.Color.Black;
            this.uiHeaderButton7.ForePressColor = System.Drawing.Color.Black;
            this.uiHeaderButton7.ForeSelectedColor = System.Drawing.Color.Black;
            this.uiHeaderButton7.Location = new System.Drawing.Point(178, 0);
            this.uiHeaderButton7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton7.Name = "uiHeaderButton7";
            this.uiHeaderButton7.Padding = new System.Windows.Forms.Padding(10, 35, 10, 20);
            this.uiHeaderButton7.Radius = 0;
            this.uiHeaderButton7.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton7.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton7.Size = new System.Drawing.Size(178, 149);
            this.uiHeaderButton7.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton7.Symbol = 61691;
            this.uiHeaderButton7.SymbolColor = System.Drawing.Color.Black;
            this.uiHeaderButton7.SymbolSize = 64;
            this.uiHeaderButton7.TabIndex = 3;
            this.uiHeaderButton7.Text = "빠른 검사";
            // 
            // uiHeaderButton6
            // 
            this.uiHeaderButton6.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton6.CircleHoverColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton6.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiHeaderButton6.FillColor = System.Drawing.Color.White;
            this.uiHeaderButton6.FillHoverColor = System.Drawing.Color.White;
            this.uiHeaderButton6.FillPressColor = System.Drawing.Color.White;
            this.uiHeaderButton6.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiHeaderButton6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiHeaderButton6.ForeColor = System.Drawing.Color.Black;
            this.uiHeaderButton6.ForeHoverColor = System.Drawing.Color.Black;
            this.uiHeaderButton6.ForePressColor = System.Drawing.Color.Black;
            this.uiHeaderButton6.ForeSelectedColor = System.Drawing.Color.Black;
            this.uiHeaderButton6.Location = new System.Drawing.Point(0, 0);
            this.uiHeaderButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton6.Name = "uiHeaderButton6";
            this.uiHeaderButton6.Padding = new System.Windows.Forms.Padding(10, 35, 10, 20);
            this.uiHeaderButton6.Radius = 0;
            this.uiHeaderButton6.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton6.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton6.Size = new System.Drawing.Size(178, 149);
            this.uiHeaderButton6.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton6.Symbol = 57389;
            this.uiHeaderButton6.SymbolColor = System.Drawing.Color.Black;
            this.uiHeaderButton6.SymbolSize = 64;
            this.uiHeaderButton6.TabIndex = 2;
            this.uiHeaderButton6.Text = "PC 최적화";
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.White;
            this.uiPanel1.Controls.Add(this.uiPanel4);
            this.uiPanel1.Controls.Add(this.uiPanel3);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.FillColor = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 556);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Silver;
            this.uiPanel1.Size = new System.Drawing.Size(851, 30);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 30;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.uiLabel3);
            this.uiPanel4.Controls.Add(this.uiLinkLabel1);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel4.FillColor = System.Drawing.Color.White;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(560, 0);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel4.Size = new System.Drawing.Size(291, 30);
            this.uiPanel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel4.TabIndex = 1;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.White;
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel3.Location = new System.Drawing.Point(0, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.uiLabel3.Size = new System.Drawing.Size(209, 30);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "엔진 버전: 2021.07.29.01";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.uiLinkLabel1.BackColor = System.Drawing.Color.White;
            this.uiLinkLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiLinkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLinkLabel1.ForeColor = System.Drawing.Color.Gray;
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.uiLinkLabel1.Location = new System.Drawing.Point(209, 0);
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.uiLinkLabel1.Size = new System.Drawing.Size(82, 30);
            this.uiLinkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLinkLabel1.TabIndex = 0;
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.Text = "업데이트";
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.uiLinkLabel3);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel3.FillColor = System.Drawing.Color.White;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(0, 0);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel3.Size = new System.Drawing.Size(499, 30);
            this.uiPanel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel3.TabIndex = 0;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLinkLabel3
            // 
            this.uiLinkLabel3.ActiveLinkColor = System.Drawing.Color.Gray;
            this.uiLinkLabel3.BackColor = System.Drawing.Color.White;
            this.uiLinkLabel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiLinkLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLinkLabel3.ForeColor = System.Drawing.Color.Gray;
            this.uiLinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.uiLinkLabel3.LinkColor = System.Drawing.Color.Gray;
            this.uiLinkLabel3.Location = new System.Drawing.Point(0, 0);
            this.uiLinkLabel3.Name = "uiLinkLabel3";
            this.uiLinkLabel3.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.uiLinkLabel3.Size = new System.Drawing.Size(452, 30);
            this.uiLinkLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLinkLabel3.TabIndex = 2;
            this.uiLinkLabel3.TabStop = true;
            this.uiLinkLabel3.Text = "높은 가성비로 1PC의 랜섬웨어까지 완벽한 V3 36클리닉 SOLO";
            this.uiLinkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.BackColor = System.Drawing.Color.White;
            this.cxFlatPictureBox1.Image = global::Class0727_03_Winform.Properties.Resources.check_animation1;
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(285, 60);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(310, 177);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 33;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(0, 555);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(851, 2);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 38;
            // 
            // uiLine2
            // 
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.LineColor = System.Drawing.Color.Gray;
            this.uiLine2.Location = new System.Drawing.Point(0, 406);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(851, 2);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 39;
            // 
            // UserControl_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiLinkLabel2);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiPanel5);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "UserControl_Home";
            this.Size = new System.Drawing.Size(851, 586);
            this.Load += new System.EventHandler(this.UserControl_Home_Load);
            this.uiPanel5.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILinkLabel uiLinkLabel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UISymbolButton uiSymbolButton4;
        private Sunny.UI.UIHeaderButton uiHeaderButton9;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UIHeaderButton uiHeaderButton8;
        private Sunny.UI.UIHeaderButton uiHeaderButton7;
        private Sunny.UI.UIHeaderButton uiHeaderButton6;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILinkLabel uiLinkLabel1;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UILinkLabel uiLinkLabel3;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
    }
}
