using CommunityToolkit.Mvvm.ComponentModel;
using cpqi.Models;
using cpqi.Data.Repositories;
using System.Collections.ObjectModel;

namespace cpqi.ViewModels
{
    public partial class RoleViewModel : ObservableObject
    {
        private readonly RoleRepository _roleRepository;

        public ObservableCollection<Role> Roles { get; } = new();

        public RoleViewModel(RoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
            LoadRoles();
        }

        public async void LoadRoles()
        {
            var roles = await _roleRepository.GetAllRolesAsync();
            Roles.Clear();
            foreach (var role in roles)
                Roles.Add(role);
        }
    }
}
