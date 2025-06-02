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
using Krypton.Toolkit;

namespace cpqi.Views.Admin
{
    public partial class AdminProfile : Form
    {

        private readonly AuthenticatedUserViewModel _authUser;
        private readonly UserFormViewModel _viewModel;
        private readonly BindingSource _bindingSource = new();

        private const long MaxFileSize = 5 * 1024 * 1024; // 5 MB
        public AdminProfile(AuthenticatedUserViewModel authUser, UserFormViewModel viewModel)
        {
            InitializeComponent();
            _authUser = authUser;
            _viewModel = viewModel;

            InitializeBindings();
            LoadUserData();
        }
        private void InitializeBindings()
        {
            _bindingSource.DataSource = _viewModel;

            TxtUserName.DataBindings.Add("Text", _bindingSource, nameof(_viewModel.UserName), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtFullName.DataBindings.Add("Text", _bindingSource, nameof(_viewModel.FullName), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtEmail.DataBindings.Add("Text", _bindingSource, nameof(_viewModel.Email), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPhone.DataBindings.Add("Text", _bindingSource, nameof(_viewModel.Phone), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNBI.DataBindings.Add("Text", _bindingSource, nameof(_viewModel.Bi), true, DataSourceUpdateMode.OnPropertyChanged);
            CbSex.DataBindings.Add("SelectedItem", _bindingSource, nameof(_viewModel.Sex), true, DataSourceUpdateMode.OnPropertyChanged);

            DtpDateOfBirth.DataBindings.Add("Value", _bindingSource, nameof(_viewModel.DateOfBirth), true, DataSourceUpdateMode.OnPropertyChanged);
            DtpIssuedOn.DataBindings.Add("Value", _bindingSource, nameof(_viewModel.IssuedOn), true, DataSourceUpdateMode.OnPropertyChanged);
            DtpValidUntil.DataBindings.Add("Value", _bindingSource, nameof(_viewModel.ValidUntil), true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void LoadUserData()
        {
            _viewModel.UserName = _authUser.UserName;
            _viewModel.FullName = _authUser.FullName;
            _viewModel.Email = _authUser.Email;
            _viewModel.Sex = _authUser.Sex;
            _viewModel.Phone = _authUser.Phone;
            _viewModel.Bi = _authUser.Bi;
            _viewModel.DateOfBirth = _authUser.DateOfBirth;
            _viewModel.IssuedOn = _authUser.IssuedOn;
            _viewModel.ValidUntil = _authUser.ValidUntil;
            _viewModel.PhotoPath = _authUser.PhotoPath;

            // Label
            LblUser.Text = _viewModel.UserName;
            LblFullName.Text = _viewModel.FullName;
            LblEmail.Text = _viewModel.Email;
            LblPhone.Text = _viewModel.Phone;
            LblSex.Text = _viewModel.Sex;
            LblNBI.Text = _viewModel.Bi;
            LblRole.Text = _authUser.RoleName;
            LblBirthDay.Text = _viewModel.DateOfBirth.ToShortDateString();
            LblIssuedOn.Text = _viewModel.IssuedOn.ToShortDateString();
            LblValidUntil.Text = _viewModel.ValidUntil.ToShortDateString();
            LoadPhotoView.ProfilePhoto(_viewModel.PhotoPath, PbPhoto);

            _viewModel.SelectedUser = _authUser.LoggedUser;

            _viewModel.OnValidationFailed += (s, msg) => MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _viewModel.OnErrorOccurred += (s, msg) => MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _viewModel.OnSucessMessage += (s, msg) => MessageBox.Show(msg, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "FOTO DE PERFIL";
            if (UploadFile("Imagem (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png", @"localhost\\SQLEXPRESS\SharedAppFiles\Photos\Assistant", "foto", (path) => _viewModel.PhotoPath = path))
            {
                FileButtonColor.SuccessButton(btnPhoto);
            }
        }
        private void btnBI_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "BILHETE DE IDENTIDADE";
            if (UploadFile("Documento (*.pdf)|*.pdf", @"localhost\\SQLEXPRESS\SharedAppFiles\BIs\Assistant", "bi", (path) => _viewModel.FileBiPath = path))
            {
                FileButtonColor.SuccessButton(btnBI);
            }
        }
        private void btnCV_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "CURRICULUM VITAE";
            if (UploadFile("Documento (*.pdf)|*.pdf", @"localhost\\SQLEXPRESS\SharedAppFiles\CVs\Assistant", "cv", (path) => _viewModel.FileCvPath = path))
            {
                FileButtonColor.SuccessButton(btnCV);
            }
        }
        private bool UploadFile(string filter, string folderPath, string fileNamePrefix, Action<string> setFilePath)
        {
            openFileDialog.Filter = filter;
            openFileDialog.Title = "Selecionar arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                long fileSize = new FileInfo(filePath).Length;

                // Validate extension
                if (!filter.Contains(extension))
                {
                    MessageBox.Show("Formato de arquivo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // Validate file size (5 MB max)
                if (fileSize > MaxFileSize)
                {
                    MessageBox.Show("Arquivo muito grande. Tamanho máximo: 5 MB.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string fileName = $"{fileNamePrefix}_{TxtUserName.Text}_{DateTime.Now:yyyyMMddHHmmss}{extension}";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string destPath = Path.Combine(folderPath, fileName);
                try
                {
                    File.Copy(filePath, destPath, true); // true = overwrite
                    setFilePath(destPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message);
                    return false;
                }
            }
            return false;
        }

        private void CxbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CxbPassword.Checked == true)
            {
                TxtPassword.Enabled = true; // Show password
            }
            else
            {
                TxtPassword.Enabled = false; // Hide password
            }
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
             await HandleEditClickAsync();
        }
        private async Task HandleEditClickAsync()
        {
            if (!ValidateFormVisual()) return;

            if (_viewModel.SelectedUser == null)
            {
                MessageBox.Show("Usuário não está autenticado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProcessingButton.ToggleUI(false, BtnEdit, PbLoading);

            try
            {
                _viewModel.ApplyFormDataToSelectedUser();
                bool updated = await _viewModel.UpdateSelectedUser();
                if (updated)
                {
                    _authUser.UpdateLoggedUser(_viewModel.SelectedUser); // Update _authUser.LoggedUser with new data (sync)
                    LoadUserData(); // Reflects changes in the interface
                    ShowStatusMessage.ShowMessage(LblStatusMessage, "Perfil atualizado com sucesso!", StatusTimer);

                    FileButtonColor.ResetCustomButtonStyles(btnPhoto, btnBI, btnCV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                ProcessingButton.ToggleUI(true, BtnEdit, PbLoading);
            }
        }
        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            ShowStatusMessage.StatusTimerTick(LblStatusMessage, StatusTimer);
        }
        
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
            return true;
        }
       
        private bool ValidatePassword()
        {
            if (!CxbPassword.Checked)
                return true;

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
        private void PbBI_Click(object sender, EventArgs e)
        {
            LoadFileView.ProfileFile(_viewModel.FileBiPath, "Bilhete de Identidade");
        }

        private void PbCv_Click(object sender, EventArgs e)
        {
            LoadFileView.ProfileFile(_viewModel.FileCvPath, "Curriculum Vitae");
        }
    }
}
