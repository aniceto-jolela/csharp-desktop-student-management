using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using cpqi.DAL;
using cpqi.Models;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace cpqi.ViewModels
{
    public partial class UserViewModel:ObservableObject
    {
        private readonly UserRepository _userRepository = new();
        private readonly RoleRepository _roleRepository = new();

        public ObservableCollection<User> Users { get; } = new();
        public ObservableCollection<Role> Roles { get; } = new();

        [ObservableProperty]
        private User? selectedUser;

        [ObservableProperty]
        //[Required(ErrorMessage = "O nome de usuário é obrigatório.")]
        //[MinLength(3, ErrorMessage = "O nome de usuário deve ter pelo menos 3 caracteres.")]
        private string userName = string.Empty;

        [ObservableProperty]
        //[Required(ErrorMessage = "O nome completo é obrigatório.")]
        private string fullName = string.Empty;

        [ObservableProperty]
        private string sex = "MASCULINO";

        [ObservableProperty]
        private string? email = string.Empty;

        [ObservableProperty]
        private string? phone = string.Empty;

        [ObservableProperty]
        private string password = string.Empty;

        [ObservableProperty]
        private string photoPath = string.Empty;

        [ObservableProperty]
        private DateTime dateOfBirth = DateTime.Today;

        [ObservableProperty]
        private bool isStaff;

        [ObservableProperty]
        private bool isActive = true;

        [ObservableProperty]
        private bool isSuperUser;

        [ObservableProperty]
        private string fileBiPath = string.Empty;

        [ObservableProperty]
        private DateTime issuedOn = DateTime.Today;

        [ObservableProperty]
        private DateTime validUntil = DateTime.Today;

        [ObservableProperty]
        private string? fileCvPath;

        [ObservableProperty]
        private int roleID = 1;

        [ObservableProperty]
        private string createdBy = Environment.UserName;

        [ObservableProperty]
        private string? updatedBy;

        public UserViewModel()
        {
            LoadUsers();
        }
        public void LoadUsers()
        {
            Users.Clear();
            foreach (var user in _userRepository.GetAllUsers())
                Users.Add(user);

            Roles.Clear();
            foreach (var role in _roleRepository.GetAllRoles())
                Roles.Add(role);
        }


        [RelayCommand]
        private void AddUser()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(FullName) || string.IsNullOrWhiteSpace(Password))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    return;
                }
                var user = new User
                {
                    UserName = UserName,
                    FullName = FullName,
                    Sex = Sex, 
                    Email = Email,
                    Phone = Phone,
                    PasswordHash = _userRepository.HashPassword(Password),
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

                _userRepository.AddUser(user);
                LoadUsers();
                ClearFields();
                MessageBox.Show("Usuário cadastrado com sucesso!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
        [RelayCommand]
        private void UpdateUser()
        {
            if (SelectedUser == null) return;

            SelectedUser.UserName = UserName;
            SelectedUser.FullName = FullName;
            SelectedUser.Sex = Sex;
            SelectedUser.Email = Email;
            SelectedUser.Phone = Phone;
            SelectedUser.PasswordHash = _userRepository.HashPassword(Password);
            SelectedUser.PhotoPath = PhotoPath;
            SelectedUser.DateOfBirth = DateOfBirth;
            SelectedUser.IsStaff = IsStaff;
            SelectedUser.IsActive = IsActive;
            SelectedUser.IsSuperUser = IsSuperUser;
            SelectedUser.RoleID = RoleID;
            SelectedUser.UpdatedBy = UpdatedBy ?? Environment.UserName;
            SelectedUser.UpdatedAt = DateTime.Now;

            _userRepository.UpdateUser(SelectedUser);
            LoadUsers();
            ClearFields();
        }

        [RelayCommand]
        private void DeleteUser()
        {
            if (SelectedUser == null) return;

            _userRepository.DeleteUser(SelectedUser.UserID);
            LoadUsers();
            ClearFields();
        }
        private void ClearFields()
        {
            UserName = string.Empty;
            FullName = string.Empty;
            Sex = "MASCULINO";
            Email = string.Empty;
            Phone = string.Empty;
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
            //UpdatedBy = null;
            SelectedUser = null;

        }
        partial void OnSelectedUserChanged(User? value)
        {
            if (value != null)
            {
                UserName = value.UserName;
                FullName = value.FullName;
                Sex = value.Sex;
                Email = value.Email ?? string.Empty;
                Phone = value.Phone ?? string.Empty;
                Password = System.Text.Encoding.UTF8.GetString(value.PasswordHash);
                PhotoPath = value.PhotoPath ?? string.Empty;
                FileBiPath = value.FileBiPath ?? string.Empty;
                FileCvPath = value.FileCvPath ?? string.Empty;
                DateOfBirth = value.DateOfBirth;
                IssuedOn = value.IssuedOn;
                ValidUntil = value.ValidUntil;
                IsStaff = value.IsStaff;
                IsActive = value.IsActive;
                IsSuperUser = value.IsSuperUser;
                RoleID = value.RoleID ?? 1;
                //CreatedBy = value.CreatedBy;
                //UpdatedBy = value.UpdatedBy;
            }
            else
            {
                ClearFields();
            }
        }
    }
}
