using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;

namespace cpqi.Helpers
{
    public static class ShowStatusMessage
    {
        public static void ShowMessage(KryptonLabel lblStatusMessage, string message, System.Windows.Forms.Timer StatusTimer)
        {
            lblStatusMessage.Text = message;
            lblStatusMessage.Visible = true;
            lblStatusMessage.ForeColor = Color.Green;
            StatusTimer.Start();
        }
        public static void StatusTimerTick(KryptonLabel lblStatusMessage, System.Windows.Forms.Timer StatusTimer) // Tick
        {
            StatusTimer.Stop();
            lblStatusMessage.Visible = false;
        }
    }
}
