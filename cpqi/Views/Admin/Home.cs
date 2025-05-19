using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpqi.Views.Admin
{
    public partial class admin_home : Form
    {
        private System.Windows.Forms.Timer timer;
        private TimeZoneInfo angolaTimeZone;
        private bool closeAllowed = false;

        public admin_home()
        {
            InitializeComponent();
            //TABE CONTROL HORIZONTAL
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);

            // TIMEZONE
            angolaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Africa/Luanda");
            // Initialize timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; //1 second
            timer.Tick += Timer_Tick;
            timer.Start();


        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            closeAllowed = true; // Allow closing the form
            Application.Exit();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);

            // Draw background
            e.Graphics.FillRectangle(SystemBrushes.Control, tabBounds);

            // Draw tab text horizontally
            StringFormat stringFlags = new StringFormat();
            stringFlags.Alignment = StringAlignment.Center;
            stringFlags.LineAlignment = StringAlignment.Center;

            // Draw the tab text
            e.Graphics.DrawString(
                tabPage.Text,
                this.Font,
                SystemBrushes.ControlText,
                tabBounds,
                stringFlags
            );

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime utcNow = DateTime.UtcNow;
            DateTime angolaTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, angolaTimeZone);
            lbl_datatime.Text = angolaTime.ToString("yyyy-MM-dd  HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterAdministrativeAssistant raa = new RegisterAdministrativeAssistant();
            raa.ShowDialog();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.ShowDialog();
        }

        private void btn_rule_Click(object sender, EventArgs e)
        {
            ViewRules rules = new ViewRules();
            rules.ShowDialog();
        }

        private void btnViewAdminAssistant_Click(object sender, EventArgs e)
        {
            ViewAdministrativeAssistant viewAdminAssistant = new ViewAdministrativeAssistant();
            viewAdminAssistant.ShowDialog();
        }

        private void admin_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeAllowed && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the close event button [x]
                MessageBox.Show("Por favor usa o botão sair para ausentar-se da aplicação.", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
    }
}
