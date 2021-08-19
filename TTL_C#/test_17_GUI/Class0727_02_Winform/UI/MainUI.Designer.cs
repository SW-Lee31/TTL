
namespace Class0727_02_Winform
{
    partial class MainUI
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_addcustomer = new CxFlatUI.CxFlatRoundButton();
            this.button_addcar = new CxFlatUI.CxFlatRoundButton();
            this.button_car_salary = new CxFlatUI.CxFlatRoundButton();
            this.button_admin = new CxFlatUI.CxFlatRoundButton();
            this.button_help = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.title = new Sunny.UI.UISymbolLabel();
            this.button_minimum = new Sunny.UI.UISymbolButton();
            this.button_close = new Sunny.UI.UISymbolButton();
            this.button_maximum = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_addcustomer
            // 
            this.button_addcustomer.ButtonType = CxFlatUI.ButtonType.Default;
            this.button_addcustomer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addcustomer.Location = new System.Drawing.Point(8, 66);
            this.button_addcustomer.Name = "button_addcustomer";
            this.button_addcustomer.Size = new System.Drawing.Size(204, 44);
            this.button_addcustomer.TabIndex = 0;
            this.button_addcustomer.Text = "고객 정보 등록";
            this.button_addcustomer.TextColor = System.Drawing.Color.White;
            // 
            // button_addcar
            // 
            this.button_addcar.ButtonType = CxFlatUI.ButtonType.Default;
            this.button_addcar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addcar.Location = new System.Drawing.Point(218, 66);
            this.button_addcar.Name = "button_addcar";
            this.button_addcar.Size = new System.Drawing.Size(204, 44);
            this.button_addcar.TabIndex = 1;
            this.button_addcar.Text = "구매 차량 등록";
            this.button_addcar.TextColor = System.Drawing.Color.White;
            // 
            // button_car_salary
            // 
            this.button_car_salary.ButtonType = CxFlatUI.ButtonType.Default;
            this.button_car_salary.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_car_salary.Location = new System.Drawing.Point(428, 66);
            this.button_car_salary.Name = "button_car_salary";
            this.button_car_salary.Size = new System.Drawing.Size(204, 44);
            this.button_car_salary.TabIndex = 2;
            this.button_car_salary.Text = "차량 매출 정보";
            this.button_car_salary.TextColor = System.Drawing.Color.White;
            // 
            // button_admin
            // 
            this.button_admin.ButtonType = CxFlatUI.ButtonType.Success;
            this.button_admin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_admin.Location = new System.Drawing.Point(638, 66);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(204, 44);
            this.button_admin.TabIndex = 3;
            this.button_admin.Text = "관리자 환경";
            this.button_admin.TextColor = System.Drawing.Color.White;
            // 
            // button_help
            // 
            this.button_help.ButtonType = CxFlatUI.ButtonType.Info;
            this.button_help.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_help.Location = new System.Drawing.Point(848, 66);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(204, 44);
            this.button_help.TabIndex = 4;
            this.button_help.Text = "도움말";
            this.button_help.TextColor = System.Drawing.Color.White;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cxFlatPictureBox1.Image = global::Class0727_02_Winform.Properties.Resources.Mainimage;
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(0, 114);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(1061, 431);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 5;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(268, 9);
            this.title.MinimumSize = new System.Drawing.Size(1, 1);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.title.Size = new System.Drawing.Size(511, 41);
            this.title.Style = Sunny.UI.UIStyle.Custom;
            this.title.Symbol = 362948;
            this.title.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.title.SymbolSize = 40;
            this.title.TabIndex = 7;
            this.title.Text = "고객 차량 관리 프로그램 V1.0.0";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // button_minimum
            // 
            this.button_minimum.BackColor = System.Drawing.Color.Transparent;
            this.button_minimum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_minimum.FillColor = System.Drawing.Color.Transparent;
            this.button_minimum.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.button_minimum.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.button_minimum.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.button_minimum.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.button_minimum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.button_minimum.Location = new System.Drawing.Point(965, 2);
            this.button_minimum.MinimumSize = new System.Drawing.Size(1, 1);
            this.button_minimum.Name = "button_minimum";
            this.button_minimum.RectColor = System.Drawing.Color.White;
            this.button_minimum.RectHoverColor = System.Drawing.Color.Yellow;
            this.button_minimum.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_minimum.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_minimum.Size = new System.Drawing.Size(28, 26);
            this.button_minimum.Style = Sunny.UI.UIStyle.Custom;
            this.button_minimum.Symbol = 62161;
            this.button_minimum.TabIndex = 9;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FillColor = System.Drawing.Color.Transparent;
            this.button_close.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button_close.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.button_close.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.button_close.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.button_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button_close.Location = new System.Drawing.Point(1033, 2);
            this.button_close.MinimumSize = new System.Drawing.Size(1, 1);
            this.button_close.Name = "button_close";
            this.button_close.RectColor = System.Drawing.Color.White;
            this.button_close.RectHoverColor = System.Drawing.Color.Red;
            this.button_close.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_close.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_close.Size = new System.Drawing.Size(28, 26);
            this.button_close.Style = Sunny.UI.UIStyle.Custom;
            this.button_close.Symbol = 61453;
            this.button_close.SymbolSize = 30;
            this.button_close.TabIndex = 10;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_maximum
            // 
            this.button_maximum.BackColor = System.Drawing.Color.Transparent;
            this.button_maximum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_maximum.FillColor = System.Drawing.Color.Transparent;
            this.button_maximum.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.button_maximum.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.button_maximum.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.button_maximum.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.button_maximum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.button_maximum.Location = new System.Drawing.Point(999, 2);
            this.button_maximum.MinimumSize = new System.Drawing.Size(1, 1);
            this.button_maximum.Name = "button_maximum";
            this.button_maximum.RectColor = System.Drawing.Color.White;
            this.button_maximum.RectHoverColor = System.Drawing.Color.Lime;
            this.button_maximum.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_maximum.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_maximum.Size = new System.Drawing.Size(28, 26);
            this.button_maximum.Style = Sunny.UI.UIStyle.Custom;
            this.button_maximum.Symbol = 62160;
            this.button_maximum.TabIndex = 11;
            this.button_maximum.Click += new System.EventHandler(this.button_maximum_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1061, 541);
            this.ControlBox = false;
            this.Controls.Add(this.button_maximum);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_minimum);
            this.Controls.Add(this.title);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_admin);
            this.Controls.Add(this.button_car_salary);
            this.Controls.Add(this.button_addcar);
            this.Controls.Add(this.button_addcustomer);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatRoundButton button_addcustomer;
        private CxFlatUI.CxFlatRoundButton button_addcar;
        private CxFlatUI.CxFlatRoundButton button_car_salary;
        private CxFlatUI.CxFlatRoundButton button_admin;
        private CxFlatUI.CxFlatRoundButton button_help;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UISymbolLabel title;
        private Sunny.UI.UISymbolButton button_minimum;
        private Sunny.UI.UISymbolButton button_close;
        private Sunny.UI.UISymbolButton button_maximum;
    }
}

