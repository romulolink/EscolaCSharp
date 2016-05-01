using IAE.Escola.Dominio;
using IAE.Escola.Repositorio.Entity;
using IAE.Repository.Common;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE.Escola.Web.Ninject.Modules
{
    public class RepositorioAlunoNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepositorioGenerico<Aluno, long>>().To<RepositorioAluno>();
        }
    }
}
