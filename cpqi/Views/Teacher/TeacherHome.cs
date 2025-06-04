using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cpqi.Models;

namespace cpqi.Views.Teacher
{
    public partial class TeacherHome : Krypton.Toolkit.KryptonForm
    {
        private readonly FormManager _formManager;
        private readonly AuthenticatedUserViewModel _userViewModel;
        private readonly User _user;

        private readonly System.Windows.Forms.Timer timer = new();
        private readonly TimeZoneInfo angolaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Africa/Luanda");
        private bool closeAllowed = false;
        public TeacherHome(User user, FormManager formManager, AuthenticatedUserViewModel userViewModel)
        {
            InitializeComponent();
            _user = user;
            _formManager = formManager;
            _userViewModel = userViewModel;

            // TIMEZONE
            /*timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            lblFullName.Text = $"Bem-vindo, {_user.FullName}";
            LoadPhotoView.ProfilePhoto(_user.PhotoPath, PbProfile);*/
        }
    }
}
