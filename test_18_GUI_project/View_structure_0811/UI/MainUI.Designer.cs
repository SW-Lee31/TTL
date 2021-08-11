
namespace View_structure_0811.UI
{
    partial class MainUI
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cxFlatPictureBox2 = new CxFlatUI.CxFlatPictureBox();
            this.but_info = new Sunny.UI.UIButton();
            this.but_mini = new Sunny.UI.UIButton();
            this.but_close = new Sunny.UI.UIButton();
            this.Right_panel = new Sunny.UI.UIFlowLayoutPanel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiHeaderButton5 = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton4 = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton3 = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton2 = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton1 = new Sunny.UI.UIHeaderButton();
            this.but_cus_add = new Sunny.UI.UIHeaderButton();
            this.main_panel = new System.Windows.Forms.Panel();
            this.Top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox2)).BeginInit();
            this.Right_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.White;
            this.Top_panel.Controls.Add(this.uiLabel1);
            this.Top_panel.Controls.Add(this.cxFlatPictureBox2);
            this.Top_panel.Controls.Add(this.but_info);
            this.Top_panel.Controls.Add(this.but_mini);
            this.Top_panel.Controls.Add(this.but_close);
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
            this.Top_panel.Size = new System.Drawing.Size(669, 66);
            this.Top_panel.Style = Sunny.UI.UIStyle.Custom;
            this.Top_panel.TabIndex = 0;
            this.Top_panel.Text = "uiFlowLayoutPanel1";
            this.Top_panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseMove);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Location = new System.Drawing.Point(2, 2);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(242, 62);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 18;
            this.uiLabel1.Text = "SW-Lee31 물류배송 V1.0.0";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cxFlatPictureBox2
            // 
            this.cxFlatPictureBox2.Image = global::View_structure_0811.Properties.Resources.Com_logo;
            this.cxFlatPictureBox2.Location = new System.Drawing.Point(12, 2);
            this.cxFlatPictureBox2.Name = "cxFlatPictureBox2";
            this.cxFlatPictureBox2.Size = new System.Drawing.Size(89, 56);
            this.cxFlatPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox2.TabIndex = 3;
            this.cxFlatPictureBox2.TabStop = false;
            // 
            // but_info
            // 
            this.but_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_info.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_info.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_info.Location = new System.Drawing.Point(562, 2);
            this.but_info.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_info.Name = "but_info";
            this.but_info.Size = new System.Drawing.Size(35, 62);
            this.but_info.Style = Sunny.UI.UIStyle.Custom;
            this.but_info.TabIndex = 6;
            this.but_info.Text = "?";
            this.but_info.Click += new System.EventHandler(this.but_info_Click);
            // 
            // but_mini
            // 
            this.but_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_mini.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_mini.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_mini.Location = new System.Drawing.Point(597, 2);
            this.but_mini.Margin = new System.Windows.Forms.Padding(3, 15, 15, 15);
            this.but_mini.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_mini.Name = "but_mini";
            this.but_mini.Size = new System.Drawing.Size(35, 62);
            this.but_mini.Style = Sunny.UI.UIStyle.Custom;
            this.but_mini.TabIndex = 4;
            this.but_mini.Text = "__";
            this.but_mini.Click += new System.EventHandler(this.but_mini_Click);
            // 
            // but_close
            // 
            this.but_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_close.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_close.Location = new System.Drawing.Point(632, 2);
            this.but_close.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(35, 62);
            this.but_close.Style = Sunny.UI.UIStyle.Custom;
            this.but_close.TabIndex = 3;
            this.but_close.Text = "X";
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // Right_panel
            // 
            this.Right_panel.Controls.Add(this.uiLine1);
            this.Right_panel.Controls.Add(this.uiHeaderButton5);
            this.Right_panel.Controls.Add(this.uiHeaderButton4);
            this.Right_panel.Controls.Add(this.uiHeaderButton3);
            this.Right_panel.Controls.Add(this.uiHeaderButton2);
            this.Right_panel.Controls.Add(this.uiHeaderButton1);
            this.Right_panel.Controls.Add(this.but_cus_add);
            this.Right_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Right_panel.FillColor = System.Drawing.Color.White;
            this.Right_panel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Right_panel.Location = new System.Drawing.Point(0, 66);
            this.Right_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Right_panel.MinimumSize = new System.Drawing.Size(1, 1);
            this.Right_panel.Name = "Right_panel";
            this.Right_panel.Padding = new System.Windows.Forms.Padding(2);
            this.Right_panel.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Right_panel.RectColor = System.Drawing.Color.Transparent;
            this.Right_panel.Size = new System.Drawing.Size(118, 396);
            this.Right_panel.Style = Sunny.UI.UIStyle.Custom;
            this.Right_panel.TabIndex = 1;
            this.Right_panel.Text = "uiFlowLayoutPanel2";
            this.Right_panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLine1
            // 
            this.uiLine1.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.Location = new System.Drawing.Point(116, 3);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(3, 387);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 0;
            this.uiLine1.Text = "uiLine1";
            // 
            // uiHeaderButton5
            // 
            this.uiHeaderButton5.CircleColor = System.Drawing.Color.White;
            this.uiHeaderButton5.CircleHoverColor = System.Drawing.Color.White;
            this.uiHeaderButton5.CircleSize = 0;
            this.uiHeaderButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiHeaderButton5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiHeaderButton5.Location = new System.Drawing.Point(61, 334);
            this.uiHeaderButton5.Margin = new System.Windows.Forms.Padding(0);
            this.uiHeaderButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton5.Name = "uiHeaderButton5";
            this.uiHeaderButton5.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.uiHeaderButton5.Radius = 0;
            this.uiHeaderButton5.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton5.Size = new System.Drawing.Size(59, 60);
            this.uiHeaderButton5.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton5.Symbol = 61459;
            this.uiHeaderButton5.SymbolColor = System.Drawing.Color.DimGray;
            this.uiHeaderButton5.SymbolSize = 30;
            this.uiHeaderButton5.TabIndex = 7;
            // 
            // uiHeaderButton4
            // 
            this.uiHeaderButton4.CircleColor = System.Drawing.Color.White;
            this.uiHeaderButton4.CircleHoverColor = System.Drawing.Color.White;
            this.uiHeaderButton4.CircleSize = 0;
            this.uiHeaderButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiHeaderButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiHeaderButton4.Location = new System.Drawing.Point(2, 334);
            this.uiHeaderButton4.Margin = new System.Windows.Forms.Padding(0);
            this.uiHeaderButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton4.Name = "uiHeaderButton4";
            this.uiHeaderButton4.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.uiHeaderButton4.Radius = 0;
            this.uiHeaderButton4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton4.Size = new System.Drawing.Size(59, 60);
            this.uiHeaderButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton4.Symbol = 57358;
            this.uiHeaderButton4.SymbolColor = System.Drawing.Color.DimGray;
            this.uiHeaderButton4.SymbolSize = 30;
            this.uiHeaderButton4.TabIndex = 6;
            // 
            // uiHeaderButton3
            // 
            this.uiHeaderButton3.CircleColor = System.Drawing.Color.White;
            this.uiHeaderButton3.CircleHoverColor = System.Drawing.Color.White;
            this.uiHeaderButton3.CircleSize = 0;
            this.uiHeaderButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiHeaderButton3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiHeaderButton3.Location = new System.Drawing.Point(2, 251);
            this.uiHeaderButton3.Margin = new System.Windows.Forms.Padding(0);
            this.uiHeaderButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton3.Name = "uiHeaderButton3";
            this.uiHeaderButton3.Padding = new System.Windows.Forms.Padding(0, 35, 0, 8);
            this.uiHeaderButton3.Radius = 0;
            this.uiHeaderButton3.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton3.Size = new System.Drawing.Size(114, 83);
            this.uiHeaderButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton3.Symbol = 361649;
            this.uiHeaderButton3.SymbolColor = System.Drawing.Color.Black;
            this.uiHeaderButton3.TabIndex = 5;
            this.uiHeaderButton3.Text = "배송 조회";
            // 
            // uiHeaderButton2
            // 
            this.uiHeaderButton2.CircleColor = System.Drawing.Color.White;
            this.uiHeaderButton2.CircleHoverColor = System.Drawing.Color.White;
            this.uiHeaderButton2.CircleSize = 0;
            this.uiHeaderButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiHeaderButton2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiHeaderButton2.Location = new System.Drawing.Point(2, 168);
            this.uiHeaderButton2.Margin = new System.Windows.Forms.Padding(0);
            this.uiHeaderButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton2.Name = "uiHeaderButton2";
            this.uiHeaderButton2.Padding = new System.Windows.Forms.Padding(0, 35, 0, 8);
            this.uiHeaderButton2.Radius = 0;
            this.uiHeaderButton2.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton2.Size = new System.Drawing.Size(114, 83);
            this.uiHeaderButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton2.Symbol = 61875;
            this.uiHeaderButton2.SymbolColor = System.Drawing.Color.Black;
            this.uiHeaderButton2.TabIndex = 4;
            this.uiHeaderButton2.Text = "재고관리";
            // 
            // uiHeaderButton1
            // 
            this.uiHeaderButton1.CircleColor = System.Drawing.Color.White;
            this.uiHeaderButton1.CircleHoverColor = System.Drawing.Color.White;
            this.uiHeaderButton1.CircleSize = 0;
            this.uiHeaderButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiHeaderButton1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiHeaderButton1.Location = new System.Drawing.Point(2, 85);
            this.uiHeaderButton1.Margin = new System.Windows.Forms.Padding(0);
            this.uiHeaderButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton1.Name = "uiHeaderButton1";
            this.uiHeaderButton1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 8);
            this.uiHeaderButton1.Radius = 0;
            this.uiHeaderButton1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton1.Size = new System.Drawing.Size(114, 83);
            this.uiHeaderButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton1.Symbol = 361888;
            this.uiHeaderButton1.SymbolColor = System.Drawing.Color.Black;
            this.uiHeaderButton1.TabIndex = 3;
            this.uiHeaderButton1.Text = "고객정보 조회";
            // 
            // but_cus_add
            // 
            this.but_cus_add.CircleColor = System.Drawing.Color.White;
            this.but_cus_add.CircleHoverColor = System.Drawing.Color.White;
            this.but_cus_add.CircleSize = 0;
            this.but_cus_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_cus_add.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but_cus_add.Location = new System.Drawing.Point(2, 2);
            this.but_cus_add.Margin = new System.Windows.Forms.Padding(0);
            this.but_cus_add.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_cus_add.Name = "but_cus_add";
            this.but_cus_add.Padding = new System.Windows.Forms.Padding(0, 35, 0, 8);
            this.but_cus_add.Radius = 0;
            this.but_cus_add.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_cus_add.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_cus_add.Size = new System.Drawing.Size(114, 83);
            this.but_cus_add.Style = Sunny.UI.UIStyle.Custom;
            this.but_cus_add.Symbol = 62004;
            this.but_cus_add.SymbolColor = System.Drawing.Color.Black;
            this.but_cus_add.TabIndex = 0;
            this.but_cus_add.Text = "고객정보 추가";
            // 
            // main_panel
            // 
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.main_panel.Location = new System.Drawing.Point(118, 66);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(479, 396);
            this.main_panel.TabIndex = 2;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 462);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.Right_panel);
            this.Controls.Add(this.Top_panel);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.Top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox2)).EndInit();
            this.Right_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel Top_panel;
        private Sunny.UI.UIButton but_close;
        private Sunny.UI.UIFlowLayoutPanel Right_panel;
        private System.Windows.Forms.Panel main_panel;
        private Sunny.UI.UIButton but_mini;
        private Sunny.UI.UIButton but_info;
        private Sunny.UI.UIHeaderButton but_cus_add;
        private Sunny.UI.UIHeaderButton uiHeaderButton5;
        private Sunny.UI.UIHeaderButton uiHeaderButton4;
        private Sunny.UI.UIHeaderButton uiHeaderButton3;
        private Sunny.UI.UIHeaderButton uiHeaderButton2;
        private Sunny.UI.UIHeaderButton uiHeaderButton1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine1;
    }
}