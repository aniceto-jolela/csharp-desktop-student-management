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
using cpqi.Helpers;
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

        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Imagem (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Selecionar uma foto";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
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
                    FileButtonColor.SuccessButton(BtnPhoto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message);
                }
            }
        }

        private void BtnBI_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Documento (*.pdf)|*.pdf";
            openFileDialog.Title = "Selecionar BI";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
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
                    FileButtonColor.SuccessButton(BtnPhoto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message);
                }
            }
        }

        private void BtnCV_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Documento (*.pdf)|*.pdf";
            openFileDialog.Title = "Selecionar CV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
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
                    FileButtonColor.SuccessButton(BtnPhoto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message);
                }
            }
        }
     
        #endregion

        #region Validation
        private bool ValidateFormVisual()
        {
            ErrorProvider.Clear();
            bool isValid = true;

            isValid &= ValidateUserName();
            isValid &= ValidateView.ValidateFullName(TxtFullName, ErrorProvider);
            isValid &= ValidateView.ValidateBI(TxtNBI, ErrorProvider);
            isValid &= ValidateView.ValidateBIssueDates(DtpIssuedOn, DtpValidUntil, ErrorProvider);
            isValid &= ValidateEmail();
            isValid &= ValidateView.ValidatePhone(TxtPhone, ErrorProvider);
            isValid &= ValidatePassword();

            return isValid;
        }
        private bool ValidateUserName()
        {
            var text = TxtUserName.Text;
            if (string.IsNullOrWhiteSpace(text))
                return ErrorProviderView.SetError(TxtUserName, "Nome de usuário é obrigatório.", ErrorProvider);

            if (text.Length < 3)
                return ErrorProviderView.SetError(TxtUserName, "Mínimo de 3 caracteres.", ErrorProvider);

            if (text.Contains(" "))
                return ErrorProviderView.SetError(TxtUserName, "Não deve conter espaços.", ErrorProvider);

            if (!RegexRules.UserName.IsMatch(text))
                return ErrorProviderView.SetError(TxtUserName, "Use apenas letras, números e underline (_).", ErrorProvider);

            if (!text.Equals(text.ToLower()))
                return ErrorProviderView.SetError(TxtUserName, "O nome de usuário deve estar em letras minúsculas.", ErrorProvider);

            return true;
        }

        private bool ValidateEmail()
        {
            var email = TxtEmail.Text;
            if (!string.IsNullOrWhiteSpace(email))
            {
                var emailAttr = new EmailAddressAttribute();
                if (!emailAttr.IsValid(email))
                    return ErrorProviderView.SetError(TxtEmail, "Email inválido.", ErrorProvider);
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                return ErrorProviderView.SetError(TxtEmail, "Email de usuário é obrigatório.", ErrorProvider);
            }
            return true;
        }

        private bool ValidatePassword()
        {
            var password = TxtPassword.Text;
            if (string.IsNullOrWhiteSpace(password))
                return ErrorProviderView.SetError(TxtPassword, "Senha é obrigatória.", ErrorProvider);

            if (password.Length < 8)
                return ErrorProviderView.SetError(TxtPassword, "Mínimo 8 caracteres.", ErrorProvider);

            if (!Regex.IsMatch(password, @"[A-Z]"))
                return ErrorProviderView.SetError(TxtPassword, "Deve conter letra MAIÚSCULA.", ErrorProvider);

            if (!Regex.IsMatch(password, @"[a-z]"))
                return ErrorProviderView.SetError(TxtPassword, "Deve conter letra minúscula.", ErrorProvider);

            if (!Regex.IsMatch(password, @"\d"))
                return ErrorProviderView.SetError(TxtPassword, "Deve conter número.", ErrorProvider);

            if (!Regex.IsMatch(password, @"[\W_]"))
                return ErrorProviderView.SetError(TxtPassword, "Deve conter símbolo.", ErrorProvider);

            return true;
        }

        #endregion
        private async Task HandleRegisterAsync()
        {
            if (!ValidateFormVisual()) return;

            ProcessingButton.ToggleUI(false, BtnRegister, PbLoading);
            try
            {
                _viewModel.RoleID = 3; // Set default role ID for Administrative Assistant
                _viewModel.IsStaff = false; // Set default IsActive ID for Administrative Assistant
                bool created = await _viewModel.AddUser();
                if (created)
                {
                    ShowStatusMessage.ShowMessage(LblStatusMessage, "Usuário cadastrado com sucesso!", StatusTimer);
                    FileButtonColor.ResetCustomButtonStyles(BtnPhoto, BtnBI, BtnCV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                ProcessingButton.ToggleUI(true, BtnRegister, PbLoading);
            }
        }
        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            await HandleRegisterAsync();
        }

        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            ShowStatusMessage.StatusTimerTick(LblStatusMessage, StatusTimer);
        }

       
    }
}
