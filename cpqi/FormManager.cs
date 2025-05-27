using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cpqi.Data;
using cpqi.Models;
using cpqi.ViewModels;
using cpqi.Views.Admin;
using Microsoft.Extensions.DependencyInjection;

namespace cpqi
{
    public class FormManager
    {
        private readonly UserViewModel _userViewModel;
        private readonly IServiceProvider _serviceProvider;


        public FormManager(UserViewModel userViewModel, IServiceProvider serviceProvider)
        {
            _userViewModel = userViewModel;
            _serviceProvider = serviceProvider;
        }
        public void ShowDashboardForUser()
        {
            var user = _userViewModel.LoggedUser;

            if (user == null || user.Role == null)
            {
                MessageBox.Show("Usuário não autenticado!");
                return;
            }
            var dbContext = _serviceProvider.GetRequiredService<CpqiDbContext>();

            switch (user.Role.RoleName)
            {
                case "Administrador":
                    var adminForm = new AdminHome(user, this, _userViewModel, dbContext);
                    adminForm.Show();
                    break;
                case "Assistente administrativa":
                    new AdminHome(user, this, _userViewModel, dbContext).Show();
                    break;
                case "Professor":
                    new AdminHome(user, this, _userViewModel, dbContext).Show();
                    break;
                default:
                    MessageBox.Show("Acesso não autorizado para este papel.");
                    break;
            }
        }
        public void ShowAdminHomeForm(User user)
        {
            var dbContext = _serviceProvider.GetRequiredService<CpqiDbContext>();
            new AdminHome(user, this, _userViewModel, dbContext).Show();
        }

        public void ShowLoginForm()
        {
            var login = _serviceProvider.GetRequiredService<Login>();
            login.Show();
        }
    }
}
