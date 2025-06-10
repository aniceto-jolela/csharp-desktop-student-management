using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cpqi.Helpers;

namespace cpqi.Views.Assistant
{
    public partial class AssistantProfile : Form
    {
        private readonly AuthenticatedUserViewModel _authUser;
        private readonly UserFormViewModel _viewModel;
        public AssistantProfile(AuthenticatedUserViewModel authUser, UserFormViewModel viewModel)
        {
            InitializeComponent();
            _authUser = authUser;
            _viewModel = viewModel;

            LoadUserData();
        }
        private void LoadUserData()
        {
            _viewModel.UserName = _authUser.UserName;
            _viewModel.FullName = _authUser.FullName;
            _viewModel.Email = _authUser.Email;
            _viewModel.Sex = _authUser.Sex;
            _viewModel.Phone = _authUser.Phone;
            _viewModel.Bi = _authUser.Bi;
            _viewModel.DateOfBirth = _authUser.DateOfBirth;
            _viewModel.IssuedOn = _authUser.IssuedOn;
            _viewModel.ValidUntil = _authUser.ValidUntil;
            _viewModel.PhotoPath = _authUser.PhotoPath;

            // Label
            LblUser.Text = _viewModel.UserName;
            LblFullName.Text = _viewModel.FullName;
            LblEmail.Text = _viewModel.Email;
            LblPhone.Text = _viewModel.Phone;
            LblSex.Text = _viewModel.Sex;
            LblNBI.Text = _viewModel.Bi;
            LblRole.Text = _authUser.RoleName;
            LblBirthDay.Text = _viewModel.DateOfBirth.ToShortDateString();
            LblIssuedOn.Text = _viewModel.IssuedOn.ToShortDateString();
            LblValidUntil.Text = _viewModel.ValidUntil.ToShortDateString();
            LoadPhotoView.ProfilePhoto(_viewModel.PhotoPath, PbPhoto);

            _viewModel.SelectedUser = _authUser.LoggedUser;

        }


        private void kryptonLabel15_Click(object sender, EventArgs e)
        {

        }
    }
}
