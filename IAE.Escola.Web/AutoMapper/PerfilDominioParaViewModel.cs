using AutoMapper;
using IAE.Escola.Web;
using IAE.Escola.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAE.Escola.Dominio
{
    class PerfilDominioParaViewModel : Profile
    {
       protected override   void Configure(){

            Mapper.CreateMap<Aluno, AlunoViewModel>();
            Mapper.CreateMap<Curso, CursoViewModel>();
            Mapper.CreateMap<Turma, TurmaViewModel>();

        }
    }

}
