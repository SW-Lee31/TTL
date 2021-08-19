
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
            this.but_info = new Sunny.UI.UIButton();
            this.but_mini = new Sunny.UI.UIButton();
            this.but_close = new Sunny.UI.UIButton();
            this.Right_panel = new Sunny.UI.UIFlowLayoutPanel();
            this.uiHeaderButton5 = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton4 = new Sunny.UI.UIHeaderButton();
            this.but_track = new Sunny.UI.UIHeaderButton();
            this.but_search = new Sunny.UI.UIHeaderButton();
            this.but_cus_add = new Sunny.UI.UIHeaderButton();
            this.but_home = new Sunny.UI.UIHeaderButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.main_panel = new System.Windows.Forms.Panel();
            this.cxFlatPictureBox2 = new CxFlatUI.CxFlatPictureBox();
            this.Top_panel.SuspendLayout();
            this.Right_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox2)).BeginInit();
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
            this.Top_panel.Click += new System.EventHandler(this.Top_panel_Click);
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
            // but_info
            // 
            this.but_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_info.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_info.FillColor = System.Drawing.Color.White;
            this.but_info.FillHoverColor = System.Drawing.Color.Silver;
            this.but_info.FillPressColor = System.Drawing.Color.Gray;
            this.but_info.FillSelectedColor = System.Drawing.Color.Gray;
            this.but_info.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_info.ForeColor = System.Drawing.Color.Silver;
            this.but_info.ForeHoverColor = System.Drawing.Color.Black;
            this.but_info.ForePressColor = System.Drawing.Color.Black;
            this.but_info.ForeSelectedColor = System.Drawing.Color.Black;
            this.but_info.Location = new System.Drawing.Point(562, 2);
            this.but_info.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_info.Name = "but_info";
            this.but_info.RectColor = System.Drawing.Color.Transparent;
            this.but_info.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_info.RectPressColor = System.Drawing.Color.Transparent;
            this.but_info.RectSelectedColor = System.Drawing.Color.Transparent;
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
            this.but_mini.FillColor = System.Drawing.Color.White;
            this.but_mini.FillHoverColor = System.Drawing.Color.Silver;
            this.but_mini.FillPressColor = System.Drawing.Color.Gray;
            this.but_mini.FillSelectedColor = System.Drawing.Color.Gray;
            this.but_mini.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_mini.ForeColor = System.Drawing.Color.Silver;
            this.but_mini.ForeHoverColor = System.Drawing.Color.Lime;
            this.but_mini.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_mini.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_mini.Location = new System.Drawing.Point(597, 2);
            this.but_mini.Margin = new System.Windows.Forms.Padding(3, 15, 15, 15);
            this.but_mini.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_mini.Name = "but_mini";
            this.but_mini.RectColor = System.Drawing.Color.Transparent;
            this.but_mini.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_mini.RectPressColor = System.Drawing.Color.Transparent;
            this.but_mini.RectSelectedColor = System.Drawing.Color.Transparent;
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
            this.but_close.FillColor = System.Drawing.Color.White;
            this.but_close.FillHoverColor = System.Drawing.Color.Silver;
            this.but_close.FillPressColor = System.Drawing.Color.Gray;
            this.but_close.FillSelectedColor = System.Drawing.Color.Gray;
            this.but_close.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_close.ForeColor = System.Drawing.Color.Silver;
            this.but_close.ForeHoverColor = System.Drawing.Color.Red;
            this.but_close.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.but_close.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.but_close.Location = new System.Drawing.Point(632, 2);
            this.but_close.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_close.Name = "but_close";
            this.but_close.RectColor = System.Drawing.Color.Transparent;
            this.but_close.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_close.RectPressColor = System.Drawing.Color.Transparent;
            this.but_close.RectSelectedColor = System.Drawing.Color.Transparent;
            this.but_close.Size = new System.Drawing.Size(35, 62);
            this.but_close.Style = Sunny.UI.UIStyle.Custom;
            this.but_close.TabIndex = 3;
            this.but_close.Text = "X";
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // Right_panel
            // 
            this.Right_panel.Controls.Add(this.uiHeaderButton5);
            this.Right_panel.Controls.Add(this.uiHeaderButton4);
            this.Right_panel.Controls.Add(this.but_track);
            this.Right_panel.Controls.Add(this.but_search);
            this.Right_panel.Controls.Add(this.but_cus_add);
            this.Right_panel.Controls.Add(this.but_home);
            this.Right_panel.Controls.Add(this.uiLine1);
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
            // uiHeaderButton5
            // 
            this.uiHeaderButton5.CircleColor = System.Drawing.Color.White;
            this.uiHeaderButton5.CircleHoverColor = System.Drawing.Color.White;
            this.uiHeaderButton5.CircleSize = 0;
            this.uiHeaderButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiHeaderButton5.FillColor = System.Drawing.Color.White;
            this.uiHeaderButton5.FillHoverColor = System.Drawing.Color.Silver;
            this.uiHeaderButton5.FillPressColor = System.Drawing.Color.Gray;
            this.uiHeaderButton5.FillSelectedColor = System.Drawing.Color.Gray;
            this.uiHeaderButton5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiHeaderButton5.ForeColor = System.Drawing.Color.Gray;
            this.uiHeaderButton5.ForeHoverColor = System.Drawing.Color.Black;
            this.uiHeaderButton5.ForePressColor = System.Drawing.Color.Black;
            this.uiHeaderButton5.ForeSelectedColor = System.Drawing.Color.Black;
            this.uiHeaderButton5.Location = new System.Drawing.Point(59, 334);
            this.uiHeaderButton5.Margin = new System.Windows.Forms.Padding(0);
            this.uiHeaderButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton5.Name = "uiHeaderButton5";
            this.uiHeaderButton5.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.uiHeaderButton5.Radius = 0;
            this.uiHeaderButton5.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton5.Size = new System.Drawing.Size(57, 60);
            this.uiHeaderButton5.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton5.Symbol = 61459;
            this.uiHeaderButton5.SymbolColor = System.Drawing.Color.DimGray;
            this.uiHeaderButton5.SymbolSize = 30;
            this.uiHeaderButton5.TabIndex = 15;
            // 
            // uiHeaderButton4
            // 
            this.uiHeaderButton4.CircleColor = System.Drawing.Color.White;
            this.uiHeaderButton4.CircleHoverColor = System.Drawing.Color.White;
            this.uiHeaderButton4.CircleSize = 0;
            this.uiHeaderButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiHeaderButton4.FillColor = System.Drawing.Color.White;
            this.uiHeaderButton4.FillHoverColor = System.Drawing.Color.Silver;
            this.uiHeaderButton4.FillPressColor = System.Drawing.Color.Gray;
            this.uiHeaderButton4.FillSelectedColor = System.Drawing.Color.Gray;
            this.uiHeaderButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiHeaderButton4.ForeColor = System.Drawing.Color.Gray;
            this.uiHeaderButton4.ForeHoverColor = System.Drawing.Color.Black;
            this.uiHeaderButton4.ForePressColor = System.Drawing.Color.Black;
            this.uiHeaderButton4.ForeSelectedColor = System.Drawing.Color.Black;
            this.uiHeaderButton4.Location = new System.Drawing.Point(2, 334);
            this.uiHeaderButton4.Margin = new System.Windows.Forms.Padding(0);
            this.uiHeaderButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton4.Name = "uiHeaderButton4";
            this.uiHeaderButton4.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.uiHeaderButton4.Radius = 0;
            this.uiHeaderButton4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton4.Size = new System.Drawing.Size(57, 60);
            this.uiHeaderButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton4.Symbol = 57358;
            this.uiHeaderButton4.SymbolColor = System.Drawing.Color.DimGray;
            this.uiHeaderButton4.SymbolSize = 30;
            this.uiHeaderButton4.TabIndex = 14;
            // 
            // but_track
            // 
            this.but_track.CircleColor = System.Drawing.Color.White;
            this.but_track.CircleHoverColor = System.Drawing.Color.White;
            this.but_track.CircleSize = 0;
            this.but_track.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_track.FillColor = System.Drawing.Color.White;
            this.but_track.FillHoverColor = System.Drawing.Color.Silver;
            this.but_track.FillPressColor = System.Drawing.Color.Gray;
            this.but_track.FillSelectedColor = System.Drawing.Color.Gray;
            this.but_track.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but_track.ForeColor = System.Drawing.Color.Gray;
            this.but_track.ForeHoverColor = System.Drawing.Color.Black;
            this.but_track.ForePressColor = System.Drawing.Color.Black;
            this.but_track.ForeSelectedColor = System.Drawing.Color.Black;
            this.but_track.Location = new System.Drawing.Point(2, 251);
            this.but_track.Margin = new System.Windows.Forms.Padding(0);
            this.but_track.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_track.Name = "but_track";
            this.but_track.Padding = new System.Windows.Forms.Padding(0, 35, 0, 8);
            this.but_track.Radius = 0;
            this.but_track.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_track.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_track.Size = new System.Drawing.Size(114, 83);
            this.but_track.Style = Sunny.UI.UIStyle.Custom;
            this.but_track.Symbol = 61442;
            this.but_track.SymbolColor = System.Drawing.Color.Black;
            this.but_track.TabIndex = 13;
            this.but_track.Text = "배송 추적";
            this.but_track.Click += new System.EventHandler(this.but_track_Click);
            // 
            // but_search
            // 
            this.but_search.CircleColor = System.Drawing.Color.White;
            this.but_search.CircleHoverColor = System.Drawing.Color.White;
            this.but_search.CircleSize = 0;
            this.but_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_search.FillColor = System.Drawing.Color.White;
            this.but_search.FillHoverColor = System.Drawing.Color.Silver;
            this.but_search.FillPressColor = System.Drawing.Color.Gray;
            this.but_search.FillSelectedColor = System.Drawing.Color.Gray;
            this.but_search.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but_search.ForeColor = System.Drawing.Color.Gray;
            this.but_search.ForeHoverColor = System.Drawing.Color.Black;
            this.but_search.ForePressColor = System.Drawing.Color.Black;
            this.but_search.ForeSelectedColor = System.Drawing.Color.Black;
            this.but_search.Location = new System.Drawing.Point(2, 168);
            this.but_search.Margin = new System.Windows.Forms.Padding(0);
            this.but_search.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_search.Name = "but_search";
            this.but_search.Padding = new System.Windows.Forms.Padding(0, 35, 0, 8);
            this.but_search.Radius = 0;
            this.but_search.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_search.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_search.Size = new System.Drawing.Size(114, 83);
            this.but_search.Style = Sunny.UI.UIStyle.Custom;
            this.but_search.Symbol = 361888;
            this.but_search.SymbolColor = System.Drawing.Color.Black;
            this.but_search.TabIndex = 10;
            this.but_search.Text = "고객정보 조회";
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // but_cus_add
            // 
            this.but_cus_add.CircleColor = System.Drawing.Color.White;
            this.but_cus_add.CircleHoverColor = System.Drawing.Color.White;
            this.but_cus_add.CircleSize = 0;
            this.but_cus_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_cus_add.FillColor = System.Drawing.Color.White;
            this.but_cus_add.FillHoverColor = System.Drawing.Color.Silver;
            this.but_cus_add.FillPressColor = System.Drawing.Color.Gray;
            this.but_cus_add.FillSelectedColor = System.Drawing.Color.Gray;
            this.but_cus_add.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but_cus_add.ForeColor = System.Drawing.Color.Gray;
            this.but_cus_add.ForeHoverColor = System.Drawing.Color.Black;
            this.but_cus_add.ForePressColor = System.Drawing.Color.Black;
            this.but_cus_add.ForeSelectedColor = System.Drawing.Color.Black;
            this.but_cus_add.Location = new System.Drawing.Point(2, 85);
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
            this.but_cus_add.TabIndex = 9;
            this.but_cus_add.Text = "고객정보 추가";
            this.but_cus_add.Click += new System.EventHandler(this.but_cus_add_Click_1);
            // 
            // but_home
            // 
            this.but_home.CircleColor = System.Drawing.Color.White;
            this.but_home.CircleHoverColor = System.Drawing.Color.White;
            this.but_home.CircleSize = 0;
            this.but_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_home.FillColor = System.Drawing.Color.White;
            this.but_home.FillHoverColor = System.Drawing.Color.Silver;
            this.but_home.FillPressColor = System.Drawing.Color.Gray;
            this.but_home.FillSelectedColor = System.Drawing.Color.Gray;
            this.but_home.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but_home.ForeColor = System.Drawing.Color.Gray;
            this.but_home.ForeHoverColor = System.Drawing.Color.Black;
            this.but_home.ForePressColor = System.Drawing.Color.Black;
            this.but_home.ForeSelectedColor = System.Drawing.Color.Black;
            this.but_home.Location = new System.Drawing.Point(2, 2);
            this.but_home.Margin = new System.Windows.Forms.Padding(0);
            this.but_home.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_home.Name = "but_home";
            this.but_home.Padding = new System.Windows.Forms.Padding(0, 35, 0, 8);
            this.but_home.Radius = 0;
            this.but_home.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_home.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_home.Size = new System.Drawing.Size(114, 83);
            this.but_home.Style = Sunny.UI.UIStyle.Custom;
            this.but_home.Symbol = 57353;
            this.but_home.SymbolColor = System.Drawing.Color.Black;
            this.but_home.TabIndex = 8;
            this.but_home.Text = "HOME";
            this.but_home.Click += new System.EventHandler(this.but_home_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Silver;
            this.uiLine1.Location = new System.Drawing.Point(116, 3);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(3, 387);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 0;
            this.uiLine1.Text = "uiLine1";
            // 
            // main_panel
            // 
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(118, 66);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(551, 396);
            this.main_panel.TabIndex = 2;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
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
            this.Right_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel Top_panel;
        private Sunny.UI.UIButton but_close;
        private Sunny.UI.UIFlowLayoutPanel Right_panel;
        private System.Windows.Forms.Panel main_panel;
        private Sunny.UI.UIButton but_mini;
        private Sunny.UI.UIButton but_info;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIHeaderButton but_search;
        private Sunny.UI.UIHeaderButton but_cus_add;
        private Sunny.UI.UIHeaderButton but_home;
        private Sunny.UI.UIHeaderButton uiHeaderButton5;
        private Sunny.UI.UIHeaderButton uiHeaderButton4;
        private Sunny.UI.UIHeaderButton but_track;
    }
}