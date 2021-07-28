using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0727_03_Winform.Util
{
    class Common
    {
        public static void InitTheme(MaterialForm form)
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(form);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.Grey600,
                Primary.Grey600,
                Primary.Grey600,
                Accent.Teal700,
                TextShade.BLACK);
        }

        public static void InitTheme_2(MaterialForm form)
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(form);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.Grey900,
                Primary.Grey900,
                Primary.Grey900,
                Accent.Teal700,
                TextShade.BLACK);
        }
    }
}
