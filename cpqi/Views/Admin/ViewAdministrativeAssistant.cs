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
using cpqi.ViewModels;

namespace cpqi.Views.Admin
{
    public partial class ViewAdministrativeAssistant : Form
    {
        private readonly UserViewModel _viewModel;
        public ViewAdministrativeAssistant()
        {
            InitializeComponent();

            _viewModel = new UserViewModel();

            dgvAdminAssistant.DataSource = _viewModel.Users;

            // Atualizar SelectedUser ao selecionar linha no DataGridView
            /*dgvAdminAssistant.SelectionChanged += (s, e) =>
            {
                if (dgvAdminAssistant.CurrentRow?.DataBoundItem is User user)
                    _viewModel.SelectedUser = user;
            };*/

            //btnAdd.Click += (s, e) => _viewModel.AddUserCommand.Execute(null);
            //btnUpdate.Click += (s, e) => _viewModel.UpdateUserCommand.Execute(null);
            //btnDelete.Click += (s, e) => _viewModel.DeleteUserCommand.Execute(null);
        }

        private void ViewAdministrativeAssistant_Load(object sender, EventArgs e)
        {

        }
    }
}
