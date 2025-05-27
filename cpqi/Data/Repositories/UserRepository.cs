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
using cpqi.DAL;
using Microsoft.EntityFrameworkCore;

namespace cpqi.Data.Repositories
{
    public class UserRepository
    {
        private readonly CpqiDbContext _context;

        public UserRepository(CpqiDbContext context)
        {
            _context = context;
        }
        public User? GetUserByUsername(string username)
        {
            return _context.Users
                .Include(u => u.Role)
                .FirstOrDefault(u => u.UserName == username);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.Users
                .Include(u => u.Role)
                .Where(u => u.IsActive)
                .ToListAsync();
        }
    
        public async Task AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteUserAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if(user is not null)
            {
                user.IsActive = false; // Soft delete
                await _context.SaveChangesAsync();
            }
        }
    }
}
