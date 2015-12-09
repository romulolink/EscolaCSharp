using IAE.Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace IAE.Repository.Entity.Common
{
    public class EntityGenericRepository<TEntidade, TChave> : IRepositorioGenerico<TEntidade, TChave>
        where TEntidade : class
    {
        protected DbContext _contexto;


        public EntityGenericRepository(DbContext contexto)
        {
            _contexto = contexto;
        }

        public virtual void Atualizar(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public virtual void Deletar(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Deleted;
            _contexto.SaveChanges();
        }

        public virtual void Inserir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Add(entidade);
            _contexto.SaveChanges();
        }

        public virtual List<TEntidade> Selecionar()
        {
            return _contexto.Set<TEntidade>().ToList();
        }

        public virtual TEntidade SelecionarPelaChave(TChave chave)
        {
            return _contexto.Set<TEntidade>().Find(chave);
        }
    }


}
