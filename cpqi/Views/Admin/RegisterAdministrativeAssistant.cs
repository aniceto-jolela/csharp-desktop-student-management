using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cpqi.ViewModels;

namespace cpqi.Views.Admin
{
    public partial class RegisterAdministrativeAssistant : Form
    {
        private readonly UserViewModel _viewModel;
        public RegisterAdministrativeAssistant()
        {
            InitializeComponent();

            _viewModel = new UserViewModel();

            txtUserName.DataBindings.Add(nameof(txtUserName.Text), _viewModel, nameof(_viewModel.UserName), false, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add(nameof(txtFullName.Text), _viewModel, nameof(_viewModel.FullName), false, DataSourceUpdateMode.OnPropertyChanged);
            cbSex.DataBindings.Add(nameof(cbSex.SelectedItem), _viewModel, nameof(_viewModel.Sex), false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add(nameof(txtEmail.Text), _viewModel, nameof(_viewModel.Email), false, DataSourceUpdateMode.OnPropertyChanged);
            txtPhone.DataBindings.Add(nameof(txtPhone.Text), _viewModel, nameof(_viewModel.Phone), false, DataSourceUpdateMode.OnPropertyChanged);
            txtPassword.DataBindings.Add(nameof(txtPassword.Text), _viewModel, nameof(_viewModel.Password), false, DataSourceUpdateMode.OnPropertyChanged);
            ckbIsStaff.DataBindings.Add(nameof(ckbIsStaff.Checked), _viewModel, nameof(_viewModel.IsStaff), false, DataSourceUpdateMode.OnPropertyChanged);
            ckbIsActive.DataBindings.Add(nameof(ckbIsActive.Checked), _viewModel, nameof(_viewModel.IsActive), false, DataSourceUpdateMode.OnPropertyChanged);
            ckbIsSuperUser.DataBindings.Add(nameof(ckbIsSuperUser.Checked), _viewModel, nameof(_viewModel.IsSuperUser), false, DataSourceUpdateMode.OnPropertyChanged);
            //dtpDateOfBirth.DataBindings.Add(nameof(dtpDateOfBirth.Value), _viewModel, nameof(_viewModel.DateOfBirth), false, DataSourceUpdateMode.OnPropertyChanged);
            
            _viewModel.RoleID = 3; // Set default role ID for Administrative Assistant

            btnRegister.Click += (s, e) =>
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    _viewModel.AddUserCommand.Execute(null);
                    MessageBox.Show("User registered successfully!");
                    this.Close();
                }
            };
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
