using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(IAE.Escola.Web.Startup))]

namespace IAE.Escola.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            app.CreatePerOwinContext(() => new EscolaIdentityContext());
            app.CreatePerOwinContext(() =>
            new UserManager<IdentityUser>(new UserStore<IdentityUser>(new EscolaIdentityContext())));


            app.UseCookieAuthentication(new CookieAuthenticationOptions {

                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie = "teste";
                LoginPath = new PathString("Contas/Login");
            })
        }
    }
}
