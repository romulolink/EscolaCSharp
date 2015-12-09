using IAE.Escola.Dominio;
using IAE.Escola.Persistencia.Entity.Contex;
using IAE.Repository.Entity.Common;

namespace IAE.Escola.Repositorio.Entity
{
    public class RepositorioAluno : EntityGenericRepository<Aluno, long>
    {
        public RepositorioAluno() 
        :
            base(new EscolaDbContext())
        { 


        }
    }
}
