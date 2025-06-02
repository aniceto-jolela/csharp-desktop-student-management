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
        private readonly UserFormViewModel _viewModel;
        private readonly FormManager _formManage;
        public AdminViewAdministrativeAssistant(UserFormViewModel viewModel, FormManager formManager)
        {
            InitializeComponent();
            _viewModel = viewModel;
            _formManage = formManager;
            LoadData();

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
                Width = 160,
                Name = "UserName"
            });

            dgvAdminAssistant.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "NOME COMPLETO",
                DataPropertyName = "FullName",
                Width = 460,
                Name = "FullName"
            });

            dgvAdminAssistant.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "SEXO",
                DataPropertyName = "Sex",
                Width = 100,
                Name = "Sex"
            });

            dgvAdminAssistant.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "EMAIL",
                DataPropertyName = "Email",
                Width = 330,
                Name = "Email"
            });

            dgvAdminAssistant.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "CARGO",
                DataPropertyName = "RoleName",
                Width = 170,
                Name = "RoleName",
                ReadOnly = true
            });

            dgvAdminAssistant.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Perfil",
                HeaderText = "",
                Text = "Perfil",
                UseColumnTextForButtonValue = true,
                Width = 80
            });

            dgvAdminAssistant.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = "",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Width = 80
            });
        }
        private async void dgvAdminAssistant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var user = dgvAdminAssistant.Rows[e.RowIndex].DataBoundItem as User;
            if (user == null) return;

            var column = dgvAdminAssistant.Columns[e.ColumnIndex];

            if (column.Name == "Perfil")
            {
                _viewModel.LoadUserData(user); // Loads data into the ViewModel and opens the form
                _formManage.ShowAdminAssistantProfile(user);
            }
            else if (column.Name == "Eliminar")
            {
                var confirm = MessageBox.Show("Tem certeza que deseja eliminar este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    await _viewModel.DeleteUserFromGrid(user.UserID);
                    LoadData(); // Update grid
                }
            }
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
