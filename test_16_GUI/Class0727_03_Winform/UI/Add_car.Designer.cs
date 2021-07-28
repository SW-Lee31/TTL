
namespace Class0727_03_Winform.UI
{
    partial class Add_car
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
            this.input_brand = new Sunny.UI.UIComboBox();
            this.text1 = new Sunny.UI.UILabel();
            this.input_model = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.input_color = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.output_stock = new Sunny.UI.UILabel();
            this.but_submit = new Sunny.UI.UISymbolButton();
            this.input_customer_ID = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.title = new Sunny.UI.UISymbolLabel();
            this.but_back = new Sunny.UI.UISymbolButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.output_preview = new CxFlatUI.CxFlatPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.output_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // input_brand
            // 
            this.input_brand.DataSource = null;
            this.input_brand.FillColor = System.Drawing.Color.White;
            this.input_brand.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_brand.Items.AddRange(new object[] {
            "Suzuki",
            "Karasaki",
            "Harley"});
            this.input_brand.Location = new System.Drawing.Point(17, 398);
            this.input_brand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_brand.MinimumSize = new System.Drawing.Size(63, 0);
            this.input_brand.Name = "input_brand";
            this.input_brand.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.input_brand.Size = new System.Drawing.Size(150, 29);
            this.input_brand.TabIndex = 0;
            this.input_brand.Text = "Choose Brand";
            this.input_brand.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.input_brand.SelectedIndexChanged += new System.EventHandler(this.input_brand_SelectedIndexChanged);
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.Transparent;
            this.text1.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text1.ForeColor = System.Drawing.Color.Black;
            this.text1.Location = new System.Drawing.Point(12, 77);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(164, 23);
            this.text1.TabIndex = 61;
            this.text1.Text = "Preview Image";
            this.text1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_model
            // 
            this.input_model.DataSource = null;
            this.input_model.FillColor = System.Drawing.Color.White;
            this.input_model.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_model.Location = new System.Drawing.Point(198, 398);
            this.input_model.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_model.MinimumSize = new System.Drawing.Size(63, 0);
            this.input_model.Name = "input_model";
            this.input_model.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.input_model.Size = new System.Drawing.Size(173, 29);
            this.input_model.TabIndex = 1;
            this.input_model.Text = "Choose Model";
            this.input_model.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.input_model.SelectedIndexChanged += new System.EventHandler(this.input_model_SelectedIndexChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.Location = new System.Drawing.Point(-16, 370);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(123, 23);
            this.uiLabel1.TabIndex = 62;
            this.uiLabel1.Text = "Brand";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(167, 370);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(123, 23);
            this.uiLabel2.TabIndex = 63;
            this.uiLabel2.Text = "Model";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_color
            // 
            this.input_color.DataSource = null;
            this.input_color.FillColor = System.Drawing.Color.White;
            this.input_color.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_color.Location = new System.Drawing.Point(396, 398);
            this.input_color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_color.MinimumSize = new System.Drawing.Size(63, 0);
            this.input_color.Name = "input_color";
            this.input_color.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.input_color.Size = new System.Drawing.Size(150, 29);
            this.input_color.TabIndex = 2;
            this.input_color.Text = "Choose Color";
            this.input_color.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.input_color.SelectedIndexChanged += new System.EventHandler(this.input_color_SelectedIndexChanged);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Black;
            this.uiLabel3.Location = new System.Drawing.Point(359, 370);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(123, 23);
            this.uiLabel3.TabIndex = 65;
            this.uiLabel3.Text = "Color";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel4.ForeColor = System.Drawing.Color.Black;
            this.uiLabel4.Location = new System.Drawing.Point(535, 370);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(123, 23);
            this.uiLabel4.TabIndex = 66;
            this.uiLabel4.Text = "Remaining";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_stock
            // 
            this.output_stock.BackColor = System.Drawing.Color.Transparent;
            this.output_stock.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_stock.ForeColor = System.Drawing.Color.Black;
            this.output_stock.Location = new System.Drawing.Point(553, 401);
            this.output_stock.Name = "output_stock";
            this.output_stock.Size = new System.Drawing.Size(94, 23);
            this.output_stock.TabIndex = 67;
            this.output_stock.Text = "digit";
            this.output_stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_submit
            // 
            this.but_submit.BackColor = System.Drawing.Color.Black;
            this.but_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_submit.FillColor = System.Drawing.Color.Black;
            this.but_submit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_submit.FillPressColor = System.Drawing.Color.Lime;
            this.but_submit.FillSelectedColor = System.Drawing.Color.White;
            this.but_submit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_submit.ForeHoverColor = System.Drawing.Color.DarkRed;
            this.but_submit.ForePressColor = System.Drawing.Color.Red;
            this.but_submit.Location = new System.Drawing.Point(251, 539);
            this.but_submit.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_submit.Name = "but_submit";
            this.but_submit.RectColor = System.Drawing.Color.Transparent;
            this.but_submit.RectDisableColor = System.Drawing.Color.Transparent;
            this.but_submit.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_submit.RectPressColor = System.Drawing.Color.Transparent;
            this.but_submit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.but_submit.Size = new System.Drawing.Size(186, 47);
            this.but_submit.Style = Sunny.UI.UIStyle.Custom;
            this.but_submit.StyleCustomMode = true;
            this.but_submit.TabIndex = 68;
            this.but_submit.Text = "Submit";
            this.but_submit.Click += new System.EventHandler(this.but_submit_Click);
            // 
            // input_customer_ID
            // 
            this.input_customer_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_customer_ID.FillColor = System.Drawing.Color.White;
            this.input_customer_ID.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_customer_ID.Location = new System.Drawing.Point(17, 478);
            this.input_customer_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_customer_ID.Maximum = 2147483647D;
            this.input_customer_ID.Minimum = -2147483648D;
            this.input_customer_ID.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_customer_ID.Name = "input_customer_ID";
            this.input_customer_ID.Size = new System.Drawing.Size(150, 31);
            this.input_customer_ID.TabIndex = 69;
            this.input_customer_ID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel5.ForeColor = System.Drawing.Color.Black;
            this.uiLabel5.Location = new System.Drawing.Point(-16, 450);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(306, 23);
            this.uiLabel5.TabIndex = 70;
            this.uiLabel5.Text = "Input Customer who ordered";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("양재벨라체M", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(73, 12);
            this.title.MinimumSize = new System.Drawing.Size(1, 1);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.title.Size = new System.Drawing.Size(528, 44);
            this.title.Style = Sunny.UI.UIStyle.Custom;
            this.title.Symbol = 61980;
            this.title.SymbolColor = System.Drawing.Color.Black;
            this.title.SymbolSize = 45;
            this.title.TabIndex = 71;
            this.title.Text = "THE MOTOR";
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
            this.but_back.TabIndex = 72;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel6.ForeColor = System.Drawing.Color.Black;
            this.uiLabel6.Location = new System.Drawing.Point(306, 450);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(306, 23);
            this.uiLabel6.TabIndex = 73;
            this.uiLabel6.Text = "Input order Serial Number";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(344, 478);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(228, 31);
            this.uiTextBox1.TabIndex = 70;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // output_preview
            // 
            this.output_preview.BackColor = System.Drawing.Color.White;
            this.output_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output_preview.Location = new System.Drawing.Point(12, 103);
            this.output_preview.Name = "output_preview";
            this.output_preview.Size = new System.Drawing.Size(646, 254);
            this.output_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.output_preview.TabIndex = 1;
            this.output_preview.TabStop = false;
            // 
            // Add_car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 604);
            this.ControlBox = false;
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.title);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.input_customer_ID);
            this.Controls.Add(this.but_submit);
            this.Controls.Add(this.output_stock);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.input_color);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.input_model);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.output_preview);
            this.Controls.Add(this.input_brand);
            this.Name = "Add_car";
            this.Load += new System.EventHandler(this.Add_car_Load);
            ((System.ComponentModel.ISupportInitialize)(this.output_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox input_brand;
        private CxFlatUI.CxFlatPictureBox output_preview;
        private Sunny.UI.UILabel text1;
        private Sunny.UI.UIComboBox input_model;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox input_color;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel output_stock;
        private Sunny.UI.UISymbolButton but_submit;
        private Sunny.UI.UITextBox input_customer_ID;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UISymbolLabel title;
        private Sunny.UI.UISymbolButton but_back;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox uiTextBox1;
    }
}