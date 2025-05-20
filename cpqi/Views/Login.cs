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

            adHome admin = new adHome();
            admin.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            adHome admin = new adHome();
            admin.Show();
            this.Hide();
        }
    }
}
