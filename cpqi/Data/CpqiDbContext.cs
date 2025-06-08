using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cpqi.Models;
using cpqi.Data.Configurations;

namespace cpqi.Data
{
    public class CpqiDbContext: DbContext
    {
        public CpqiDbContext(DbContextOptions<CpqiDbContext> options) : base(options){}
        public CpqiDbContext() { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ClasseConfiguration());
            modelBuilder.ApplyConfiguration(new PeriodConfiguration());
            modelBuilder.ApplyConfiguration(new ClassRoomConfiguration());
            modelBuilder.ApplyConfiguration(new TurmaConfiguration());
            modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new InscricaoConfiguration());
            modelBuilder.ApplyConfiguration(new MatriculaConfiguration());
        }
    }
}
