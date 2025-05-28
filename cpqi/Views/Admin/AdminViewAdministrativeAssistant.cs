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

            dgvAdminAssistant.CellValueChanged += dgvAdminAssistant_CellValueChanged;
            dgvAdminAssistant.UserDeletingRow += dgvAdminAssistant_UserDeletingRow;
        }
        private async void LoadData()
        {
            try
            {
                await _viewModel.LoadUsers();

                dgvAdminAssistant.AutoGenerateColumns = false;
                ConfigureGridColumns();
                dgvAdminAssistant.DataSource = _viewModel.Users;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
        private void ConfigureGridColumns()
        {
            dgvAdminAssistant.Columns.Clear();

            dgvAdminAssistant.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "USUÁRIO",
                DataPropertyName = "UserName",
                Name = "UserName"
            });

            dgvAdminAssistant.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "NOME COMPLETO",
                DataPropertyName = "FullName",
                Width = 400,
                Name = "FullName"
            });

            dgvAdminAssistant.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "EMAIL",
                DataPropertyName = "Email",
                Width = 300,
                Name = "Email"
            });

            dgvAdminAssistant.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "CARGO",
                DataPropertyName = "RoleName",
                Name = "RoleName",
                ReadOnly = true
            });
        }

        private void ViewAdministrativeAssistant_Load(object sender, EventArgs e)
        {

        }

        private async void dgvAdminAssistant_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var user = dgvAdminAssistant.Rows[e.RowIndex].DataBoundItem as User;
                if (user != null)
                {
                    await _viewModel.UpdateUserFromGrid(user);
                }
            }
        }

        private async void dgvAdminAssistant_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var user = e.Row.DataBoundItem as User;
            if (user != null)
            {
                var confirm = MessageBox.Show("Deseja realmente excluir este usuário?", "Confirmar exclusão", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    await _viewModel.DeleteUserFromGrid(user.UserID);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
