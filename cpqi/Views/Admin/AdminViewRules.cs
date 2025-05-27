using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cpqi.Data;
using cpqi.Data.Repositories;
using cpqi.Models;
using cpqi.ViewModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


namespace cpqi.Views.Admin
{
    public partial class AdminViewRules : Form
    {
        private readonly RoleViewModel _viewModel;
        public AdminViewRules(RoleViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
        }
        private void ViewRules_Load(object sender, EventArgs e)
        {
            dgvRules.DataSource = _viewModel.Roles;
        }
        
        private void GeneratePdf(DataTable dataTable, string pathFile)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Content()
                    .Column(column =>
                    {
                        column.Spacing(10);

                        //Header
                        column.Item().Text("Relatório de Dados").Bold().FontSize(16);

                        //Table
                        column.Item().Table(pdfTable =>
                        {
                            //Number of column
                            pdfTable.ColumnsDefinition(columns =>
                            {
                                foreach (DataColumn col in dataTable.Columns)
                                    columns.ConstantColumn(130);
                            });

                            //Column of Header
                            pdfTable.Header(header =>
                            {
                                foreach (DataColumn column in dataTable.Columns)
                                    header.Cell().Background(Colors.Grey.Lighten2).Text(column.ColumnName).Bold();
                            });

                            // Data roes
                            foreach (DataRow row in dataTable.Rows)
                            {
                                foreach (DataColumn col in dataTable.Columns)
                                    pdfTable.Cell().Text(row[col].ToString());
                            }
                        });
                    });
                });
            })
            .GeneratePdf(pathFile);
        }
        private void pbPdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRules.DataSource != null)
                {
                    string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

                    string filePath = Path.Combine(downloadsPath, "cargos.pdf");

                    if (!Directory.Exists(downloadsPath))
                        Directory.CreateDirectory(downloadsPath);

                    GeneratePdf((DataTable)dgvRules.DataSource, filePath);
                    MessageBox.Show("PDF gerado com sucesso: " + filePath);
                }
                else
                {
                    MessageBox.Show("Nenhum dado para gerar PDF.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao gerar pdf: " + ex.Message);
            }

        }

        
    }
}
