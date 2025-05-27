using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cpqi.DAL;
using cpqi.Data;
using cpqi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


namespace cpqi.Views.Admin
{
    public partial class ViewRules : Form
    {
        private readonly CpqiDbContext _context;  
        public ViewRules(CpqiDbContext context)
        {
            InitializeComponent();
            _context = context;
            LoadData();
        }
        private async void LoadData()
        { 
            try
            {
                var roles = await _context.Roles
                    .Select(r => new
                    {
                        r.RoleID,
                        r.RoleName,
                        r.Description
                    })
                    .ToListAsync();
                
                var table = new DataTable();
                table.Columns.Add("Nº", typeof(int));
                table.Columns.Add("CARGOS", typeof(string));
                table.Columns.Add("DESCIÇÕES", typeof(string));

                foreach(var role in roles)
                {
                    table.Rows.Add(role.RoleID, role.RoleName, role.Description);
                }

                dgvRules.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
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
