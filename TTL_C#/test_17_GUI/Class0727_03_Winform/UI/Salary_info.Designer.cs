
namespace Class0727_03_Winform.UI
{
    partial class Salary_info
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
            this.title = new Sunny.UI.UISymbolLabel();
            this.but_back = new Sunny.UI.UISymbolButton();
            this.input_serial = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.output_preview = new CxFlatUI.CxFlatPictureBox();
            this.text1 = new Sunny.UI.UILabel();
            this.but_submit = new Sunny.UI.UIButton();
            this.text3 = new Sunny.UI.UILabel();
            this.text2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.output_name = new Sunny.UI.UILabel();
            this.output_date = new Sunny.UI.UILabel();
            this.output_buyer = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.output_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("양재벨라체M", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(-8, 12);
            this.title.MinimumSize = new System.Drawing.Size(1, 1);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.title.Size = new System.Drawing.Size(528, 44);
            this.title.Style = Sunny.UI.UIStyle.Custom;
            this.title.Symbol = 61980;
            this.title.SymbolColor = System.Drawing.Color.Black;
            this.title.SymbolSize = 45;
            this.title.TabIndex = 72;
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
            this.but_back.Location = new System.Drawing.Point(12, 10);
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
            this.but_back.TabIndex = 73;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // input_serial
            // 
            this.input_serial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_serial.FillColor = System.Drawing.Color.White;
            this.input_serial.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.input_serial.Location = new System.Drawing.Point(13, 102);
            this.input_serial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_serial.Maximum = 2147483647D;
            this.input_serial.Minimum = -2147483648D;
            this.input_serial.MinimumSize = new System.Drawing.Size(1, 1);
            this.input_serial.Name = "input_serial";
            this.input_serial.Size = new System.Drawing.Size(228, 31);
            this.input_serial.TabIndex = 74;
            this.input_serial.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel6.ForeColor = System.Drawing.Color.Black;
            this.uiLabel6.Location = new System.Drawing.Point(-25, 74);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(306, 23);
            this.uiLabel6.TabIndex = 75;
            this.uiLabel6.Text = "Input order Serial Number";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_preview
            // 
            this.output_preview.BackColor = System.Drawing.Color.White;
            this.output_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output_preview.Location = new System.Drawing.Point(12, 189);
            this.output_preview.Name = "output_preview";
            this.output_preview.Size = new System.Drawing.Size(508, 254);
            this.output_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.output_preview.TabIndex = 76;
            this.output_preview.TabStop = false;
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.Transparent;
            this.text1.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text1.ForeColor = System.Drawing.Color.Black;
            this.text1.Location = new System.Drawing.Point(-8, 163);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(164, 23);
            this.text1.TabIndex = 77;
            this.text1.Text = "Preview Image";
            this.text1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_submit
            // 
            this.but_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_submit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.but_submit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.but_submit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.but_submit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.but_submit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_submit.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_submit.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_submit.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_submit.Location = new System.Drawing.Point(257, 102);
            this.but_submit.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_submit.Name = "but_submit";
            this.but_submit.RectColor = System.Drawing.Color.Transparent;
            this.but_submit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_submit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_submit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.but_submit.Size = new System.Drawing.Size(100, 35);
            this.but_submit.Style = Sunny.UI.UIStyle.Custom;
            this.but_submit.TabIndex = 78;
            this.but_submit.Text = "Search";
            this.but_submit.Click += new System.EventHandler(this.but_submit_Click);
            // 
            // text3
            // 
            this.text3.BackColor = System.Drawing.Color.Transparent;
            this.text3.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text3.ForeColor = System.Drawing.Color.Black;
            this.text3.Location = new System.Drawing.Point(-22, 549);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(164, 23);
            this.text3.Style = Sunny.UI.UIStyle.Custom;
            this.text3.TabIndex = 81;
            this.text3.Text = "※ Buyer";
            this.text3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.Transparent;
            this.text2.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.ForeColor = System.Drawing.Color.Black;
            this.text2.Location = new System.Drawing.Point(1, 510);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(164, 23);
            this.text2.Style = Sunny.UI.UIStyle.Custom;
            this.text2.TabIndex = 80;
            this.text2.Text = "※ Order Date";
            this.text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.Location = new System.Drawing.Point(5, 471);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(164, 23);
            this.uiLabel1.TabIndex = 79;
            this.uiLabel1.Text = "※ Model Name";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_name
            // 
            this.output_name.BackColor = System.Drawing.Color.Transparent;
            this.output_name.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_name.ForeColor = System.Drawing.Color.Black;
            this.output_name.Location = new System.Drawing.Point(196, 471);
            this.output_name.Name = "output_name";
            this.output_name.Size = new System.Drawing.Size(294, 23);
            this.output_name.TabIndex = 82;
            this.output_name.Text = "data";
            this.output_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_date
            // 
            this.output_date.BackColor = System.Drawing.Color.Transparent;
            this.output_date.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_date.ForeColor = System.Drawing.Color.Black;
            this.output_date.Location = new System.Drawing.Point(196, 510);
            this.output_date.Name = "output_date";
            this.output_date.Size = new System.Drawing.Size(294, 23);
            this.output_date.TabIndex = 83;
            this.output_date.Text = "data";
            this.output_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_buyer
            // 
            this.output_buyer.BackColor = System.Drawing.Color.Transparent;
            this.output_buyer.Font = new System.Drawing.Font("양재벨라체M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_buyer.ForeColor = System.Drawing.Color.Black;
            this.output_buyer.Location = new System.Drawing.Point(196, 549);
            this.output_buyer.Name = "output_buyer";
            this.output_buyer.Size = new System.Drawing.Size(294, 23);
            this.output_buyer.TabIndex = 84;
            this.output_buyer.Text = "data";
            this.output_buyer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Salary_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 604);
            this.ControlBox = false;
            this.Controls.Add(this.output_buyer);
            this.Controls.Add(this.output_date);
            this.Controls.Add(this.output_name);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.but_submit);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.output_preview);
            this.Controls.Add(this.input_serial);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.title);
            this.Location = new System.Drawing.Point(12, 10);
            this.Name = "Salary_info";
            this.Load += new System.EventHandler(this.Salary_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.output_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel title;
        private Sunny.UI.UISymbolButton but_back;
        private Sunny.UI.UITextBox input_serial;
        private Sunny.UI.UILabel uiLabel6;
        private CxFlatUI.CxFlatPictureBox output_preview;
        private Sunny.UI.UILabel text1;
        private Sunny.UI.UIButton but_submit;
        private Sunny.UI.UILabel text3;
        private Sunny.UI.UILabel text2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel output_name;
        private Sunny.UI.UILabel output_date;
        private Sunny.UI.UILabel output_buyer;
    }
}