using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using cpqi.Models;
using cpqi.Data.Repositories;

namespace cpqi.ViewModels
{
    public partial class UserViewModel : ObservableObject
    {
        private readonly UserRepository _userRepository;
        public ObservableCollection<User> Users { get; } = new();

        public User? LoggedUser { get; private set; }
        public bool IsAuthenticated => LoggedUser != null;

        // Eventos para feedback no Form
        public event EventHandler<string>? OnValidationFailed;
        public event EventHandler<string>? OnErrorOccurred;
        public event EventHandler<string>? OnSucessMessage;

        #region Form properties
        [ObservableProperty] private User? selectedUser;
        [ObservableProperty] private string userName = string.Empty;
        [ObservableProperty] private string fullName = string.Empty;
        [ObservableProperty] private string sex = "MASCULINO";
        [ObservableProperty] private string? email = string.Empty;
        [ObservableProperty] private string? phone = string.Empty;
        [ObservableProperty] private string bi = string.Empty;
        [ObservableProperty] private string password = string.Empty;
        [ObservableProperty] private string photoPath = string.Empty;
        [ObservableProperty] private DateTime dateOfBirth = DateTime.Today;
        [ObservableProperty] private bool isStaff;
        [ObservableProperty] private bool isActive = true;
        [ObservableProperty] private bool isSuperUser;
        [ObservableProperty] private string fileBiPath = string.Empty;
        [ObservableProperty] private DateTime issuedOn = DateTime.Today;
        [ObservableProperty] private DateTime validUntil = DateTime.Today;
        [ObservableProperty] private string? fileCvPath;
        [ObservableProperty] private int roleID = 1;
        [ObservableProperty] private string createdBy = Environment.UserName;
        [ObservableProperty] private string? updatedBy;
        #endregion

        public UserViewModel(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #region Login
        public bool Login(string username, string password)
        {
            var user = _userRepository.GetUserByUsername(username);
            if (user == null || !VerifyPassword(password, user.Salt, user.PasswordHash)) return false;

            LoggedUser = user;
            return true;
        }

        public void Logout()
        {
            LoggedUser = null!;
        }
        #endregion

        #region Public methode
        public async Task LoadUsers()
        {
            var users = await _userRepository.GetAllUsersAsync();
            Users.Clear();
            foreach (var user in users)
                Users.Add(user);
        }

        public async Task AddUser()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(FullName) || string.IsNullOrWhiteSpace(Password))
                {
                    OnValidationFailed?.Invoke(this, "Preencha todos os campos obrigatórios!");
                    return;
                }

                var passwordHash = HashPassword(Password, out var salt);

                var user = new User
                {
                    UserName = UserName,
                    FullName = FullName,
                    Sex = Sex,
                    Email = Email,
                    Phone = Phone,
                    Bi = Bi,
                    PasswordHash = passwordHash,
                    Salt = salt,
                    PhotoPath = PhotoPath,
                    DateOfBirth = DateOfBirth,
                    IsStaff = IsStaff,
                    IsActive = IsActive,
                    IsSuperUser = IsSuperUser,
                    DateJoined = DateTime.Now,
                    FileBiPath = FileBiPath,
                    IssuedOn = IssuedOn,
                    ValidUntil = ValidUntil,
                    FileCvPath = FileCvPath,
                    RoleID = RoleID,
                    CreatedBy = CreatedBy,
                    CreatedAt = DateTime.Now
                };

                await _userRepository.AddUserAsync(user);
                await LoadUsers();
                ClearFields();
                OnSucessMessage?.Invoke(this, "Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                OnErrorOccurred?.Invoke(this, $"Erro ao cadastrar usuário: {ex.Message}");
            }
        }

