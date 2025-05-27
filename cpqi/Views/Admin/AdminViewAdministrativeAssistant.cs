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
        private readonly CpqiDbContext _context;
        public AdminViewAdministrativeAssistant(CpqiDbContext context)
        {
            InitializeComponent();
            _context = context;
            LoadData();
        }
        private async void LoadData()
        {
            try
            {
                var users = await _context.Users
                    .Select(u=>new
                    {
                        u.UserID,
                        u.UserName,
                        u.FullName,
                        u.Sex
                    })
                    .ToListAsync();

                var table = new DataTable();
                table.Columns.Add("Nº", typeof(int));
                table.Columns.Add("USUÁRIOS", typeof(string));
                table.Columns.Add("NOME COMPLETO", typeof(string));
                table.Columns.Add("SEXO", typeof(string));

                foreach(var user in users)
                {
                    table.Rows.Add(user.UserID, user.UserName);
                }
                dgvAdminAssistant.DataSource = table;

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
