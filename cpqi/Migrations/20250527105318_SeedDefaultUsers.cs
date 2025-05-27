using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cpqi.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Bi", "CreatedAt", "CreatedBy", "DateJoined", "DateOfBirth", "Email", "FileBiPath", "FileCvPath", "FullName", "IsActive", "IsStaff", "IsSuperUser", "IssuedOn", "PasswordHash", "Phone", "PhotoPath", "RoleID", "Salt", "Sex", "UpdatedAt", "UpdatedBy", "UserName", "ValidUntil" },
                values: new object[,]
                {
                    { 1, "00000000000000", new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "seed", new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "otecina500@gmail.com", null, null, "System Administrator", true, true, true, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 166, 130, 25, 219, 239, 119, 31, 83, 197, 26, 127, 199, 94, 90, 121, 125, 183, 232, 233, 196, 174, 70, 74, 131, 184, 31, 255, 36, 182, 63, 74, 71 }, "+244935259317", null, 1, new byte[] { 86, 20, 249, 233, 128, 57, 165, 36, 73, 217, 227, 12, 119, 2, 122, 144 }, "MASCULINO", null, null, "admin", new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "11111111111111", new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "seed", new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@cpqi.com", null, null, "Administrador Padrão", true, true, true, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 42, 235, 23, 255, 103, 86, 59, 191, 154, 249, 178, 252, 139, 211, 7, 40, 28, 153, 9, 102, 68, 141, 147, 247, 194, 237, 188, 99, 185, 184, 155, 115 }, "111111111", null, 1, new byte[] { 42, 235, 128, 224, 239, 144, 83, 41, 139, 254, 244, 34, 237, 152, 246, 15 }, "MASCULINO", null, null, "admin12345678", new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 2);
        }
    }
}
