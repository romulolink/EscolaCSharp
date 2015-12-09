using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IAE.Escola.Web.Models
{
    public class CursoViewModel
    {
      
        public long Id { get; set; }

        [DisplayName("Nome do Curso")]
        [Required(ErrorMessage = "O nome do curso é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome do curso só pode ter até 100 caracteres")]
        public string Nome { get; set; }

        [DisplayName("Ementa")]
        [Required(ErrorMessage = "a ementa é obrigarória")]
        public string Ementa { get; set; }

        [DisplayName("Carga Horária")]
        [Required(ErrorMessage = "O campo Carga horária é obrigatório")]
        public int CargaHoraria { get; set; }

        [Required(ErrorMessage = "O campo isAtivo é obrigatório")]
        [DisplayName("Está ativo")]
        public bool isAtivo { get; set; }

      
    }
}