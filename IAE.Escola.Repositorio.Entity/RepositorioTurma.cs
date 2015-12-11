using IAE.Escola.Dominio;
using IAE.Escola.Persistencia.Entity.Contex;
using IAE.Repository.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IAE.Escola.Repositorio.Entity
{
    public class RepositorioTurma : EntityGenericRepository<Turma, int>
    {

        public RepositorioTurma()
            : base(new EscolaDbContext())
        {

        }

        public override List<Turma> Selecionar()
        {
            return _contexto.Set<Turma>().Include(p => p.Alunos).ToList();
        }

        public override Turma SelecionarPelaChave(int chave)
        {
            return _contexto.Set<Turma>().Include(path => path.Alunos)
                .Where(w => w.Id == chave).FirstOrDefault();
        }

    }
}
