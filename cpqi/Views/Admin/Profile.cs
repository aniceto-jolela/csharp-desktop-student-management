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
    public partial class Profile : Form
    {
        private readonly CounterViewModel _viewModel;
        public Profile()
        {
            InitializeComponent();
        }

        private void kryptonSplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_increment_Click(object sender, EventArgs e)
        {
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonSplitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel26_Click(object sender, EventArgs e)
        {

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
