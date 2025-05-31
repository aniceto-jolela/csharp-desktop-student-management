using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;

namespace cpqi.Helpers
{
    public class LoadPhoto
    {
        public static void ProfilePhoto(string? photoPath, KryptonPictureBox PbPhoto)
        {
            if (!string.IsNullOrWhiteSpace(photoPath) && File.Exists(photoPath))
                PbPhoto.Image = Image.FromFile(photoPath);
            else
                PbPhoto.Image = Properties.Resources.administrator;
        }
    }
}
