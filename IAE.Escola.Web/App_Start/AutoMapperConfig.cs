using AutoMapper;
using IAE.Escola.Dominio;
using IAE.Escola.Web.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IAE.Escola.Web.App_Start
{
    public static class AutoMapperConfig
    {

        public static void Configure()
        {
            Mapper.AddProfile<PerfilDominioParaViewModel>();
            Mapper.AddProfile<PerfilViewModelParaDominio>();
        }
    }
}