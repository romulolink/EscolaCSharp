using IAE.Escola.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IAE.Escola.Web.Models
{
    public class TurmaViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(20, ErrorMessage = "O nome da turma pode ter no máximo 20 caracteres")]
        [DisplayName("Nome da turma")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A flag de ativação é obrigatória")]
        [DisplayName("Turma ativa?")]
        public bool IsAtivo { get; set; }

        public List<AlunoViewModel> Alunos { get; set;  }
    }
}