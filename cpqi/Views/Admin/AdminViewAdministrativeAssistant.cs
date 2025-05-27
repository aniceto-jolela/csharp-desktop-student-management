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
using Microsoft.EntityFrameworkCore;

namespace cpqi.Views.Admin
{
    public partial class AdminViewAdministrativeAssistant : Form
    {
        private readonly UserViewModel _viewModel;
        public AdminViewAdministrativeAssistant(UserViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            LoadData();
        }
        private async void LoadData()
        {
            try
            {
                await _viewModel.LoadUsers();
                dgvAdminAssistant.DataSource = _viewModel.Users.ToList();
                
                //btnAdd.Click += (s, e) => _viewModel.AddUserCommand.Execute(null);
                //btnUpdate.Click += (s, e) => _viewModel.UpdateUserCommand.Execute(null);
                //btnDelete.Click += (s, e) => _viewModel.DeleteUserCommand.Execute(null);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void ViewAdministrativeAssistant_Load(object sender, EventArgs e)
        {

        }
    }
}
