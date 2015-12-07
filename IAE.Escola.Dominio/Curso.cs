using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE.Escola.Dominio
{
    public class Curso
    {

        public long Id { get; set; }
        public string Nome { get; set; }
        public string Ementa { get; set; }
        public int CargaHoraria { get; set; }
        public bool isAtivo { get; set; }

    }
}
