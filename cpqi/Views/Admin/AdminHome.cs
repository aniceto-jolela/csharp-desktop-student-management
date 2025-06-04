using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cpqi.Data;
using cpqi.Helpers;
using cpqi.Models;
using cpqi.ViewModels;

namespace cpqi.Views.Admin
{
    public partial class AdminHome : Krypton.Toolkit.KryptonForm
    {
        private readonly FormManager _formManager;
        private readonly AuthenticatedUserViewModel _userViewModel;
        private readonly User _user;

        private readonly System.Windows.Forms.Timer timer = new();
        private readonly TimeZoneInfo angolaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Africa/Luanda");
        private bool closeAllowed = false;
        public AdminHome(User user, FormManager formManager, AuthenticatedUserViewModel userViewModel)
        {
            InitializeComponent();
            _user = user;
            _formManager = formManager;
            _userViewModel = userViewModel;

            // TIMEZONE
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            lblFullName.Text = $"Bem-vindo, {_user.FullName}";
            LoadPhotoView.ProfilePhoto(_user.PhotoPath, PbProfile);
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            DateTime utcNow = DateTime.UtcNow;
            DateTime angolaTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, angolaTimeZone);
            lbl_datatime.Text = angolaTime.ToString("yyyy-MM-dd  HH:mm:ss");
        }
        private void AdHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeAllowed && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the close event button [x]
                MessageBox.Show("Por favor, use o botão de logout (ícone no topo) para encerrar a sessão.",
                       "Encerramento Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnPag1_Click(object sender, EventArgs e)
        {
            kryptonNavigator1.SelectedIndex = 0;
        }
        private void BtnPag2_Click(object sender, EventArgs e)
        {
            kryptonNavigator1.SelectedIndex = 1;
        }
        private void BtnPag3_Click(object sender, EventArgs e)
        {
            kryptonNavigator1.SelectedIndex = 2;
        }
        private void BtnRAssistant_Click(object sender, EventArgs e)
        {
            _formManager.ShowAdminRegisterAdministrativeAssistantForm();
        }
        private void BtnViewAdminAssistant_Click(object sender, EventArgs e)
        {
            _formManager.ShowAdminViewAdministrativeAssistantForm();
        }
        private void BtnRule_Click(object sender, EventArgs e)
        {
            _formManager.ShowAdminRolesForm();
        }
        private void PbProfile_Click(object sender, EventArgs e)
        {
            _formManager.ShowAdminProfileForm();
        }
        private void PbLogout_Click(object sender, EventArgs e)
        {
            closeAllowed = true; // Allow closing the form
            _userViewModel.Logout();
            Application.Exit();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
