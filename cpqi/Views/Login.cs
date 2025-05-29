using cpqi.ViewModels;
using cpqi.Views.Admin;

namespace cpqi
{
    public partial class Login : Form
    {
        private readonly FormManager _formManager;
        private readonly AuthenticatedUserViewModel _userViewModel;
        public Login(FormManager formManager, AuthenticatedUserViewModel userViewModel)
        {
            InitializeComponent();
            _formManager = formManager;
            _userViewModel = userViewModel;

            lbl_version.Text = $"Versão : {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";
        }
        private async void Btn_login_Click(object sender, EventArgs e)
        {
            // Here you would typically validate the username and password
            // For demonstration purposes, we will just open the AdminHome form directly
            var username = TxtUserName.Text;
            var password = TxtPassword.Text;

           

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Preencha nome de usuário e senha.");
                return;
            }
            PbLoading.Visible = true;
            this.UseWaitCursor = true;

            bool success = await _userViewModel.LoginAsync(username, password);
            
            PbLoading.Visible = false;
            this.UseWaitCursor = false;

            if (!success)
            {
                MessageBox.Show("Credenciais inválidas. Verifique seu nome de usuário ou senha.");
                return;
            }

            _formManager.ShowDashboardForUser();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
