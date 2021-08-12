
namespace View_structure_0811.UI.UI_contents.Track_del_info
{
    partial class Tracking_del_info_map
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
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.output_memberdigit = new Sunny.UI.UILabel();
            this.Top_panel = new Sunny.UI.UIFlowLayoutPanel();
            this.but_close = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.pointer = new Sunny.UI.UISymbolLabel();
            this.Top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel2.Location = new System.Drawing.Point(-111, 81);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(588, 29);
            this.uiLabel2.TabIndex = 159;
            this.uiLabel2.Text = "현재 주문하신 물품의 위치입니다.";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_memberdigit
            // 
            this.output_memberdigit.BackColor = System.Drawing.Color.LightCyan;
            this.output_memberdigit.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_memberdigit.ForeColor = System.Drawing.Color.Black;
            this.output_memberdigit.Location = new System.Drawing.Point(8, 121);
            this.output_memberdigit.Name = "output_memberdigit";
            this.output_memberdigit.Size = new System.Drawing.Size(345, 45);
            this.output_memberdigit.TabIndex = 158;
            this.output_memberdigit.Text = "data";
            this.output_memberdigit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Top_panel.TabIndex = 160;
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
            this.uiLabel1.Text = "배송조회 결과";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = global::View_structure_0811.Properties.Resources.map;
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(12, 184);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(341, 366);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 161;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // pointer
            // 
            this.pointer.BackColor = System.Drawing.Color.Transparent;
            this.pointer.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.pointer.ForeColor = System.Drawing.Color.Red;
            this.pointer.Location = new System.Drawing.Point(53, 244);
            this.pointer.MinimumSize = new System.Drawing.Size(1, 1);
            this.pointer.Name = "pointer";
            this.pointer.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.pointer.Size = new System.Drawing.Size(17, 12);
            this.pointer.Style = Sunny.UI.UIStyle.Custom;
            this.pointer.SymbolColor = System.Drawing.Color.Red;
            this.pointer.TabIndex = 162;
            // 
            // Tracking_del_info_map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 562);
            this.Controls.Add(this.pointer);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.Top_panel);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.output_memberdigit);
            this.Name = "Tracking_del_info_map";
            this.Load += new System.EventHandler(this.Tracking_del_info_map_Load);
            this.Top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel output_memberdigit;
        private Sunny.UI.UIFlowLayoutPanel Top_panel;
        private Sunny.UI.UIButton but_close;
        private Sunny.UI.UILabel uiLabel1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UISymbolLabel pointer;
    }
}