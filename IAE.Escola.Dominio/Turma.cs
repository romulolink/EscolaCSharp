using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE.Escola.Dominio
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool IsAtivo { get; set; }
        public virtual List<Aluno> Alunos { get; set; }
    }
}
