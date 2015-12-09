using IAE.Escola.Dominio;
using IAE.Escola.Persistencia.Entity.Contex;
using IAE.Repository.Entity.Common;

namespace IAE.Escola.Repositorio.Entity
{
    public class RepositorioCurso : EntityGenericRepository<Curso, long>
    {
        public RepositorioCurso()
       :
            base(new EscolaDbContext())
        {

        }

    }
}
