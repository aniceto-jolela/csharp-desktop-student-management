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
            txtEmail.DataBindings.Add(nameof(txtEmail.Text), _viewModel, nameof(_viewModel.Email), false, DataSourceUpdateMode.OnPropertyChanged);
            cbSex.SelectedIndex = 0;
            cbSex.DataBindings.Add(nameof(cbSex.SelectedItem), _viewModel, nameof(_viewModel.Sex), false, DataSourceUpdateMode.OnPropertyChanged);
            txtPhone.DataBindings.Add(nameof(txtPhone.Text), _viewModel, nameof(_viewModel.Phone), false, DataSourceUpdateMode.OnPropertyChanged);
            txtPassword.DataBindings.Add(nameof(txtPassword.Text), _viewModel, nameof(_viewModel.Password), false, DataSourceUpdateMode.OnPropertyChanged);
          
            dtpDateOfBirth.DataBindings.Add(nameof(dtpDateOfBirth.Value), _viewModel, nameof(_viewModel.DateOfBirth), false, DataSourceUpdateMode.OnPropertyChanged);
            dtpIssuedOn.DataBindings.Add(nameof(dtpIssuedOn.Value), _viewModel, nameof(_viewModel.IssuedOn), false, DataSourceUpdateMode.OnPropertyChanged);
            dtpValidUntil.DataBindings.Add(nameof(dtpValidUntil.Value), _viewModel, nameof(_viewModel.ValidUntil), false, DataSourceUpdateMode.OnPropertyChanged);

            //txtPhotoPath.DataBindings.Add(nameof(txtPhotoPath.Text), _viewModel, nameof(_viewModel.PhotoPath), false, DataSourceUpdateMode.OnPropertyChanged);
            //txtFileBiPath.DataBindings.Add(nameof(txtFileBiPath.Text), _viewModel, nameof(_viewModel.FileBiPath), false, DataSourceUpdateMode.OnPropertyChanged);
            //txtFileCvPath.DataBindings.Add(nameof(txtFileCvPath.Text), _viewModel, nameof(_viewModel.FileCvPath), false, DataSourceUpdateMode.OnPropertyChanged);


            _viewModel.RoleID = 3; // Set default role ID for Administrative Assistant

            btnRegister.Click += (s, e) =>
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    try
                    {
                        _viewModel.AddUserCommand.Execute(null);
                        //this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}");
                    }
                  
                }
            };
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

        private void RegisterAdministrativeAssistant_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {

        }

        private void kryptonDateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnCV_Click(object sender, EventArgs e)
        {
            openFileDialog3.Filter = "Arquivo de documento (*.pdf)|*.pdf|Todos os arquivos (*.*)|(*.*)";
            openFileDialog3.Title = "Selecionar um arquivo";

            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog3.FileName;
                MessageBox.Show("Arquivo selecionado: " + filePath);
                _viewModel.FileCvPath = openFileDialog3.FileName;
            }
        }
        private void btnBI_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Arquivo de documento (*.pdf)|*.pdf|Todos os arquivos (*.*)|(*.*)";
            openFileDialog2.Title = "Selecionar um arquivo";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog2.FileName;
                MessageBox.Show("Arquivo selecionado: " + filePath);
                _viewModel.FileBiPath = openFileDialog2.FileName;
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivo de imagem (*.jpg*;.jpeg*;.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Selecionar um arquivo";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                MessageBox.Show("Arquivo selecionado: " + filePath);
                _viewModel.PhotoPath = openFileDialog1.FileName;
            }
        }

        private void dtpIssuedOn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Nome de usuário é obrigatório.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }*/
        }
    }
}
