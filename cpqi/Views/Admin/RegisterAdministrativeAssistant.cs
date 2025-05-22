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

namespace cpqi.Views.Admin
{
    public partial class RegisterAdministrativeAssistant : Form
    {
        private readonly UserViewModel _viewModel;
        public RegisterAdministrativeAssistant()
        {
            InitializeComponent();

            _viewModel = new UserViewModel();

            /*txtUserName.DataBindings.Add(nameof(txtUserName.Text), _viewModel, nameof(_viewModel.UserName), false, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add(nameof(txtFullName.Text), _viewModel, nameof(_viewModel.FullName), false, DataSourceUpdateMode.OnPropertyChanged);
            cbSex.DataBindings.Add(nameof(cbSex.SelectedItem), _viewModel, nameof(_viewModel.Sex), false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add(nameof(txtEmail.Text), _viewModel, nameof(_viewModel.Email), false, DataSourceUpdateMode.OnPropertyChanged);
            txtPhone.DataBindings.Add(nameof(txtPhone.Text), _viewModel, nameof(_viewModel.Phone), false, DataSourceUpdateMode.OnPropertyChanged);
            txtPassword.DataBindings.Add(nameof(txtPassword.Text), _viewModel, nameof(_viewModel.Password), false, DataSourceUpdateMode.OnPropertyChanged);
            ckbIsStaff.DataBindings.Add(nameof(ckbIsStaff.Checked), _viewModel, nameof(_viewModel.IsStaff), false, DataSourceUpdateMode.OnPropertyChanged);
            ckbIsActive.DataBindings.Add(nameof(ckbIsActive.Checked), _viewModel, nameof(_viewModel.IsActive), false, DataSourceUpdateMode.OnPropertyChanged);
            ckbIsSuperUser.DataBindings.Add(nameof(ckbIsSuperUser.Checked), _viewModel, nameof(_viewModel.IsSuperUser), false, DataSourceUpdateMode.OnPropertyChanged);
            //dtpDateOfBirth.DataBindings.Add(nameof(dtpDateOfBirth.Value), _viewModel, nameof(_viewModel.DateOfBirth), false, DataSourceUpdateMode.OnPropertyChanged);
            */
            _viewModel.RoleID = 3; // Set default role ID for Administrative Assistant
            /*
            btnRegister.Click += (s, e) =>
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    _viewModel.AddUserCommand.Execute(null);
                    MessageBox.Show("User registered successfully!");
                    this.Close();
                }
            };*/
        }

        private void RegisterAdministrativeAssistant_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {

        }

        private void kryptonDateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnCV_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivo de documento (*.pdf)|*.pdf|Todos os arquivos (*.*)|(*.*)";
            openFileDialog1.Title = "Selecionar um arquivo";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                MessageBox.Show("Arquivo selecionado: " + filePath);
            }
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

       
    }
}
