using CommunityToolkit.Mvvm.ComponentModel;
using cpqi.Data.Repositories;
using cpqi.Models;
using System.Security.Cryptography;

public class AuthenticatedUserViewModel : ObservableObject
{
    private readonly UserRepository _userRepository;

    public User? LoggedUser { get; private set; }

    public AuthenticatedUserViewModel(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<bool> LoginAsync(string username, string password)
    {
        var user = await _userRepository.GetUserByUsername(username);
        if (user == null || !VerifyPassword(password, user.Salt, user.PasswordHash))
            return false;

        LoggedUser = user;
        return true;
    }

    public void Logout()
    {
        LoggedUser = null;
    }
    public void UpdateLoggedUser(User updatedUser)
    {
        if (updatedUser == null) return;

        LoggedUser = updatedUser;
        // Notify the UI that properties have changed
        RefreshProperties();
    }
    private bool VerifyPassword(string password, byte[] salt, byte[] storedHash)
    {
        using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256);
        return pbkdf2.GetBytes(32).SequenceEqual(storedHash);
    }
    public void RefreshProperties()
    {
        OnPropertyChanged(nameof(UserName));
        OnPropertyChanged(nameof(FullName));
        OnPropertyChanged(nameof(Email));
        OnPropertyChanged(nameof(Sex));
        OnPropertyChanged(nameof(Phone));
        OnPropertyChanged(nameof(RoleName));
        OnPropertyChanged(nameof(Bi));
        OnPropertyChanged(nameof(PhotoPath));
        OnPropertyChanged(nameof(IsStaff));
        OnPropertyChanged(nameof(IsActive));
        OnPropertyChanged(nameof(IsSuperUser));
        OnPropertyChanged(nameof(DateJoined));
        OnPropertyChanged(nameof(DateOfBirth));
        OnPropertyChanged(nameof(IssuedOn));
        OnPropertyChanged(nameof(ValidUntil));
    }


    public string UserName => LoggedUser?.UserName ?? "";
    public string FullName => LoggedUser?.FullName ?? "";
    public string Email => LoggedUser?.Email ?? "";
    public string Sex => LoggedUser?.Sex ?? "";
    public string Phone => LoggedUser?.Phone ?? "";
    public string RoleName => LoggedUser?.RoleName ?? "";
    public string Bi => LoggedUser?.Bi ?? "";
    public string PhotoPath => LoggedUser?.PhotoPath ?? "";
    public bool IsStaff => LoggedUser?.IsStaff ?? false;
    public bool IsActive => LoggedUser?.IsActive ?? false;
    public bool IsSuperUser => LoggedUser?.IsSuperUser ?? false;
    public DateTime DateJoined => LoggedUser?.DateJoined ?? DateTime.MinValue;
    public DateTime DateOfBirth => LoggedUser?.DateOfBirth ?? DateTime.MinValue;
    public DateTime IssuedOn => LoggedUser?.IssuedOn ?? DateTime.MinValue;
    public DateTime ValidUntil => LoggedUser?.ValidUntil ?? DateTime.MinValue;

}
