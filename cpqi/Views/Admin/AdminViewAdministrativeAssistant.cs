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
        public AdminViewAdministrativeAssistant(UserFormViewModel viewModel)
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
        }

        private void ViewAdministrativeAssistant_Load(object sender, EventArgs e)
        {
            /*
          cbSex.DataSource = new string[] { "MASCULINO", "FEMININO", "OUTRO" };
          cbRole.DataSource = _viewModel.Roles;
          cbRole.DisplayMember = "RoleName";
          cbRole.ValueMember = "RoleID";

          dgvUsers.DataSource = _viewModel.Users;
          dgvUsers.SelectionChanged += (s, e) =>
          {
              if (dgvUsers.CurrentRow?.DataBoundItem is User user)
                  _viewModel.SelectedUser = user;
              else
                  _viewModel.SelectedUser = null;
          };

          // Botões
          btnAdd.Click += (s, e) => _viewModel.AddUserCommand.Execute(null);
          btnUpdate.Click += (s, e) => _viewModel.UpdateUserCommand.Execute(null);
          btnDelete.Click += (s, e) => _viewModel.DeleteUserCommand.Execute(null);*/
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