        public async Task UpdateSelectedUser()
        {
            if (SelectedUser == null) return;

            try
            {
                SelectedUser.UserName = UserName;
                SelectedUser.FullName = FullName;
                SelectedUser.Sex = Sex;
                SelectedUser.Email = Email;
                SelectedUser.Phone = Phone;
                SelectedUser.Bi = Bi;

                if (!string.IsNullOrWhiteSpace(Password))
                {
                    SelectedUser.PasswordHash = HashPassword(Password, out var salt);
                    SelectedUser.Salt = salt;
                }

                SelectedUser.PhotoPath = PhotoPath;
                SelectedUser.DateOfBirth = DateOfBirth;
                SelectedUser.IsStaff = IsStaff;
                SelectedUser.IsActive = IsActive;
                SelectedUser.IsSuperUser = IsSuperUser;
                SelectedUser.RoleID = RoleID;
                SelectedUser.UpdatedBy = UpdatedBy ?? Environment.UserName;
                SelectedUser.UpdatedAt = DateTime.Now;

                await _userRepository.UpdateUserAsync(SelectedUser);
                await LoadUsers();
                ClearFields();
                OnSucessMessage?.Invoke(this, "Usuário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                OnErrorOccurred?.Invoke(this, $"Erro ao atualizar: {ex.Message}");
            }
        }

        public async Task DeleteSelectedUser()
        {
            if (SelectedUser == null) return;

            try
            {
                await _userRepository.DeleteUserAsync(SelectedUser.UserID);
                await LoadUsers();
                ClearFields();
                OnSucessMessage?.Invoke(this, "Usuário excluído com sucesso!");
            }
            catch (Exception ex)
            {
                OnErrorOccurred?.Invoke(this, $"Erro ao excluir: {ex.Message}");
            }
        }

        // Used by DataGridView directly
        public async Task UpdateUserFromGrid(User user) => await _userRepository.UpdateUserAsync(user);
        public async Task DeleteUserFromGrid(int userId)
        {
            await _userRepository.DeleteUserAsync(userId);
            await LoadUsers();
        }
        #endregion

        #region Support
        private void ClearFields()
        {
            UserName = string.Empty;
            FullName = string.Empty;
            Sex = "MASCULINO";
            Email = string.Empty;
            Phone = string.Empty;
            Bi = string.Empty;
            Password = string.Empty;
            PhotoPath = string.Empty;
            FileBiPath = string.Empty;
            FileCvPath = string.Empty;
            DateOfBirth = DateTime.Today;
            IssuedOn = DateTime.Today;
            ValidUntil = DateTime.Today;
            IsStaff = false;
            IsActive = true;
            IsSuperUser = false;
            RoleID = 1;
            SelectedUser = null;
        }

        partial void OnSelectedUserChanged(User? value)
        {
            if (value == null)
            {
                ClearFields();
                return;
            }

            UserName = value.UserName;
            FullName = value.FullName;
            Sex = value.Sex;
            Email = value.Email ?? string.Empty;
            Phone = value.Phone ?? string.Empty;
            Bi = value.Bi;
            Password = string.Empty;
            PhotoPath = value.PhotoPath ?? string.Empty;
            FileBiPath = value.FileBiPath ?? string.Empty;
            FileCvPath = value.FileCvPath ?? string.Empty;
            DateOfBirth = value.DateOfBirth;
            IssuedOn = value.IssuedOn;
            ValidUntil = value.ValidUntil;
            IsStaff = value.IsStaff;
            IsActive = value.IsActive;
            IsSuperUser = value.IsSuperUser;
            RoleID = value.RoleID;
            CreatedBy = value.CreatedBy;
            UpdatedBy = value.UpdatedBy;
        }

        private byte[] HashPassword(string password, out byte[] salt)
        {
            salt = new byte[16];
            RandomNumberGenerator.Fill(salt);
            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256);
            return pbkdf2.GetBytes(32);
        }

        private bool VerifyPassword(string password, byte[] salt, byte[] storedHash)
        {
            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256);
            return pbkdf2.GetBytes(32).SequenceEqual(storedHash);
        }
        #endregion
    }
}
