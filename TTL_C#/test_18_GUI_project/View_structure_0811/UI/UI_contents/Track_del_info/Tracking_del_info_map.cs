using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_structure_0811.Util;

namespace View_structure_0811.UI.UI_contents.Track_del_info
{
    public partial class Tracking_del_info_map : MaterialForm
    {
        string location;

        public Tracking_del_info_map()
        {
            InitializeComponent();
        }

        public Tracking_del_info_map(string location)
        {
            InitializeComponent();
            this.location = location;
        }

        private void Tracking_del_info_map_Load(object sender, EventArgs e)
        {
            Common.Theme_light(this);
            this.pointer.Location = new Point(228, 361);

            // 대구 위치정보 228, 361
            // 서울 정보 112, 248
            // 부산 정보 316, 399
            // 대전 정보 145, 338
            // 광주 98, 432
            // 강원도 204, 237
            // 인천 53, 244


        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
