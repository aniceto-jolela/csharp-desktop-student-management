using cpqi.Views.Admin;

namespace cpqi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lbl_version.Text = "Versão : " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            admin_home admin = new admin_home();
            admin.Show();
            this.Hide();
            

        }
    }
}
