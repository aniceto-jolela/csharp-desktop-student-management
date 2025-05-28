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

namespace cpqi.Data.Repositories
{
    public class UserRepository
    {
        private readonly IDbContextFactory<CpqiDbContext> _contextFactory;

        public UserRepository(IDbContextFactory<CpqiDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public User? GetUserByUsername(string username)
        {
            using var context = _contextFactory.CreateDbContext();
            return context.Users
                .Include(u => u.Role)
                .FirstOrDefault(u => u.UserName == username);
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
            context.Users.Update(user);
            await context.SaveChangesAsync();
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
    }
}
