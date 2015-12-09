using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IAE.Escola.Web.Models
{
    public class AlunoViewModel
    {
      
        public long Id { get; set; }
        [DisplayName("Nome do Aluno")]
        [Required(ErrorMessage = "O nome do aluno é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome do aluno só pode ter até 100 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="o número da matricula é obrigatório")]
        public int Matricula { get; set; }

        [DisplayName("Telefone")]
        [MaxLength(15, ErrorMessage ="Telefone inválido")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "O email é inválido")]
        [MaxLength(50, ErrorMessage = "O email pode ter no máximo 50 caracteres")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Dada inválida")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        [DisplayName("Data de nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}