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
    }
}
