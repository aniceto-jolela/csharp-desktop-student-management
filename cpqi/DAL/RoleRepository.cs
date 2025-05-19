using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cpqi.Models;
using Microsoft.Data.SqlClient;

namespace cpqi.DAL
{
    public class RoleRepository
    {
        public List<Role> GetAllRoles()
        {
            var roles = new List<Role>();

            using (var conn = DatabaseConfig.GetConnection())
            {
                string query = @"SELECT RoleID, RoleName, [Description] FROM [Role]";
                var cmd = new SqlCommand(query, conn);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                { 
                    while(reader.Read())
                    {
                        roles.Add(new Role
                        {
                            RoleID = reader.GetInt32(0),
                            RoleName = reader.GetString(1),
                            Description = reader.IsDBNull(2) ? null : reader.GetString(2)
                        });
                    }
                }
            }
            return roles;
        }
    }
}
