using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE.Escola.Web.Models
{
    public class UsuarioViewModel
    {


        [Required(ErrorMessage = "O nome é obrigatorio")]
        [MaxLength(20, ErrorMessage = "O nome da turma pode ter no máximo 20 caracteres")]
        [DisplayName("Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "A flag de ativação é obrigatória")]
        [MinLength(6)]
        [MaxLength(6)]
        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }



    }
}
