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
    public partial class adHome : Krypton.Toolkit.KryptonForm
    {
        private System.Windows.Forms.Timer timer;
        private TimeZoneInfo angolaTimeZone;
        private bool closeAllowed = false;
        public adHome()
        {
            InitializeComponent();

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
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime utcNow = DateTime.UtcNow;
            DateTime angolaTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, angolaTimeZone);
            lbl_datatime.Text = angolaTime.ToString("yyyy-MM-dd  HH:mm:ss");
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.ShowDialog();
        }

        private void adHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeAllowed && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the close event button [x]
                MessageBox.Show("Por favor usa o botão sair para ausentar-se da aplicação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnPag1_Click(object sender, EventArgs e)
        {
            kryptonNavigator1.SelectedIndex = 0;
        }

        private void btnPag2_Click(object sender, EventArgs e)
        {
            kryptonNavigator1.SelectedIndex = 1;
        }

        private void btnPag3_Click(object sender, EventArgs e)
        {
            kryptonNavigator1.SelectedIndex = 2;
        }

        private void kryptonPage1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_datatime_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void adHome_Load(object sender, EventArgs e)
        {

        }

        private void btnPag1_Click_1(object sender, EventArgs e)
        {
            kryptonNavigator1.SelectedIndex = 0;
        }

        private void btnPag2_Click_1(object sender, EventArgs e)
        {
            kryptonNavigator1.SelectedIndex = 1;
        }

        private void btnPag3_Click_1(object sender, EventArgs e)
        {
            kryptonNavigator1.SelectedIndex = 2;
        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
