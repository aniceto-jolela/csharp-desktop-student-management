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

        private int _hoveredRowIndex = -1;
        private int _pressedRowIndex = -1;
        public AdminViewAdministrativeAssistant(UserFormViewModel viewModel, FormManager formManager)
        {
            InitializeComponent();
            _viewModel = viewModel;
            _formManage = formManager;

            //dgvAdminAssistant.CellFormatting += dgvAdminAssistant_CellFormatting;
            dgvAdminAssistant.CellPainting += dgvAdminAssistant_CellPainting;
            dgvAdminAssistant.CellMouseEnter += dgvAdminAssistant_CellMouseEnter;
            dgvAdminAssistant.CellMouseLeave += dgvAdminAssistant_CellMouseLeave;
            dgvAdminAssistant.CellMouseDown += dgvAdminAssistant_CellMouseDown;
            dgvAdminAssistant.CellMouseUp += dgvAdminAssistant_CellMouseUp;
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
                
                // Load images for the "Profile" and "Delete" columns
                foreach (DataGridViewRow row in dgvAdminAssistant.Rows)
                {
                    row.Cells["Perfil"].Value = Properties.Resources.profile_icon; // Profile icon
                    row.Cells["Eliminar"].Value = Properties.Resources.delete_icon; // Delete icon
                }
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

            dgvAdminAssistant.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Perfil",
                HeaderText = "PERFIL",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 50
            });

            dgvAdminAssistant.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "ACESSO",
                Name = "Access",
                UseColumnTextForButtonValue = false,
                Width = 80
            });
            dgvAdminAssistant.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Eliminar",
                HeaderText = "ELIMINAR",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 50
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
            if (column.Name == "Access")
            {
                user.IsStaff = !user.IsStaff;

                var cell = dgvAdminAssistant.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Value = user.IsStaff ? "SIM" : "NÃO";
                dgvAdminAssistant.InvalidateCell(cell);

                await _viewModel.AccessUserFromGrid(user.UserID, user.IsStaff);
            }
            else if (column.Name == "Eliminar")
            {
                var confirm = MessageBox.Show("Tem certeza que deseja eliminar este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    //await _viewModel.DeleteUserFromGrid(user.UserID);
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
                    //await _viewModel.UpdateUserFromGrid(user);
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

        private void dgvAdminAssistant_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvAdminAssistant.Columns[e.ColumnIndex].Name == "Access")
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);

                var user = dgvAdminAssistant.Rows[e.RowIndex].DataBoundItem as User;
                if (user == null) return;

                // Text and color
                string text = user.IsStaff ? "SIM" : "NÃO";
                Color backColor = user.IsStaff ? Color.Green : SystemColors.Control;
                Color foreColor = user.IsStaff ? Color.White : Color.Black;

                // Hover
                if (e.RowIndex == _hoveredRowIndex)
                    backColor = user.IsStaff ? Color.ForestGreen : Color.LightGray;
                    
                // press
                if (e.RowIndex == _pressedRowIndex)
                    backColor = user.IsStaff ? Color.DarkGreen : Color.Gray;

                Rectangle buttonRect = new Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2,
                                                     e.CellBounds.Width - 4, e.CellBounds.Height - 4);

                using (Brush backBrush = new SolidBrush(backColor))
                using (Pen borderPen = new Pen(Color.DarkGray))
                {
                    e.Graphics.FillRectangle(backBrush, buttonRect);
                    e.Graphics.DrawRectangle(borderPen, buttonRect);
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    text,
                    dgvAdminAssistant.Font,
                    buttonRect,
                    foreColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void dgvAdminAssistant_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvAdminAssistant.Columns[e.ColumnIndex].Name == "Access")
            {
                _hoveredRowIndex = e.RowIndex;
                dgvAdminAssistant.InvalidateCell(e.ColumnIndex, e.RowIndex);
            }
        }

        private void dgvAdminAssistant_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvAdminAssistant.Columns[e.ColumnIndex].Name == "Access")
            {
                _hoveredRowIndex = -1;
                dgvAdminAssistant.InvalidateCell(e.ColumnIndex, e.RowIndex);
                dgvAdminAssistant.Cursor = Cursors.Default;
            }
        }

        private void dgvAdminAssistant_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvAdminAssistant.Columns[e.ColumnIndex].Name == "Access")
            {
                _pressedRowIndex = e.RowIndex;
                dgvAdminAssistant.InvalidateCell(e.ColumnIndex, e.RowIndex);
            }
        }

        private void dgvAdminAssistant_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvAdminAssistant.Columns[e.ColumnIndex].Name == "Access")
            {
                _pressedRowIndex = -1;
                dgvAdminAssistant.InvalidateCell(e.ColumnIndex, e.RowIndex);
            }
        }
    }
}
