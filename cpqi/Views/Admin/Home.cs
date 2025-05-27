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
using cpqi.Models;
using cpqi.ViewModels;

namespace cpqi.Views.Admin
{
    public partial class AdminHome : Krypton.Toolkit.KryptonForm
    {
        private readonly FormManager _formManager;
        private readonly UserViewModel _userViewModel;
        private readonly User _user;
        private readonly CpqiDbContext _context;

        private readonly System.Windows.Forms.Timer timer = new();
        private readonly TimeZoneInfo angolaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Africa/Luanda");
        private bool closeAllowed = false;
        public AdminHome(User user, FormManager formManager, UserViewModel userViewModel, CpqiDbContext context)
        {
            InitializeComponent();
            _user = user;
            _formManager = formManager;
            _userViewModel = userViewModel;
            _context = context;

            if (_user.Role == null || _user.Role.RoleName != "Administrador")
            {
                MessageBox.Show("Acesso negado.");
                this.Close();
                return;
            }


            // TIMEZONE
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            lblFullName.Text = $"Bem-vindo, {_user.FullName}";
            
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            DateTime utcNow = DateTime.UtcNow;
            DateTime angolaTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, angolaTimeZone);
            lbl_datatime.Text = angolaTime.ToString("yyyy-MM-dd  HH:mm:ss");
        }

        private void adHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeAllowed && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the close event button [x]
                MessageBox.Show("Por favor, use o botão de logout (ícone no topo) para encerrar a sessão.",
                       "Encerramento Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnRAssistant_Click(object sender, EventArgs e)
        {
            new RegisterAdministrativeAssistant(_userViewModel).ShowDialog();
        }

        private void btnViewAdminAssistant_Click(object sender, EventArgs e)
        {
            new ViewAdministrativeAssistant(_context).ShowDialog();
        }

        private void btn_rule_Click(object sender, EventArgs e)
        {
            new ViewRules(_context).ShowDialog();
        }

        private void pbProfile1_Click(object sender, EventArgs e)
        {
            new Profile(_userViewModel).ShowDialog();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            closeAllowed = true; // Allow closing the form
            this.Close();
            _userViewModel.Logout();
            _formManager.ShowLoginForm();
        }
    }
}
