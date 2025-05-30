using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cpqi.ViewModels;
using Krypton.Toolkit;

namespace cpqi.Views.Admin
{
    public partial class AdminProfile : Form
    {
        private readonly AuthenticatedUserViewModel _userViewModel;
        public AdminProfile(AuthenticatedUserViewModel userViewModel)
        {
            InitializeComponent();
            _userViewModel = userViewModel;

            LoadUser();
        }
        private void LoadUser()
        {
            // Check if the user is logged in
            LblUser.Text = _userViewModel.UserName;
            LblFullName.Text = _userViewModel.FullName;
            LblSex.Text = _userViewModel.Sex;
            LblEmail.Text = _userViewModel.Email;
            LblPhone.Text = _userViewModel.Phone;
            LblRole.Text = _userViewModel.RoleName;
            LblNBI.Text = _userViewModel.Bi;
            LblBirthDay.Text = _userViewModel.DateOfBirth.ToShortDateString();
            LblIssuedOn.Text = _userViewModel.IssuedOn.ToShortDateString();
            LblValidUntil.Text = _userViewModel.ValidUntil.ToShortDateString();
            if (string.IsNullOrWhiteSpace(_userViewModel.PhotoPath) || !File.Exists(_userViewModel.PhotoPath))
            {
                PbPhoto.Image = Properties.Resources.administrator; // Use a default image if PhotoPath is null
            }
            else
            {
                PbPhoto.Image = Image.FromFile(_userViewModel.PhotoPath);
            }

            // Load the user data into the text boxes for editing
            TxtUser.Text = _userViewModel.UserName;
            TxtFullName.Text = _userViewModel.FullName;
            CbSex.SelectedItem = _userViewModel.Sex;
            TxtEmail.Text = _userViewModel.Email;
            TxtPhone.Text = _userViewModel.Phone;
            TxtNBI.Text = _userViewModel.Bi;
            DtpDateOfBirth.Value = _userViewModel.DateOfBirth;
            DtpIssuedOn.Value = _userViewModel.IssuedOn;
            DtpValidUntil.Value = _userViewModel.ValidUntil;

        }

        private void btnBI_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivo de documento (*.pdf)|*.pdf|Todos os arquivos (*.*)|(*.*)";
            openFileDialog1.Title = "Selecionar um arquivo";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                MessageBox.Show("Arquivo selecionado: " + filePath);
            }
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Arquivo de documento (*.pdf)|*.pdf";
            openFileDialog2.Title = "Selecionar um arquivo";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog2.FileName;
                MessageBox.Show("Arquivo selecionado: " + filePath);
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog3.Filter = "Arquivo de imagem (*.jpg*;.jpeg*;.png)|*.jpg;*.jpeg;*.png";
            openFileDialog3.Title = "Selecionar um arquivo";

            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog3.FileName;
                MessageBox.Show("Arquivo selecionado: " + filePath);
            }
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CxbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CxbPassword.Checked == false)
            {
                TxtPassword.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true; // Hide password
            }
        }
    }
}
