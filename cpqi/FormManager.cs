﻿using System;
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
        private readonly AuthenticatedUserViewModel _userViewModel;
        private readonly IServiceProvider _serviceProvider;


        public FormManager(AuthenticatedUserViewModel userViewModel, IServiceProvider serviceProvider)
        {
            _userViewModel = userViewModel;
            _serviceProvider = serviceProvider;
        }
        private void ShowUniqueForm<T>(bool modal = true, params object[] args) where T : Form
        {
            foreach(Form f in Application.OpenForms)
            {
                if(f is T)
                {
                    f.Focus();
                    return;
                }
            }
            var form = (T)ActivatorUtilities.CreateInstance(_serviceProvider, typeof(T), args);
            if (modal)
                form.ShowDialog();
            else
                form.Show();
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

            switch (user.Role.RoleID)
            {
                case 1:
                    ShowAdminHomeForm(user);
                    break;
                case 2:
                    ShowAdminHomeForm(user);
                    break;
                case 3:
                    new AdminHome(user, this, _userViewModel).Show();
                    break;
                default:
                    MessageBox.Show("Acesso não autorizado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                    break;
            }
        }
        public void ShowAdminHomeForm(User user)
        {
            if (user.Role == null || user.Role.RoleName != "Administrador" || user.Role.RoleID != 1)
            {
                MessageBox.Show("Acesso negado.", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            ShowUniqueForm<AdminHome>(modal: false, user, this, _userViewModel);
        }
        public void ShowLoginForm()
        {
            ShowUniqueForm<Login>(modal: false);
        }
        /// <summary>
        /// Administrator
        /// </summary>

        //-------> Register
        public void ShowAdminRegisterAdministrativeAssistantForm()
        {
            ShowUniqueForm<AdminRegisterAdministrativeAssistant>();
        }
        //-------> View
        public void ShowAdminProfileForm()
        {
            ShowUniqueForm<AdminProfile>();
        }
        public void ShowAdminRolesForm()
        {
            ShowUniqueForm<AdminViewRoles>();
        }
        public void ShowAdminViewAdministrativeAssistantForm()
        {
            ShowUniqueForm<AdminViewAdministrativeAssistant>();
        }
        /// <summary>
        /// Admin Assistant
        /// </summary>


        /// <summary>
        /// Teacher
        /// </summary>
    }
}
