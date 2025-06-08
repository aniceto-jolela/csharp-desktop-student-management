using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cpqi.Migrations
{
    /// <inheritdoc />
    public partial class AddMatricula : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Inscricao_InscricaoID",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Province_ProvinceID",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Turma_TurmaID",
                table: "Matriculas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matriculas",
                table: "Matriculas");

            migrationBuilder.RenameTable(
                name: "Matriculas",
                newName: "Matricula");

            migrationBuilder.RenameIndex(
                name: "IX_Matriculas_TurmaID",
                table: "Matricula",
                newName: "IX_Matricula_TurmaID");

            migrationBuilder.RenameIndex(
                name: "IX_Matriculas_ProvinceID",
                table: "Matricula",
                newName: "IX_Matricula_ProvinceID");

            migrationBuilder.RenameIndex(
                name: "IX_Matriculas_MatriculaNumber",
                table: "Matricula",
                newName: "IX_Matricula_MatriculaNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Matriculas_InscricaoID",
                table: "Matricula",
                newName: "IX_Matricula_InscricaoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matricula",
                table: "Matricula",
                column: "MatriculaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Inscricao_InscricaoID",
                table: "Matricula",
                column: "InscricaoID",
                principalTable: "Inscricao",
                principalColumn: "InscricaoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Province_ProvinceID",
                table: "Matricula",
                column: "ProvinceID",
                principalTable: "Province",
                principalColumn: "ProvinceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Turma_TurmaID",
                table: "Matricula",
                column: "TurmaID",
                principalTable: "Turma",
                principalColumn: "TurmaID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Inscricao_InscricaoID",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Province_ProvinceID",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Turma_TurmaID",
                table: "Matricula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matricula",
                table: "Matricula");

            migrationBuilder.RenameTable(
                name: "Matricula",
                newName: "Matriculas");

            migrationBuilder.RenameIndex(
                name: "IX_Matricula_TurmaID",
                table: "Matriculas",
                newName: "IX_Matriculas_TurmaID");

            migrationBuilder.RenameIndex(
                name: "IX_Matricula_ProvinceID",
                table: "Matriculas",
                newName: "IX_Matriculas_ProvinceID");

            migrationBuilder.RenameIndex(
                name: "IX_Matricula_MatriculaNumber",
                table: "Matriculas",
                newName: "IX_Matriculas_MatriculaNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Matricula_InscricaoID",
                table: "Matriculas",
                newName: "IX_Matriculas_InscricaoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matriculas",
                table: "Matriculas",
                column: "MatriculaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Inscricao_InscricaoID",
                table: "Matriculas",
                column: "InscricaoID",
                principalTable: "Inscricao",
                principalColumn: "InscricaoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Province_ProvinceID",
                table: "Matriculas",
                column: "ProvinceID",
                principalTable: "Province",
                principalColumn: "ProvinceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Turma_TurmaID",
                table: "Matriculas",
                column: "TurmaID",
                principalTable: "Turma",
                principalColumn: "TurmaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
