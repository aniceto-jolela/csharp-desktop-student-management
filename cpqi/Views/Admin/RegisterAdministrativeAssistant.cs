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
        public RegisterAdministrativeAssistant(UserViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            
            // Bindings
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

            _viewModel.OnValidationFailed += (s, msg) => MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _viewModel.OnErrorOccurred += (s, msg) => MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _viewModel.OnSucessMessage += (s, msg) => MessageBox.Show(msg, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRegister.Click += async (s, e) =>
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                        await _viewModel.AddUserCommand.ExecuteAsync(null);
                        //this.Close();
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
                string fileName = Path.GetFileName(filePath);

                string imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/Images/Assistant");
                string destPath = Path.Combine(imageFolder, fileName);

                Directory.CreateDirectory(imageFolder);
                try
                {
                    File.Copy(filePath, destPath, true); // true = file overwrite
                    MessageBox.Show("Arquivo salvo em: " + destPath);
                    _viewModel.PhotoPath = destPath;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message);
                }
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                ePUser.SetError(txtUserName, "Nome de usuário é obrigatório.");
                e.Cancel = true;
            }
            else if (txtUserName.Text.Length < 3)
            {
                ePUser.SetError(txtUserName, "O nome de usuário deve ter pelo menos 3 caracteres.");
                e.Cancel = true;
            }
            else
            {
                ePUser.SetError(txtUserName, "");
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                ePFullName.SetError(txtFullName, "Nome completo é obrigatório.");
                e.Cancel = true;
            }
            else if(txtFullName.Text.Length < 8)
            {
                ePFullName.SetError(txtFullName, "O nome completo de ter pelo menos 2 nomes (o primeiro nome e o sobrenome).");
            }
            else
            {
                ePFullName.SetError(txtFullName, "");
            }
        }
    }
}
