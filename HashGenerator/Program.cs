// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Static default User and password! Come from with system.");

GenerateHashAndSalt("......", "admin");
GenerateHashAndSalt("12345678", "admin12345678");

static void GenerateHashAndSalt(string password, string username)
{
    byte[] salt = new byte[16];
    RandomNumberGenerator.Fill(salt);

    using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256);
    byte[] hash = pbkdf2.GetBytes(32);

    Console.WriteLine($"Usuário: {username}");
    Console.WriteLine($"Salt = new byte[] {{ {string.Join(", ", salt)} }};");
    Console.WriteLine($"PasswordHash = new byte[] {{ {string.Join(", ", hash)} }};");
    Console.WriteLine();
}