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

namespace cpqi.DAL
{
    public class UserRepository
    {
        public List<User> GetAllUsers()
        { 
            var users = new List<User>();

            using (var conn = DatabaseConfig.GetConnection())
            {
                string query = @"SELECT UserID, Username, FullName, Sex, Email, Phone, PasswordHash, PhotoPath, DateOfBirth,
                       IsStaff, IsActive, IsSuperUser, DateJoined, FileBiPath, IssuedOn, ValidUntil, FileCvPath,
                       RoleID, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy FROM [User]";
                var cmd = new SqlCommand(query, conn);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            UserID = reader.GetInt32(0),
                            UserName = reader.GetString(1),
                            FullName = reader.GetString(2),
                            Sex = reader.IsDBNull(3)? null : reader.GetString(3)[0],
                            Email = reader.IsDBNull(4)? null: reader.GetString(4),
                            Phone = reader.IsDBNull(5) ? null : reader.GetString(5),
                            PasswordHash = (byte[])reader[6],
                            PhotoPath = reader.IsDBNull(7) ? null : reader.GetString(7),
                            DateOfBirth = reader.IsDBNull(8) ? null : reader.GetDateTime(8),
                            IsStaff = reader.GetBoolean(9),
                            IsActive = reader.GetBoolean(10),
                            IsSuperUser = reader.GetBoolean(11),
                            DateJoined = reader.GetDateTime(12),
                            FileBiPath = reader.IsDBNull(13) ? null : reader.GetString(13),
                            IssuedOn = reader.IsDBNull(14) ? null : reader.GetDateTime(14),
                            ValidUntil = reader.IsDBNull(15) ? null : reader.GetDateTime(15),
                            FileCvPath = reader.IsDBNull(16) ? null : reader.GetString(16),
                            RoleID = reader.IsDBNull(17) ? null : reader.GetInt32(17),
                            CreatedAt = reader.GetDateTime(18),
                            CreatedBy = reader.GetString(19),
                            UpdatedAt = reader.IsDBNull(20) ? null : reader.GetDateTime(20),
                            UpdatedBy = reader.IsDBNull(21) ? null : reader.GetString(21)
                        });
                    }
                }
            }
            return users;
        }
        public void AddUser(User user)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                string query = @"INSERT INTO [User] (Username, FullName, Sex, Email, Phone, PasswordHash, PhotoPath, DateOfBirth, IsStaff, IsActive, IsSuperUser, DateJoined, FileBiPath, IssuedOn, ValidUntil, FileCvPath,RoleID, CreatedBy)
                    VALUES (@Username, @FullName, @Sex, @Email, @Phone, @PasswordHash, @PhotoPath, @DateOfBirth, @IsStaff, @IsActive, @IsSuperUser, @DateJoined, @FileBiPath, @IssuedOn, @ValidUntil, @FileCvPath,@RoleID, @CreatedBy)";

                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Sex", (object?)user.Sex ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", (object?)user.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", (object?)user.Phone ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@PhotoPath", (object?)user.PhotoPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DateOfBirth", (object?)user.DateOfBirth ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IsStaff", user.IsStaff);
                cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
                cmd.Parameters.AddWithValue("@IsSuperUser", user.IsSuperUser);
                cmd.Parameters.AddWithValue("@DateJoined", user.DateJoined);
                cmd.Parameters.AddWithValue("@FileBiPath", (object?)user.FileBiPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IssuedOn", (object?)user.IssuedOn ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ValidUntil", (object?)user.ValidUntil ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FileCvPath", (object?)user.FileCvPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RoleID", (object?)user.RoleID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CreatedBy", user.CreatedBy);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateUser(User user)
        {
            using (var conn = DatabaseConfig.GetConnection())
            { 
                string query = @"
            UPDATE [User]
            SET Username = @Username,
                FullName = @FullName,
                Sex = @Sex,
                Email = @Email,
                Phone = @Phone,
                PasswordHash = @PasswordHash,
                PhotoPath = @PhotoPath,
                DateOfBirth = @DateOfBirth,
                IsStaff = @IsStaff,
                IsActive = @IsActive,
                IsSuperUser = @IsSuperUser,
                FileBiPath = @FileBiPath,
                IssuedOn = @IssuedOn,
                ValidUntil = @ValidUntil,
                FileCvPath = @FileCvPath,
                RoleID = @RoleID,
                UpdatedAt = GETDATE(),
                UpdatedBy = @UpdatedBy
            WHERE UserID = @UserID";

                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Sex", (object?)user.Sex ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", (object?)user.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", (object?)user.Phone ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@PhotoPath", (object?)user.PhotoPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DateOfBirth", (object?)user.DateOfBirth ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IsStaff", user.IsStaff);
                cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
                cmd.Parameters.AddWithValue("@IsSuperUser", user.IsSuperUser);
                cmd.Parameters.AddWithValue("@FileBiPath", (object?)user.FileBiPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IssuedOn", (object?)user.IssuedOn ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ValidUntil", (object?)user.ValidUntil ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FileCvPath", (object?)user.FileCvPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RoleID", (object?)user.RoleID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@UpdatedBy", (object?)user.UpdatedBy ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteUser(int UserID)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                string query = "UPDATE [User] SET IsActive = @IsActive WHERE UserID = @UserID";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
