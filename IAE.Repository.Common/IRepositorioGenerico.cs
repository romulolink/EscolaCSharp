using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE.Repository.Common
{
    public interface IRepositorioGenerico<TEntidade, TChave> where TEntidade : class
    {
        List<TEntidade> Selecionar();

        TEntidade SelecionarPelaChave(TChave chave);

        void Inserir(TEntidade entidade);

        void Atualizar(TEntidade entidade);

        void Deletar(TEntidade entidade);
    }
}
