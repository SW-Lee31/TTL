
namespace View_structure_0811.UI.Admin_contents
{
    partial class Admin_stock_management
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_panel = new Sunny.UI.UIFlowLayoutPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.main_panel = new Sunny.UI.UIFlowLayoutPanel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.but_del = new Sunny.UI.UIHeaderButton();
            this.but_serial = new Sunny.UI.UIHeaderButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_panel
            // 
            this.chart_panel.Controls.Add(this.uiLabel1);
            this.chart_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart_panel.FillColor = System.Drawing.Color.White;
            this.chart_panel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chart_panel.Location = new System.Drawing.Point(0, 0);
            this.chart_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_panel.MinimumSize = new System.Drawing.Size(1, 1);
            this.chart_panel.Name = "chart_panel";
            this.chart_panel.Padding = new System.Windows.Forms.Padding(2);
            this.chart_panel.RectColor = System.Drawing.Color.Transparent;
            this.chart_panel.Size = new System.Drawing.Size(515, 42);
            this.chart_panel.Style = Sunny.UI.UIStyle.Custom;
            this.chart_panel.TabIndex = 0;
            this.chart_panel.Text = "uiFlowLayoutPanel1";
            this.chart_panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Silver;
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(2, 2);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(511, 38);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "입출고 동향";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.uiLine1);
            this.main_panel.Controls.Add(this.but_del);
            this.main_panel.Controls.Add(this.but_serial);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.main_panel.FillColor = System.Drawing.Color.White;
            this.main_panel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.main_panel.Location = new System.Drawing.Point(0, 299);
            this.main_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.main_panel.MinimumSize = new System.Drawing.Size(1, 1);
            this.main_panel.Name = "main_panel";
            this.main_panel.Padding = new System.Windows.Forms.Padding(2);
            this.main_panel.RectColor = System.Drawing.Color.Transparent;
            this.main_panel.Size = new System.Drawing.Size(515, 59);
            this.main_panel.Style = Sunny.UI.UIStyle.Custom;
            this.main_panel.TabIndex = 1;
            this.main_panel.Text = "uiFlowLayoutPanel1";
            this.main_panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.Location = new System.Drawing.Point(-1, 0);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(517, 3);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 5;
            // 
            // but_del
            // 
            this.but_del.CircleSize = 0;
            this.but_del.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_del.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_del.Location = new System.Drawing.Point(256, 2);
            this.but_del.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_del.Name = "but_del";
            this.but_del.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.but_del.Radius = 0;
            this.but_del.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_del.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_del.Size = new System.Drawing.Size(257, 55);
            this.but_del.Style = Sunny.UI.UIStyle.Custom;
            this.but_del.Symbol = 61633;
            this.but_del.SymbolColor = System.Drawing.Color.Black;
            this.but_del.TabIndex = 4;
            this.but_del.Text = "배송정보 관리";
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // but_serial
            // 
            this.but_serial.CircleSize = 0;
            this.but_serial.Dock = System.Windows.Forms.DockStyle.Left;
            this.but_serial.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_serial.Location = new System.Drawing.Point(2, 2);
            this.but_serial.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_serial.Name = "but_serial";
            this.but_serial.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.but_serial.Radius = 0;
            this.but_serial.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.but_serial.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.but_serial.Size = new System.Drawing.Size(257, 55);
            this.but_serial.Style = Sunny.UI.UIStyle.Custom;
            this.but_serial.Symbol = 61484;
            this.but_serial.SymbolColor = System.Drawing.Color.Black;
            this.but_serial.TabIndex = 3;
            this.but_serial.Text = "관리번호 부여";
            this.but_serial.Click += new System.EventHandler(this.but_stock_digit_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 42);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(515, 257);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Admin_stock_management
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.chart_panel);
            this.Name = "Admin_stock_management";
            this.Size = new System.Drawing.Size(515, 358);
            this.chart_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel chart_panel;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIFlowLayoutPanel main_panel;
        private Sunny.UI.UIHeaderButton but_del;
        private Sunny.UI.UIHeaderButton but_serial;
        private Sunny.UI.UILine uiLine1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
