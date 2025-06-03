using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Azure.Identity;
using System.ComponentModel.DataAnnotations;
using cpqi.Models;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace cpqi.Data.Repositories
{
    public class UserRepository
    {
        private readonly IDbContextFactory<CpqiDbContext> _contextFactory;

        public UserRepository(IDbContextFactory<CpqiDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task<User?> GetUserByUsername(string username)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.UserName == username);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Users
                .Include(u => u.Role)
                .Where(u => u.IsActive)
                .ToListAsync();
        }
    
        public async Task AddUserAsync(User user)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Users.Add(user);
            await context.SaveChangesAsync();
        }
        public async Task UpdateUserAsync(User user)
        {
            using var context = _contextFactory.CreateDbContext();

            var existingUser = await context.Users.FindAsync(user.UserID);
            if (existingUser == null) return;
            
            context.Entry(existingUser).CurrentValues.SetValues(user);

            existingUser.UserName = user.UserName;
            existingUser.FullName = user.FullName;
            existingUser.Sex = user.Sex;
            existingUser.Email = user.Email;
            existingUser.Phone = user.Phone;
            existingUser.Bi = user.Bi;
            existingUser.PhotoPath = user.PhotoPath;
            existingUser.DateOfBirth = user.DateOfBirth;
            existingUser.FileBiPath = user.FileBiPath;
            existingUser.IssuedOn = user.IssuedOn;
            existingUser.ValidUntil = user.ValidUntil;
            existingUser.FileCvPath = user.FileCvPath;
            existingUser.RoleID = user.RoleID;
            existingUser.IsActive = user.IsActive;
            existingUser.IsStaff = user.IsStaff;
            existingUser.IsSuperUser = user.IsSuperUser;
            existingUser.UpdatedAt = DateTime.Now;
            existingUser.UpdatedBy = user.UpdatedBy;
            
            if (user.PasswordHash != null && user.Salt != null)
            {
                if (!user.PasswordHash.SequenceEqual(existingUser.PasswordHash) ||
                    !user.Salt.SequenceEqual(existingUser.Salt))
                {
                    existingUser.PasswordHash = user.PasswordHash;
                    existingUser.Salt = user.Salt;
                }
            }await context.SaveChangesAsync();
        }
        public async Task DeleteUserAsync(int userId)
        {
            using var context = _contextFactory.CreateDbContext();
            var user = await context.Users.FindAsync(userId);
            if(user is not null)
            {
                user.IsActive = false; // Soft delete
                await context.SaveChangesAsync();
            }
        }
        public async Task AccessUserAsync(int userId, bool status)
        {
            using var context = _contextFactory.CreateDbContext();
            var user = await context.Users.FindAsync(userId);
            if (user is not null)
            {
                user.IsStaff = status; // Soft delete
                await context.SaveChangesAsync();
            }
        }
        public async Task RecoverUserAsync(int userId)
        {
            using var context = _contextFactory.CreateDbContext();
            var user = await context.Users.FindAsync(userId);
            if (user is not null)
            {
                user.IsActive = true; // Soft recover
                await context.SaveChangesAsync();
            }
        }
        public async Task SuperUserAsync(int userId, bool status)
        {
            using var context = _contextFactory.CreateDbContext();
            var user = await context.Users.FindAsync(userId);
            if (user is not null)
            {
                user.IsSuperUser = status; // Soft IsSuperUser | "total access"
                await context.SaveChangesAsync();
            }
        }
    }
}
