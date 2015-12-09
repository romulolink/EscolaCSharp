using AutoMapper;
using IAE.Escola.Dominio;
using IAE.Escola.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IAE.Escola.Web.AutoMapper
{
    public class PerfilViewModelParaDominio : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<AlunoViewModel, Aluno>();
            Mapper.CreateMap<CursoViewModel, Curso>();
            Mapper.CreateMap<TurmaViewModel, Turma>();
        }
    }
}