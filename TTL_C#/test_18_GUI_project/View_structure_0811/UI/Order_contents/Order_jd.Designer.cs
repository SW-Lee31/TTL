
namespace View_structure_0811.UI.Order_contents
{
    partial class Order_jd
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
            this.input_model = new CxFlatUI.CxFlatComboBox();
            this.right_category = new Sunny.UI.UIPanel();
            this.but_accesorry = new Sunny.UI.UIHeaderButton();
            this.but_shoes = new Sunny.UI.UIHeaderButton();
            this.but_outer = new Sunny.UI.UIHeaderButton();
            this.but_cap = new Sunny.UI.UIHeaderButton();
            this.but_bottom = new Sunny.UI.UIHeaderButton();
            this.but_shirt = new Sunny.UI.UIHeaderButton();
            this.input_color = new CxFlatUI.CxFlatComboBox();
            this.input_size = new CxFlatUI.CxFlatComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.preview = new CxFlatUI.CxFlatPictureBox();
            this.logo_image = new CxFlatUI.CxFlatPictureBox();
            this.panel_blind = new Sunny.UI.UIPanel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.right_category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_image)).BeginInit();
            this.SuspendLayout();
            // 
            // input_model
            // 
            this.input_model.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.input_model.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_model.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_model.FormattingEnabled = true;
            this.input_model.ItemHeight = 30;
            this.input_model.Location = new System.Drawing.Point(152, 169);
            this.input_model.Name = "input_model";
            this.input_model.Size = new System.Drawing.Size(234, 36);
            this.input_model.TabIndex = 1;
            this.input_model.SelectedIndexChanged += new System.EventHandler(this.input_model_SelectedIndexChanged);
            // 
            // right_category
            // 
            this.right_category.Controls.Add(this.but_accesorry);
            this.right_category.Controls.Add(this.but_shoes);
            this.right_category.Controls.Add(this.but_outer);
            this.right_category.Controls.Add(this.but_cap);
            this.right_category.Controls.Add(this.but_bottom);
            this.right_category.Controls.Add(this.but_shirt);
            this.right_category.Dock = System.Windows.Forms.DockStyle.Left;
            this.right_category.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.right_category.Location = new System.Drawing.Point(0, 115);
            this.right_category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.right_category.MinimumSize = new System.Drawing.Size(1, 1);
            this.right_category.Name = "right_category";
            this.right_category.Size = new System.Drawing.Size(129, 251);
            this.right_category.TabIndex = 2;
            this.right_category.Text = null;
            this.right_category.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_accesorry
            // 
            this.but_accesorry.CircleSize = 0;
            this.but_accesorry.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_accesorry.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_accesorry.Location = new System.Drawing.Point(0, 209);
            this.but_accesorry.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_accesorry.Name = "but_accesorry";
            this.but_accesorry.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.but_accesorry.Radius = 0;
            this.but_accesorry.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_accesorry.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_accesorry.Size = new System.Drawing.Size(129, 41);
            this.but_accesorry.Symbol = 0;
            this.but_accesorry.TabIndex = 5;
            this.but_accesorry.Text = "악세사리";
            this.but_accesorry.Click += new System.EventHandler(this.but_accesorry_Click);
            // 
            // but_shoes
            // 
            this.but_shoes.CircleSize = 0;
            this.but_shoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_shoes.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_shoes.Location = new System.Drawing.Point(0, 168);
            this.but_shoes.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_shoes.Name = "but_shoes";
            this.but_shoes.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.but_shoes.Radius = 0;
            this.but_shoes.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_shoes.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_shoes.Size = new System.Drawing.Size(129, 41);
            this.but_shoes.Symbol = 0;
            this.but_shoes.TabIndex = 4;
            this.but_shoes.Text = "신발";
            this.but_shoes.Click += new System.EventHandler(this.but_shoes_Click);
            // 
            // but_outer
            // 
            this.but_outer.CircleSize = 0;
            this.but_outer.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_outer.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_outer.Location = new System.Drawing.Point(0, 127);
            this.but_outer.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_outer.Name = "but_outer";
            this.but_outer.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.but_outer.Radius = 0;
            this.but_outer.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_outer.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_outer.Size = new System.Drawing.Size(129, 41);
            this.but_outer.Symbol = 0;
            this.but_outer.TabIndex = 3;
            this.but_outer.Text = "아우터";
            this.but_outer.Click += new System.EventHandler(this.but_outer_Click);
            // 
            // but_cap
            // 
            this.but_cap.CircleSize = 0;
            this.but_cap.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_cap.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_cap.Location = new System.Drawing.Point(0, 86);
            this.but_cap.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_cap.Name = "but_cap";
            this.but_cap.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.but_cap.Radius = 0;
            this.but_cap.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_cap.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_cap.Size = new System.Drawing.Size(129, 41);
            this.but_cap.Symbol = 0;
            this.but_cap.TabIndex = 2;
            this.but_cap.Text = "모자";
            this.but_cap.Click += new System.EventHandler(this.but_cap_Click);
            // 
            // but_bottom
            // 
            this.but_bottom.CircleSize = 0;
            this.but_bottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_bottom.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_bottom.Location = new System.Drawing.Point(0, 43);
            this.but_bottom.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_bottom.Name = "but_bottom";
            this.but_bottom.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.but_bottom.Radius = 0;
            this.but_bottom.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_bottom.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_bottom.Size = new System.Drawing.Size(129, 43);
            this.but_bottom.Symbol = 0;
            this.but_bottom.TabIndex = 1;
            this.but_bottom.Text = "bottom";
            this.but_bottom.Click += new System.EventHandler(this.but_bottom_Click);
            // 
            // but_shirt
            // 
            this.but_shirt.CircleSize = 0;
            this.but_shirt.Dock = System.Windows.Forms.DockStyle.Top;
            this.but_shirt.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_shirt.Location = new System.Drawing.Point(0, 0);
            this.but_shirt.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_shirt.Name = "but_shirt";
            this.but_shirt.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.but_shirt.Radius = 0;
            this.but_shirt.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_shirt.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_shirt.Size = new System.Drawing.Size(129, 43);
            this.but_shirt.Symbol = 0;
            this.but_shirt.TabIndex = 0;
            this.but_shirt.Text = "top";
            this.but_shirt.Click += new System.EventHandler(this.but_shirt_Click);
            // 
            // input_color
            // 
            this.input_color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.input_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_color.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_color.FormattingEnabled = true;
            this.input_color.ItemHeight = 30;
            this.input_color.Location = new System.Drawing.Point(152, 236);
            this.input_color.Name = "input_color";
            this.input_color.Size = new System.Drawing.Size(234, 36);
            this.input_color.TabIndex = 3;
            this.input_color.SelectedIndexChanged += new System.EventHandler(this.input_color_SelectedIndexChanged);
            // 
            // input_size
            // 
            this.input_size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.input_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_size.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_size.FormattingEnabled = true;
            this.input_size.ItemHeight = 30;
            this.input_size.Location = new System.Drawing.Point(152, 303);
            this.input_size.Name = "input_size";
            this.input_size.Size = new System.Drawing.Size(234, 36);
            this.input_size.TabIndex = 4;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(419, 130);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(227, 23);
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "Preview";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(0, 52);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(669, 48);
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "John Deere";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // preview
            // 
            this.preview.Location = new System.Drawing.Point(419, 169);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(227, 174);
            this.preview.TabIndex = 6;
            this.preview.TabStop = false;
            // 
            // logo_image
            // 
            this.logo_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_image.Image = global::View_structure_0811.Properties.Resources.john_deere_logo;
            this.logo_image.Location = new System.Drawing.Point(0, 0);
            this.logo_image.Name = "logo_image";
            this.logo_image.Size = new System.Drawing.Size(669, 115);
            this.logo_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_image.TabIndex = 0;
            this.logo_image.TabStop = false;
            // 
            // panel_blind
            // 
            this.panel_blind.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.panel_blind.Location = new System.Drawing.Point(129, 332);
            this.panel_blind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_blind.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel_blind.Name = "panel_blind";
            this.panel_blind.Size = new System.Drawing.Size(283, 34);
            this.panel_blind.TabIndex = 8;
            this.panel_blind.Text = null;
            this.panel_blind.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(159, 130);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(227, 23);
            this.uiLabel3.TabIndex = 9;
            this.uiLabel3.Text = "항목을 선택해주세요.";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Order_jd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.panel_blind);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.input_size);
            this.Controls.Add(this.input_color);
            this.Controls.Add(this.right_category);
            this.Controls.Add(this.input_model);
            this.Controls.Add(this.logo_image);
            this.Name = "Order_jd";
            this.Size = new System.Drawing.Size(669, 366);
            this.right_category.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatPictureBox logo_image;
        private CxFlatUI.CxFlatComboBox input_model;
        private Sunny.UI.UIPanel right_category;
        private Sunny.UI.UIHeaderButton but_outer;
        private Sunny.UI.UIHeaderButton but_cap;
        private Sunny.UI.UIHeaderButton but_bottom;
        private Sunny.UI.UIHeaderButton but_shirt;
        private CxFlatUI.CxFlatComboBox input_color;
        private CxFlatUI.CxFlatComboBox input_size;
        private Sunny.UI.UILabel uiLabel1;
        private CxFlatUI.CxFlatPictureBox preview;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIHeaderButton but_accesorry;
        private Sunny.UI.UIHeaderButton but_shoes;
        private Sunny.UI.UIPanel panel_blind;
        private Sunny.UI.UILabel uiLabel3;
    }
}
