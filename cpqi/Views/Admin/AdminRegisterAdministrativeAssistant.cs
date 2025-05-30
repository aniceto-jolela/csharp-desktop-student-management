using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using cpqi.ViewModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace cpqi.Views.Admin
{
    public partial class AdminRegisterAdministrativeAssistant : Form
    {
        private readonly UserFormViewModel _viewModel;
        private const long MaxFileSize = 5 * 1024 * 1024; // 5 MB
        private readonly string[] AllowedImageExtensions = { ".jpg", ".jpeg", ".png" };
        private readonly string[] AllowedDocumentExtensions = { ".pdf" };
        public AdminRegisterAdministrativeAssistant(UserFormViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            CbSex.SelectedIndex = 0;

            // Bindings
            TxtUserName.DataBindings.Add(nameof(TxtUserName.Text), _viewModel, nameof(_viewModel.UserName), false, DataSourceUpdateMode.OnPropertyChanged);
            TxtFullName.DataBindings.Add(nameof(TxtFullName.Text), _viewModel, nameof(_viewModel.FullName), false, DataSourceUpdateMode.OnPropertyChanged);
            TxtEmail.DataBindings.Add(nameof(TxtEmail.Text), _viewModel, nameof(_viewModel.Email), false, DataSourceUpdateMode.OnPropertyChanged);
            CbSex.DataBindings.Add(nameof(CbSex.SelectedItem), _viewModel, nameof(_viewModel.Sex), false, DataSourceUpdateMode.OnPropertyChanged);
            TxtPhone.DataBindings.Add(nameof(TxtPhone.Text), _viewModel, nameof(_viewModel.Phone), false, DataSourceUpdateMode.OnPropertyChanged);
            TxtPassword.DataBindings.Add(nameof(TxtPassword.Text), _viewModel, nameof(_viewModel.Password), false, DataSourceUpdateMode.OnPropertyChanged);
            TxtNBI.DataBindings.Add(nameof(TxtNBI.Text), _viewModel, nameof(_viewModel.Bi), false, DataSourceUpdateMode.OnPropertyChanged);

            DtpDateOfBirth.DataBindings.Add(nameof(DtpDateOfBirth.Value), _viewModel, nameof(_viewModel.DateOfBirth), false, DataSourceUpdateMode.OnPropertyChanged);
            DtpIssuedOn.DataBindings.Add(nameof(DtpIssuedOn.Value), _viewModel, nameof(_viewModel.IssuedOn), false, DataSourceUpdateMode.OnPropertyChanged);
            DtpValidUntil.DataBindings.Add(nameof(DtpValidUntil.Value), _viewModel, nameof(_viewModel.ValidUntil), false, DataSourceUpdateMode.OnPropertyChanged);

            _viewModel.OnValidationFailed += (s, msg) => MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _viewModel.OnErrorOccurred += (s, msg) => MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _viewModel.OnSucessMessage += (s, msg) => MessageBox.Show(msg, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region File Uploads
        private void btnCV_Click(object sender, EventArgs e)
        {
            openFileDialog3.Filter = "Documento (*.pdf)|*.pdf";
            openFileDialog3.Title = "Selecionar CV";

            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog3.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                long fileSize = new FileInfo(filePath).Length;

                // Validate extension
                if (!AllowedDocumentExtensions.Contains(extension))
                {
                    MessageBox.Show("Formato de arquivo inválido. Use PDF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Validate file size (5 MB max)
                if (fileSize > MaxFileSize) // 5 MB
                {
                    MessageBox.Show("O arquivo é muito grande. O tamanho máximo permitido é de 5 MB.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fileName = $"cv_{TxtUserName.Text}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
                string sharedFolder = @"localhost\\SQLEXPRESS\SharedAppFiles\CVs\Assistant";
                if (!Directory.Exists(sharedFolder))
                {
                    Directory.CreateDirectory(sharedFolder);
                }
                string destPath = Path.Combine(sharedFolder, fileName);
                try
                {
                    File.Copy(filePath, destPath, true); // true = file overwrite
                    _viewModel.FileCvPath = destPath;
                    MessageBox.Show("CV salvo em: " + destPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message);
                }
            }
        }
        private void btnBI_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Documento (*.pdf)|*.pdf";
            openFileDialog2.Title = "Selecionar BI";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog2.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                long fileSize = new FileInfo(filePath).Length;

                // Validate extension
                if (!AllowedDocumentExtensions.Contains(extension))
                {
                    MessageBox.Show("Formato de arquivo inválido. Use PDF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Validate file size (5 MB max)
                if (fileSize > MaxFileSize) // 5 MB
                {
                    MessageBox.Show("O arquivo é muito grande. O tamanho máximo permitido é de 5 MB.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fileName = $"bi_{TxtUserName.Text}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
                string sharedFolder = @"localhost\\SQLEXPRESS\SharedAppFiles\BIs\Assistant";
                if (!Directory.Exists(sharedFolder))
                {
                    Directory.CreateDirectory(sharedFolder);
                }
                string destPath = Path.Combine(sharedFolder, fileName);
                try
                {
                    File.Copy(filePath, destPath, true); // true = file overwrite
                    _viewModel.FileBiPath = destPath;
                    MessageBox.Show("BI salvo em: " + destPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message);
                }
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagem (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Selecionar uma foto";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                long fileSize = new FileInfo(filePath).Length;

                // Validate extension
                if (!AllowedImageExtensions.Contains(extension))
                {
                    MessageBox.Show("Formato de arquivo inválido. Use JPG, JPEG ou PNG.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Validate file size (5 MB max)
                if (fileSize > MaxFileSize) // 5 MB
                {
                    
                    MessageBox.Show("O arquivo é muito grande. O tamanho máximo permitido é de 5 MB.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fileName = $"photo_{TxtUserName.Text}_{DateTime.Now:yyyyMMddHHmmss}{Path.GetExtension(filePath)}";
                string sharedFolder = @"localhost\\SQLEXPRESS\SharedAppFiles\Photos\Assistant";
                if (!Directory.Exists(sharedFolder))
                {
                    Directory.CreateDirectory(sharedFolder);
                }
                string destPath = Path.Combine(sharedFolder, fileName);

                try
                {
                    File.Copy(filePath, destPath, true); // true = file overwrite
                    _viewModel.PhotoPath = destPath;
                    MessageBox.Show("Foto salva em: " + destPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message);
                }
            }
        }
        #endregion

        #region Validation
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUserName.Text))
            {
                EpUser.SetError(TxtUserName, "Nome de usuário é obrigatório.");
                e.Cancel = true;
            }
            else if (TxtUserName.Text.Length < 3)
            {
                EpUser.SetError(TxtUserName, "O nome de usuário deve ter pelo menos 3 caracteres.");
                e.Cancel = true;
            }
            else if (TxtUserName.Text.Contains(' '))
            {
                EpUser.SetError(TxtUserName, "Não deve ter espaço no nome do usuário.");
                e.Cancel = true;
            }
            else if (!TxtUserName.Text.Equals(TxtUserName.Text.ToLower()))
            {
                EpUser.SetError(TxtUserName, "O nome de usuário deve ser escrito com letras minúsculas.");
                e.Cancel = true;
            }
            else
            {
                EpUser.SetError(TxtUserName, "");
                e.Cancel = false;
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            string fullName = TxtFullName.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                EpFullName.SetError(TxtFullName, "Nome completo é obrigatório.");
                e.Cancel = true;
            }
            else
            {
                var nomes = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (nomes.Length < 2)
                {
                    EpFullName.SetError(TxtFullName, "O nome completo deve ter pelo menos 2 nomes (primeiro nome e sobrenome).");
                    e.Cancel = true;
                }
                else
                {
                    EpFullName.SetError(TxtFullName, "");
                    e.Cancel = false;
                }
            }
        }
        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                var emailValidator = new EmailAddressAttribute();
                if (!emailValidator.IsValid(TxtEmail.Text))
                {
                    EpEmail.SetError(TxtEmail, "Email inválido.");
                    e.Cancel = true;
                }
                else
                {
                    EpEmail.SetError(TxtEmail, "");
                    e.Cancel = false;
                }
            }
        }
        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtPhone.Text))
            {
                var phoneRegex = new Regex(@"^[\d\s\+\-\(\)]{7,15}$");
                if (!phoneRegex.IsMatch(TxtPhone.Text))
                {
                    EpPhone.SetError(TxtPhone, "Telefone inválido.");
                    e.Cancel = true;
                }
                else
                {
                    EpPhone.SetError(TxtPhone, "");
                    e.Cancel = false;
                }
            }
        }

        private void TxtNBI_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNBI.Text))
            {
                EpNBI.SetError(TxtNBI, "Bilhete de identidade é obrigatório.");
                e.Cancel = true;
            }
            // Regex
            var biRegex = new Regex(@"^[A-Z0-9]{6,15}$", RegexOptions.IgnoreCase);
            if (!biRegex.IsMatch(TxtNBI.Text))
            {
                EpNBI.SetError(TxtNBI, "Bilhete de identidade inválido.");
                e.Cancel = true;
            }
            else
            {
                EpNBI.SetError(TxtNBI, "");
                e.Cancel = false;
            }
        }
        #endregion
        private async void Register()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _viewModel.RoleID = 3; // Set default role ID for Administrative Assistant
                _viewModel.IsStaff = true; // Set default IsStaff ID for Administrative Assistant
                await _viewModel.AddUser();
            }
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register();
        }

        
    }
}
