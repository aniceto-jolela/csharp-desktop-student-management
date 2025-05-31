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
            LoadPhoto.ProfilePhoto(_viewModel.PhotoPath, PbPhoto);

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
                btnPhoto.PaletteMode = PaletteMode.Office2010Black; // Indicate success
            }
        }
        private void btnBI_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "BILHETE DE IDENTIDADE";
            if (UploadFile("Documento (*.pdf)|*.pdf", @"localhost\\SQLEXPRESS\SharedAppFiles\BIs\Assistant", "bi", (path) => _viewModel.FileBiPath = path))
            {
                btnBI.PaletteMode = PaletteMode.Office2010Black; // Indicate success
            }
        }
        private void btnCV_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "CURRICULUM VITAE";
            if (UploadFile("Documento (*.pdf)|*.pdf", @"localhost\\SQLEXPRESS\SharedAppFiles\CVs\Assistant", "cv", (path) => _viewModel.FileCvPath = path))
            {
                btnCV.PaletteMode = PaletteMode.Office2010Black; // Indicate success
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
            if (!ValidateFormVisual()) return;

            if (_viewModel.SelectedUser == null)
            {
                MessageBox.Show("Usuário não está autenticado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BtnEdit.Enabled = false;
            PbLoading.Visible = true;

            try
            {
                _viewModel.ApplyFormDataToSelectedUser();
                bool updated = await _viewModel.UpdateSelectedUser();
                if (updated)
                {
                    _authUser.UpdateLoggedUser(_viewModel.SelectedUser); // Update _authUser.LoggedUser with new data (sync)
                    LoadUserData(); // Reflects changes in the interface
                    ShowStatusMessage("Perfil atualizado com sucesso!");

                    btnPhoto.PaletteMode = PaletteMode.Global;
                    btnCV.PaletteMode = PaletteMode.Global;
                    btnBI.PaletteMode = PaletteMode.Global;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                BtnEdit.Enabled = true;
                PbLoading.Visible = false;
            }
        }
        private void ShowStatusMessage(string message)
        {
            LblStatusMessage.Text = message;
            LblStatusMessage.Visible = true;
            LblStatusMessage.ForeColor = Color.Green;
            StatusTimer.Start();
        }
        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            StatusTimer.Stop();
            LblStatusMessage.Visible = false;
        }
        private bool ValidateFormVisual()
        {
            bool isValid = true;
            ErrorProvider.Clear();

            // User name
            if (string.IsNullOrWhiteSpace(TxtUserName.Text))
            {
                ErrorProvider.SetError(TxtUserName, "Nome de usuário é obrigatório.");
                isValid = false;
            }
            else if (TxtUserName.Text.Length < 3)
            {
                ErrorProvider.SetError(TxtUserName, "Mínimo de 3 caracteres.");
                isValid = false;
            }
            else if (TxtUserName.Text.Contains(" "))
            {
                ErrorProvider.SetError(TxtUserName, "Não deve conter espaços.");
                isValid = false;
            }

            // Full Name
            if (string.IsNullOrWhiteSpace(TxtFullName.Text))
            {
                ErrorProvider.SetError(TxtFullName, "Nome completo é obrigatório.");
                isValid = false;
            }
            else if (TxtFullName.Text.Trim().Split(' ').Length < 2)
            {
                ErrorProvider.SetError(TxtFullName, "Informe pelo menos nome e sobrenome.");
                isValid = false;
            }

            // BI
            if (string.IsNullOrWhiteSpace(TxtNBI.Text))
            {
                ErrorProvider.SetError(TxtNBI, "BI é obrigatório.");
                isValid = false;
            }
            else if (!Regex.IsMatch(TxtNBI.Text.Trim(), @"^[A-Z0-9]{6,15}$", RegexOptions.IgnoreCase))
            {
                ErrorProvider.SetError(TxtNBI, "Formato de BI inválido.");
                isValid = false;
            }

            // Data BI
            if (DtpIssuedOn.Value > DateTime.Today)
            {
                ErrorProvider.SetError(DtpIssuedOn, "Data de emissão não pode ser futura.");
                isValid = false;
            }

            if (DtpValidUntil.Value <= DtpIssuedOn.Value)
            {
                ErrorProvider.SetError(DtpValidUntil, "Validade deve ser posterior à emissão.");
                isValid = false;
            }

            // Email
            if (!string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                var emailAttr = new EmailAddressAttribute();
                if (!emailAttr.IsValid(TxtEmail.Text))
                {
                    ErrorProvider.SetError(TxtEmail, "Email inválido.");
                    isValid = false;
                }
            }

            // Phone
            if (!string.IsNullOrWhiteSpace(TxtPhone.Text))
            {
                if (!Regex.IsMatch(TxtPhone.Text, @"^[\d\s\+\-\(\)]{7,15}$"))
                {
                    ErrorProvider.SetError(TxtPhone, "Telefone inválido.");
                    isValid = false;
                }
            }

            // Password
            if (CxbPassword.Checked)
            {
                string password = TxtPassword.Text;

                if (string.IsNullOrWhiteSpace(password))
                {
                    ErrorProvider.SetError(TxtPassword, "Senha é obrigatória.");
                    isValid = false;
                }
                else
                {
                    if (password.Length < 8)
                    {
                        ErrorProvider.SetError(TxtPassword, "Mínimo 8 caracteres.");
                        isValid = false;
                    }
                    else if (!Regex.IsMatch(password, @"[A-Z]"))
                    {
                        ErrorProvider.SetError(TxtPassword, "Deve conter letra MAIÚSCULA.");
                        isValid = false;
                    }
                    else if (!Regex.IsMatch(password, @"[a-z]"))
                    {
                        ErrorProvider.SetError(TxtPassword, "Deve conter letra minúscula.");
                        isValid = false;
                    }
                    else if (!Regex.IsMatch(password, @"\d"))
                    {
                        ErrorProvider.SetError(TxtPassword, "Deve conter número.");
                        isValid = false;
                    }
                    else if (!Regex.IsMatch(password, @"[\W_]"))
                    {
                        ErrorProvider.SetError(TxtPassword, "Deve conter símbolo.");
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

        private void PbBI_Click(object sender, EventArgs e)
        {
            if(_viewModel.FileBiPath != null && File.Exists(_viewModel.FileBiPath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = _viewModel.FileBiPath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("BI não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PbCv_Click(object sender, EventArgs e)
        {
            if (_viewModel.FileCvPath != null && File.Exists(_viewModel.FileCvPath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = _viewModel.FileCvPath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("CV não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
