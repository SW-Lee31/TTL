using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View_structure_0811.Util
{
    class Common
    {
        public static void Theme_light(MaterialForm form)
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(form);
            skin.Theme = MaterialSkinManager.Themes.LIGHT;
            skin.ColorScheme = new ColorScheme(
                Primary.Grey700,
                Primary.Grey700,
                Primary.Grey700,
                Accent.Teal700,
                TextShade.BLACK);
        }
    }
}
