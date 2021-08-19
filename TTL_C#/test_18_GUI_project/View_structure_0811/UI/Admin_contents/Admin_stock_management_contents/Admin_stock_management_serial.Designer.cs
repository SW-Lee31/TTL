
namespace View_structure_0811.UI.Admin_contents.Admin_stock_management_contents
{
    partial class Admin_stock_management_serial
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
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.input_stock_index = new Sunny.UI.UIComboBox();
            this.output_amount = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.but_confirm = new Sunny.UI.UISymbolButton();
            this.cus_but_submit = new Sunny.UI.UISymbolButton();
            this.input_serial = new System.Windows.Forms.TextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.output_weight = new Sunny.UI.UILabel();
            this.output_size = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.output_stock_name = new Sunny.UI.UILabel();
            this.text2 = new Sunny.UI.UILabel();
            this.output_stock = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel6.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel6.Location = new System.Drawing.Point(438, 15);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(188, 31);
            this.uiLabel6.TabIndex = 158;
            this.uiLabel6.Text = "제품 Preview";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_stock_index
            // 
            this.input_stock_index.DataSource = null;
            this.input_stock_index.FillColor = System.Drawing.Color.White;
            this.input_stock_index.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_stock_index.Location = new System.Drawing.Point(102, 261);
            this.input_stock_index.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_stock_index.MinimumSize = new System.Drawing.Size(63, 0);
            this.input_stock_index.Name = "input_stock_index";
            this.input_stock_index.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.input_stock_index.Size = new System.Drawing.Size(96, 21);
            this.input_stock_index.TabIndex = 144;
            this.input_stock_index.Text = "재고 색인";
            this.input_stock_index.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // output_amount
            // 
            this.output_amount.BackColor = System.Drawing.Color.Transparent;
            this.output_amount.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_amount.ForeColor = System.Drawing.Color.Black;
            this.output_amount.Location = new System.Drawing.Point(174, 178);
            this.output_amount.Name = "output_amount";
            this.output_amount.Size = new System.Drawing.Size(162, 26);
            this.output_amount.TabIndex = 156;
            this.output_amount.Text = "data";
            this.output_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel1.Location = new System.Drawing.Point(62, 183);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(91, 28);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 155;
            this.uiLabel1.Text = "※ 재고 수";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_confirm
            // 
            this.but_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_confirm.FillColor = System.Drawing.Color.White;
            this.but_confirm.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_confirm.FillPressColor = System.Drawing.Color.Lime;
            this.but_confirm.FillSelectedColor = System.Drawing.Color.White;
            this.but_confirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_confirm.ForeColor = System.Drawing.Color.Black;
            this.but_confirm.ForeHoverColor = System.Drawing.Color.DarkRed;
            this.but_confirm.ForePressColor = System.Drawing.Color.Red;
            this.but_confirm.Location = new System.Drawing.Point(285, 51);
            this.but_confirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_confirm.Name = "but_confirm";
            this.but_confirm.RectColor = System.Drawing.Color.Black;
            this.but_confirm.RectDisableColor = System.Drawing.Color.Transparent;
            this.but_confirm.RectHoverColor = System.Drawing.Color.Lime;
            this.but_confirm.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_confirm.RectSelectedColor = System.Drawing.Color.Lime;
            this.but_confirm.Size = new System.Drawing.Size(71, 25);
            this.but_confirm.Style = Sunny.UI.UIStyle.Custom;
            this.but_confirm.StyleCustomMode = true;
            this.but_confirm.TabIndex = 154;
            this.but_confirm.Text = "확인";
            // 
            // cus_but_submit
            // 
            this.cus_but_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cus_but_submit.FillColor = System.Drawing.Color.White;
            this.cus_but_submit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cus_but_submit.FillPressColor = System.Drawing.Color.Lime;
            this.cus_but_submit.FillSelectedColor = System.Drawing.Color.White;
            this.cus_but_submit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cus_but_submit.ForeColor = System.Drawing.Color.Black;
            this.cus_but_submit.ForeHoverColor = System.Drawing.Color.DarkRed;
            this.cus_but_submit.ForePressColor = System.Drawing.Color.Red;
            this.cus_but_submit.Location = new System.Drawing.Point(166, 296);
            this.cus_but_submit.MinimumSize = new System.Drawing.Size(1, 1);
            this.cus_but_submit.Name = "cus_but_submit";
            this.cus_but_submit.RectColor = System.Drawing.Color.Black;
            this.cus_but_submit.RectDisableColor = System.Drawing.Color.Transparent;
            this.cus_but_submit.RectHoverColor = System.Drawing.Color.Lime;
            this.cus_but_submit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cus_but_submit.RectSelectedColor = System.Drawing.Color.Lime;
            this.cus_but_submit.Size = new System.Drawing.Size(87, 31);
            this.cus_but_submit.Style = Sunny.UI.UIStyle.Custom;
            this.cus_but_submit.StyleCustomMode = true;
            this.cus_but_submit.TabIndex = 153;
            this.cus_but_submit.Text = "등록";
            // 
            // input_serial
            // 
            this.input_serial.Location = new System.Drawing.Point(206, 261);
            this.input_serial.Name = "input_serial";
            this.input_serial.Size = new System.Drawing.Size(150, 21);
            this.input_serial.TabIndex = 152;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel4.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel4.Location = new System.Drawing.Point(61, 221);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(339, 31);
            this.uiLabel4.TabIndex = 151;
            this.uiLabel4.Text = "부여할 관리(일련)번호를 입력하세요.";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_weight
            // 
            this.output_weight.BackColor = System.Drawing.Color.Transparent;
            this.output_weight.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_weight.ForeColor = System.Drawing.Color.Black;
            this.output_weight.Location = new System.Drawing.Point(174, 152);
            this.output_weight.Name = "output_weight";
            this.output_weight.Size = new System.Drawing.Size(162, 26);
            this.output_weight.TabIndex = 150;
            this.output_weight.Text = "data";
            this.output_weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_size
            // 
            this.output_size.BackColor = System.Drawing.Color.Transparent;
            this.output_size.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_size.ForeColor = System.Drawing.Color.Black;
            this.output_size.Location = new System.Drawing.Point(174, 126);
            this.output_size.Name = "output_size";
            this.output_size.Size = new System.Drawing.Size(162, 26);
            this.output_size.TabIndex = 149;
            this.output_size.Text = "data";
            this.output_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel3.Location = new System.Drawing.Point(62, 152);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(90, 28);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 148;
            this.uiLabel3.Text = "※ 무게";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel2.Location = new System.Drawing.Point(62, 96);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(90, 28);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 147;
            this.uiLabel2.Text = "※ 품목";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_stock_name
            // 
            this.output_stock_name.BackColor = System.Drawing.Color.Transparent;
            this.output_stock_name.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.output_stock_name.ForeColor = System.Drawing.Color.Black;
            this.output_stock_name.Location = new System.Drawing.Point(174, 96);
            this.output_stock_name.Name = "output_stock_name";
            this.output_stock_name.Size = new System.Drawing.Size(162, 26);
            this.output_stock_name.TabIndex = 146;
            this.output_stock_name.Text = "data";
            this.output_stock_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.Transparent;
            this.text2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text2.ForeColor = System.Drawing.Color.Gray;
            this.text2.Location = new System.Drawing.Point(61, 124);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(93, 28);
            this.text2.Style = Sunny.UI.UIStyle.Custom;
            this.text2.TabIndex = 145;
            this.text2.Text = "※ 크기";
            this.text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_stock
            // 
            this.output_stock.DataSource = null;
            this.output_stock.FillColor = System.Drawing.Color.White;
            this.output_stock.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.output_stock.Location = new System.Drawing.Point(106, 49);
            this.output_stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.output_stock.MinimumSize = new System.Drawing.Size(63, 0);
            this.output_stock.Name = "output_stock";
            this.output_stock.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.output_stock.Size = new System.Drawing.Size(159, 25);
            this.output_stock.TabIndex = 142;
            this.output_stock.Text = "고객명";
            this.output_stock.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel5.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel5.Location = new System.Drawing.Point(10, 15);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(444, 29);
            this.uiLabel5.TabIndex = 143;
            this.uiLabel5.Text = "재고품목을 확인해주세요.";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(406, 47);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(210, 252);
            this.cxFlatPictureBox1.TabIndex = 157;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // Admin_stock_management_serial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.input_stock_index);
            this.Controls.Add(this.output_amount);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.but_confirm);
            this.Controls.Add(this.cus_but_submit);
            this.Controls.Add(this.input_serial);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.output_weight);
            this.Controls.Add(this.output_size);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.output_stock_name);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.output_stock);
            this.Controls.Add(this.uiLabel5);
            this.Name = "Admin_stock_management_serial";
            this.Size = new System.Drawing.Size(656, 334);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel uiLabel6;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UIComboBox input_stock_index;
        private Sunny.UI.UILabel output_amount;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton but_confirm;
        private Sunny.UI.UISymbolButton cus_but_submit;
        private System.Windows.Forms.TextBox input_serial;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel output_weight;
        private Sunny.UI.UILabel output_size;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel output_stock_name;
        private Sunny.UI.UILabel text2;
        private Sunny.UI.UIComboBox output_stock;
        private Sunny.UI.UILabel uiLabel5;
    }
}
