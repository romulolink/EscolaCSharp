using IAE.Escola.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE.Escola.Persistencia.Entity.Contex
{
    public class EscolaDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlunoTypeConfiguration());
            modelBuilder.Configurations.Add(new CursoTypeConfiguration());
        }
    }
}
