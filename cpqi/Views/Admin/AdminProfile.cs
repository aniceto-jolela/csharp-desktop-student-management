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
        private readonly UserViewModel _userViewModel;
        public AdminProfile(UserViewModel userViewModel)
        {
            InitializeComponent();
            _userViewModel = userViewModel;
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
    }
}
