using IAE.Escola.Dominio;
using IAE.Escola.Persistencia.Entity.Contex;
using IAE.Repository.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE.Escola.Repositorio.Entity
{
    public class RepositorioTurma : EntityGenericRepository<Turma, int>
    {

        public RepositorioTurma()
            : base(new EscolaDbContext())
        {

        }

    }
}
