﻿using CommunityToolkit.Mvvm.ComponentModel;
using cpqi.Data.Repositories;
using cpqi.Models;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

public partial class UserFormViewModel : ObservableObject
{
    private readonly UserRepository _userRepository;
    public ObservableCollection<User> Users { get; } = new();

    public event EventHandler<string>? OnValidationFailed;
    public event EventHandler<string>? OnErrorOccurred;
    public event EventHandler<string>? OnSucessMessage;

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
    [ObservableProperty] private string roleName = string.Empty;
    [ObservableProperty] private string createdBy = Environment.UserName;
    [ObservableProperty] private string? updatedBy;

    public UserFormViewModel(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task LoadUsers()
    {
        var users = await _userRepository.GetAllUsersAsync();
        Users.Clear();
        foreach (var user in users)
            Users.Add(user);
    }

    #region Database Operations
    public async Task AddUser()
    {
        try
        {
            if (!await ValidateFieldsAsync(isUpdate: false))
            {
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
            if (!await ValidateFieldsAsync(isUpdate: true))
                return;

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
    // copy login data
    public void LoadUserData(User user)
    {
        UserName = user.UserName;
        FullName = user.FullName;
        Sex = user.Sex;
        Email = user.Email ?? string.Empty;
        Phone = user.Phone ?? string.Empty;
        Bi = user.Bi;
        PhotoPath = user.PhotoPath ?? string.Empty;
        DateOfBirth = user.DateOfBirth;
        IsStaff = user.IsStaff;
        IsActive = user.IsActive;
        IsSuperUser = user.IsSuperUser;
        FileBiPath = user.FileBiPath ?? string.Empty;
        FileCvPath = user.FileCvPath ?? string.Empty;
        IssuedOn = user.IssuedOn;
        ValidUntil = user.ValidUntil;
        RoleID = user.RoleID;
        RoleName = user.RoleName;
        CreatedBy = user.CreatedBy;
        UpdatedBy = user.UpdatedBy;
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
    #endregion

    private byte[] HashPassword(string password, out byte[] salt)
    {
        salt = new byte[16];
        RandomNumberGenerator.Fill(salt);
        using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256);
        return pbkdf2.GetBytes(32);
    }

    #region Validation
    public async Task<bool> ValidateFieldsAsync(bool isUpdate = false)
    {
        if (string.IsNullOrWhiteSpace(UserName))
        {
            OnValidationFailed?.Invoke(this, "Nome de usuário é obrigatório.");
            return false;
        }
        if (UserName.Length < 3)
        {
            OnValidationFailed?.Invoke(this, "O nome de usuário deve ter pelo menos 3 caracteres.");
            return false;
        }
        if (UserName.Contains(' '))
        {
            OnValidationFailed?.Invoke(this, "O nome de usuário não deve conter espaços.");
            return false;
        }
        if (!UserName.Equals(UserName.ToLower()))
        {
            OnValidationFailed?.Invoke(this, "O nome de usuário deve estar em letras minúsculas.");
            return false;
        }
        // unique UserName
        var existingUserByUserName = await _userRepository.GetUserByUsername(UserName);
        if (existingUserByUserName != null && (!isUpdate || existingUserByUserName.UserID != SelectedUser?.UserID))
        {
            OnValidationFailed?.Invoke(this, "Nome de usuário já está em uso.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(FullName))
        {
            OnValidationFailed?.Invoke(this, "Nome completo é obrigatório.");
            return false;
        }
        var nomes = FullName.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (nomes.Length < 2)
        {
            OnValidationFailed?.Invoke(this, "O nome completo deve conter pelo menos primeiro nome e sobrenome.");
            return false;
        }
        // unique FullName
        var existingUsers = await _userRepository.GetAllUsersAsync();
        bool fullNameExists = existingUsers.Any(u => u.FullName.Equals(FullName, StringComparison.OrdinalIgnoreCase)
            && (!isUpdate || u.UserID != SelectedUser?.UserID));
        if (fullNameExists)
        {
            OnValidationFailed?.Invoke(this, "Nome completo já está cadastrado.");
            return false;
        }
        if (string.IsNullOrWhiteSpace(Bi))
        {
            OnValidationFailed?.Invoke(this, "Bilhete de identidade é obrigatório.");
            return false;
        }
        // Regex
        var biRegex = new Regex(@"^[A-Z0-9]{6,15}$", RegexOptions.IgnoreCase);
        if (!biRegex.IsMatch(Bi))
        {
            OnValidationFailed?.Invoke(this, "Bilhete de identidade inválido.");
            return false;
        }
        bool biExists = existingUsers.Any(u => u.Bi.Equals(Bi, StringComparison.OrdinalIgnoreCase)
            && (!isUpdate || u.UserID != SelectedUser?.UserID));
        if (biExists)
        {
            OnValidationFailed?.Invoke(this, "Bilhete de identidade já está cadastrado.");
            return false;
        }

        if (!string.IsNullOrWhiteSpace(Email))
        {
            var emailValidator = new EmailAddressAttribute();
            if (!emailValidator.IsValid(Email))
            {
                OnValidationFailed?.Invoke(this, "Email inválido.");
                return false;
            }
        }

        if (!string.IsNullOrWhiteSpace(Phone))
        {
            var phoneRegex = new Regex(@"^[\d\s\+\-\(\)]{7,15}$");
            if (!phoneRegex.IsMatch(Phone))
            {
                OnValidationFailed?.Invoke(this, "Telefone inválido.");
                return false;
            }
        }

        if (!isUpdate || !string.IsNullOrWhiteSpace(Password))
        {
            if (string.IsNullOrWhiteSpace(Password))
            {
                OnValidationFailed?.Invoke(this, "Senha é obrigatória.");
                return false;
            }
            if (Password.Length < 8)
            {
                OnValidationFailed?.Invoke(this, "A senha deve ter pelo menos 8 caracteres.");
                return false;
            }
            // Regex
            if (!Regex.IsMatch(Password, @"[A-Z]"))
            {
                OnValidationFailed?.Invoke(this, "A senha deve conter pelo menos uma letra maiúscula.");
                return false;
            }
            if (!Regex.IsMatch(Password, @"[a-z]"))
            {
                OnValidationFailed?.Invoke(this, "A senha deve conter pelo menos uma letra minúscula.");
                return false;
            }
            if (!Regex.IsMatch(Password, @"\d"))
            {
                OnValidationFailed?.Invoke(this, "A senha deve conter pelo menos um número.");
                return false;
            }
            if (!Regex.IsMatch(Password, @"[\W_]"))
            {
                OnValidationFailed?.Invoke(this, "A senha deve conter pelo menos um símbolo.");
                return false;
            }
        }

        return true;
    }
    #endregion
}
