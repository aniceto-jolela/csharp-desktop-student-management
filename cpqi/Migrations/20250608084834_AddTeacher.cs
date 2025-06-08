using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cpqi.Migrations
{
    /// <inheritdoc />
    public partial class AddTeacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classe",
                columns: table => new
                {
                    ClasseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClasseName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classe", x => x.ClasseID);
                });

            migrationBuilder.CreateTable(
                name: "ClassRoom",
                columns: table => new
                {
                    ClassRoomID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassRoomNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    MaximumCapacity = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoom", x => x.ClassRoomID);
                });

            migrationBuilder.CreateTable(
                name: "Discipline",
                columns: table => new
                {
                    DisciplineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisciplineName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisciplineCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discipline", x => x.DisciplineID);
                });

            migrationBuilder.CreateTable(
                name: "Period",
                columns: table => new
                {
                    PeriodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Period", x => x.PeriodID);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceID);
                });

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    TurmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTurma = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ClassRoomID = table.Column<int>(type: "int", nullable: false),
                    ClasseID = table.Column<int>(type: "int", nullable: false),
                    MainTeacher = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.TurmaID);
                    table.ForeignKey(
                        name: "FK_Turma_ClassRoom_ClassRoomID",
                        column: x => x.ClassRoomID,
                        principalTable: "ClassRoom",
                        principalColumn: "ClassRoomID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Turma_Classe_ClasseID",
                        column: x => x.ClasseID,
                        principalTable: "Classe",
                        principalColumn: "ClasseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inscricao",
                columns: table => new
                {
                    InscricaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InscricaoNumber = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClasseID = table.Column<int>(type: "int", nullable: false),
                    PeriodID = table.Column<int>(type: "int", nullable: false),
                    Phone1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DateInscricao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EncarregadoDeEducacao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsStudent = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscricao", x => x.InscricaoID);
                    table.ForeignKey(
                        name: "FK_Inscricao_Classe_ClasseID",
                        column: x => x.ClasseID,
                        principalTable: "Classe",
                        principalColumn: "ClasseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inscricao_Period_PeriodID",
                        column: x => x.PeriodID,
                        principalTable: "Period",
                        principalColumn: "PeriodID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DisciplineID = table.Column<int>(type: "int", nullable: false),
                    PeriodID = table.Column<int>(type: "int", nullable: false),
                    TurmaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherID);
                    table.ForeignKey(
                        name: "FK_Teacher_Discipline_DisciplineID",
                        column: x => x.DisciplineID,
                        principalTable: "Discipline",
                        principalColumn: "DisciplineID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teacher_Period_PeriodID",
                        column: x => x.PeriodID,
                        principalTable: "Period",
                        principalColumn: "PeriodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teacher_Turma_TurmaID",
                        column: x => x.TurmaID,
                        principalTable: "Turma",
                        principalColumn: "TurmaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teacher_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    MatriculaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatriculaNumber = table.Column<int>(type: "int", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NaturalOf = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProvinceID = table.Column<int>(type: "int", nullable: false),
                    ResideEm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BiCedula = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IssuedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidUntil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TurmaID = table.Column<int>(type: "int", nullable: false),
                    TransferidoOfSchool = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LocalizadoEm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneFather = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PhoneMother = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Patologia = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsUsingAnyMedication = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CopyOfReceitaPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DateMatricula = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InscricaoID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.MatriculaID);
                    table.ForeignKey(
                        name: "FK_Matriculas_Inscricao_InscricaoID",
                        column: x => x.InscricaoID,
                        principalTable: "Inscricao",
                        principalColumn: "InscricaoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculas_Province_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Province",
                        principalColumn: "ProvinceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matriculas_Turma_TurmaID",
                        column: x => x.TurmaID,
                        principalTable: "Turma",
                        principalColumn: "TurmaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ClassRoom",
                columns: new[] { "ClassRoomID", "ClassRoomNumber", "Location", "MaximumCapacity" },
                values: new object[,]
                {
                    { 1, "Sala 01", "Rés-do-chão", 30 },
                    { 2, "Sala 02", "1º Andar", 30 },
                    { 3, "Sala 03", "1º Andar", 30 },
                    { 4, "Sala 04", "1º Andar", 30 },
                    { 5, "Sala 05", "1º Andar", 30 },
                    { 6, "Sala 06", "1º Andar", 30 },
                    { 7, "Sala 07", "1º Andar", 30 },
                    { 8, "Todas as Salas", "Todos Andares", 210 }
                });

            migrationBuilder.InsertData(
                table: "Classe",
                columns: new[] { "ClasseID", "ClasseName" },
                values: new object[,]
                {
                    { 1, "Iniciação" },
                    { 2, "1ª Classe" },
                    { 3, "2ª Classe" },
                    { 4, "3ª Classe" },
                    { 5, "4ª Classe" },
                    { 6, "5ª Classe" },
                    { 7, "6ª Classe" },
                    { 8, "Todas Classes" }
                });

            migrationBuilder.InsertData(
                table: "Discipline",
                columns: new[] { "DisciplineID", "DisciplineCode", "DisciplineName" },
                values: new object[,]
                {
                    { 1, "MAT", "Matemática" },
                    { 2, "HIS", "História" },
                    { 3, "GEO", "Geografia" },
                    { 4, "EM", "Estudo Do Meio" },
                    { 5, "MUS", "Educação Musical" },
                    { 6, "CN", "Ciência Da Natureza" },
                    { 7, "EMP", "Educação Manual E Plástica" },
                    { 8, "LP", "Língua Portuguesa" },
                    { 9, "LI", "Língua Inglesa" },
                    { 10, "LF", "Língua Francesa" },
                    { 11, "LKIK", "Língua Kikongo" },
                    { 12, "LUMB", "Língua Umbundo" },
                    { 13, "LKIM", "Língua Kimbundo" }
                });

            migrationBuilder.InsertData(
                table: "Period",
                columns: new[] { "PeriodID", "PeriodName" },
                values: new object[,]
                {
                    { 1, "Manhã" },
                    { 2, "Tarde" },
                    { 3, "Manhã e Tarde" }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceID", "ProvinceName" },
                values: new object[,]
                {
                    { 1, "Província de Luanda, com capital na Ingombota" },
                    { 2, "Província de Cabinda, com capital em Cabinda" },
                    { 3, "Província do Zaire, com capital em Mbanza Kongo" },
                    { 4, "Província do Uíge, com capital no Uíge" },
                    { 5, "Província do Bengo, com capital no Dande" },
                    { 6, "Província do Icolo e Bengo, com capital em Catete" },
                    { 7, "Província do Cuanza - Norte, com capital no Cazengo" },
                    { 8, "Província do Cuanza - Sul, com capital no Sumbe" },
                    { 9, "Província de Malanje, com capital em Malanje" },
                    { 10, "Província da Lunda - Norte, com capital no Dundo" },
                    { 11, "Província da Lunda - Sul, com capital em Saurimo" },
                    { 12, "Província do Moxico, com capital no Luena" },
                    { 13, "Província do Moxico Leste, com capital no Cazombo" },
                    { 14, "Província do Bié, com capital no Cuito" },
                    { 15, "Província do Huambo, com capital no Huambo" },
                    { 16, "Província de Benguela, com capital em Benguela" },
                    { 17, "Província do Namibe, com capital em Moçâmedes" },
                    { 18, "Província da Huíla, com capital no Lubango" },
                    { 19, "Província do Cunene, com capital no Cuanhama" },
                    { 20, "Província do Cubango, com capital em Menongue" },
                    { 21, "Província do Cuando, com capital em Mavinga" }
                });

            migrationBuilder.InsertData(
                table: "Turma",
                columns: new[] { "TurmaID", "ClassRoomID", "ClasseID", "MainTeacher", "NameTurma" },
                values: new object[,]
                {
                    { 1, 1, 1, null, "Turma A" },
                    { 2, 2, 2, null, "Turma B" },
                    { 3, 3, 3, null, "Turma C" },
                    { 4, 4, 4, null, "Turma D" },
                    { 5, 5, 5, null, "Turma E" },
                    { 6, 6, 6, null, "Turma F" },
                    { 7, 7, 7, null, "Turma G" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inscricao_ClasseID",
                table: "Inscricao",
                column: "ClasseID");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricao_FullName",
                table: "Inscricao",
                column: "FullName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inscricao_InscricaoNumber",
                table: "Inscricao",
                column: "InscricaoNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inscricao_PeriodID",
                table: "Inscricao",
                column: "PeriodID");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_BiCedula",
                table: "Matriculas",
                column: "BiCedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_InscricaoID",
                table: "Matriculas",
                column: "InscricaoID");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_MatriculaNumber",
                table: "Matriculas",
                column: "MatriculaNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_ProvinceID",
                table: "Matriculas",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_TurmaID",
                table: "Matriculas",
                column: "TurmaID");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_DisciplineID",
                table: "Teacher",
                column: "DisciplineID");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_PeriodID",
                table: "Teacher",
                column: "PeriodID");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_TurmaID",
                table: "Teacher",
                column: "TurmaID");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_UserID",
                table: "Teacher",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_ClasseID",
                table: "Turma",
                column: "ClasseID");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_ClassRoomID",
                table: "Turma",
                column: "ClassRoomID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Inscricao");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Discipline");

            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "Period");

            migrationBuilder.DropTable(
                name: "ClassRoom");

            migrationBuilder.DropTable(
                name: "Classe");
        }
    }
}
