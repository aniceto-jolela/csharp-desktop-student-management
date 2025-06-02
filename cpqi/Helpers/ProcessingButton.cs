using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;

namespace cpqi.Helpers
{
    public static class ProcessingButton
    {
        /// <summary>
        /// Toggles the status of the button interface and charging indicator.
        /// </summary>
        /// <param name="enabled">Defines whether the button will be enabled or not.</param>
        /// <param name="button">The button being activated or deactivated.</param>
        /// <param name="pBLoading">The image control (PictureBox) used as a loading indicator.</param>
        public static void ToggleUI(bool enabled, KryptonButton button, KryptonPictureBox pBLoading)
        {
            button.Enabled = enabled;
            pBLoading.Visible = !enabled; // A gif image is required for picturebox
        }
    }
}
