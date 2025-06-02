using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;

namespace cpqi.Helpers
{
    public static class FileButtonColor
    {
        public static void SuccessButton(KryptonButton button)
        {
            button.PaletteMode = PaletteMode.Office2010Black;
        }
        public static void ResetCustomButtonStyles(KryptonButton btnPhoto, KryptonButton btnBI, KryptonButton? btnCV)
        {
            btnPhoto.PaletteMode = PaletteMode.Global;
            btnBI.PaletteMode = PaletteMode.Global;
            if (btnCV != null ) 
                btnCV.PaletteMode = PaletteMode.Global;
        }
    }
}
