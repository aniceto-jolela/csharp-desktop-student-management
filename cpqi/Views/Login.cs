using cpqi.ViewModels;
using cpqi.Views.Admin;

namespace cpqi
{
    public partial class Login : Form
    {
        private readonly FormManager _formManager;
        private readonly UserViewModel _userViewModel;
        public Login(FormManager formManager, UserViewModel userViewModel)
        {
            InitializeComponent();
            _formManager = formManager;
            _userViewModel = userViewModel;

            lbl_version.Text = $"Versão : {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            // Here you would typically validate the username and password
            // For demonstration purposes, we will just open the AdminHome form directly
            var username = txtUserName.Text.Trim();
            var password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Preencha nome de usuário e senha.");
                return;
            }
            bool success = _userViewModel.Login(username, password);
            if (!success)
            {
                MessageBox.Show("Credenciais inválidas. Verifique seu nome de usuário ou senha.");
                return;
            }

            _formManager.ShowDashboardForUser();
            this.Hide();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
