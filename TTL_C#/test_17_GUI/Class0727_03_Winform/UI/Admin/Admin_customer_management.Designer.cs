
namespace Class0727_03_Winform.UI
{
    partial class Admin_customer_management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cus_listview = new System.Windows.Forms.ListView();
            this.ordinary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.digit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.joined_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birth_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cus_sub_path = new System.Windows.Forms.DataGridView();
            this.sub_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordered_senum = new System.Windows.Forms.DataGridView();
            this.owned_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_digit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.cus_sub_path)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordered_senum)).BeginInit();
            this.SuspendLayout();
            // 
            // cus_listview
            // 
            this.cus_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ordinary,
            this.name,
            this.digit,
            this.address,
            this.gender,
            this.joined_date,
            this.birth_date,
            this.member_digit});
            this.cus_listview.FullRowSelect = true;
            this.cus_listview.GridLines = true;
            this.cus_listview.HideSelection = false;
            this.cus_listview.Location = new System.Drawing.Point(3, 71);
            this.cus_listview.Name = "cus_listview";
            this.cus_listview.Size = new System.Drawing.Size(600, 300);
            this.cus_listview.TabIndex = 0;
            this.cus_listview.UseCompatibleStateImageBehavior = false;
            this.cus_listview.View = System.Windows.Forms.View.Details;
            this.cus_listview.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.cus_listview_ItemMouseHover);
            this.cus_listview.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.cus_listview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cus_listview_MouseDoubleClick);
            // 
            // ordinary
            // 
            this.ordinary.Text = "Ordinary";
            this.ordinary.Width = 63;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 70;
            // 
            // digit
            // 
            this.digit.Text = "Digit";
            this.digit.Width = 112;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 173;
            // 
            // gender
            // 
            this.gender.Text = "Gender";
            this.gender.Width = 57;
            // 
            // joined_date
            // 
            this.joined_date.Text = "Joined Date";
            this.joined_date.Width = 137;
            // 
            // birth_date
            // 
            this.birth_date.Text = "Birth Date";
            this.birth_date.Width = 126;
            // 
            // cus_sub_path
            // 
            this.cus_sub_path.AllowUserToAddRows = false;
            this.cus_sub_path.AllowUserToDeleteRows = false;
            this.cus_sub_path.AllowUserToResizeColumns = false;
            this.cus_sub_path.AllowUserToResizeRows = false;
            this.cus_sub_path.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cus_sub_path.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sub_path});
            this.cus_sub_path.Location = new System.Drawing.Point(609, 71);
            this.cus_sub_path.Name = "cus_sub_path";
            this.cus_sub_path.RowTemplate.Height = 23;
            this.cus_sub_path.Size = new System.Drawing.Size(142, 139);
            this.cus_sub_path.TabIndex = 1;
            // 
            // sub_path
            // 
            this.sub_path.HeaderText = "Joined Path";
            this.sub_path.Name = "sub_path";
            // 
            // ordered_senum
            // 
            this.ordered_senum.AllowUserToAddRows = false;
            this.ordered_senum.AllowUserToDeleteRows = false;
            this.ordered_senum.AllowUserToResizeColumns = false;
            this.ordered_senum.AllowUserToResizeRows = false;
            this.ordered_senum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordered_senum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.owned_car});
            this.ordered_senum.Location = new System.Drawing.Point(609, 216);
            this.ordered_senum.Name = "ordered_senum";
            this.ordered_senum.RowTemplate.Height = 23;
            this.ordered_senum.Size = new System.Drawing.Size(142, 155);
            this.ordered_senum.TabIndex = 2;
            // 
            // owned_car
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.owned_car.DefaultCellStyle = dataGridViewCellStyle1;
            this.owned_car.HeaderText = "Ordered Serial Number";
            this.owned_car.Name = "owned_car";
            // 
            // member_digit
            // 
            this.member_digit.Text = "Member Digit";
            // 
            // Admin_customer_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.ordered_senum);
            this.Controls.Add(this.cus_sub_path);
            this.Controls.Add(this.cus_listview);
            this.Name = "Admin_customer_management";
            this.Text = "Customer_management";
            this.Load += new System.EventHandler(this.Admin_customer_management_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Admin_customer_management_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.cus_sub_path)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordered_senum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView cus_listview;
        private System.Windows.Forms.ColumnHeader ordinary;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader digit;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader joined_date;
        private System.Windows.Forms.ColumnHeader birth_date;
        private System.Windows.Forms.DataGridView cus_sub_path;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_path;
        private System.Windows.Forms.DataGridView ordered_senum;
        private System.Windows.Forms.DataGridViewTextBoxColumn owned_car;
        private System.Windows.Forms.ColumnHeader member_digit;
    }
}