﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE.Escola.Dominio
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

    }

}
