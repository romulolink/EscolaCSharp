using IAE.Escola.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IAE.Escola.Web.Controllers
{
    public class ContasController : Controller
    {
      

        // GET: Contad/Create
        public ActionResult Registrar()
        {
            return View("Registrar");
        }

        // POST: Contad/Create
        [HttpPost]
        public ActionResult Registrar(FormCollection collection)
        {
            var IdentityUser = new Identity();


        }

        public ActionResult Login(UsuarioViewModel viewModel)
        {

            if (ModelState.IsValid)
            {

                var userManager = Request
                    .GetOwinContext()
                    .GetUserManager<UserManager<IdentityUser>>();

                var userIdentity = userManager
                    .Find(viewModel.Email, viewModel.Senha);

                if(userIdentity != null)
                {

                    var authManager
                        Request.GetOwinContext().Authentication;
                    var identity =
                        userManager.CreateIdentity(userIdentity, Defaul)
                    
                        authManager.SignIn(new AutenticationProperties
                     {

                        isPersistent = false;

                    }, identity);

                return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View();

            }
        }

        [Authorize]
        public ActionResult Logoff()
        {
            var authManager = Request.GetOwinContext().Authentication;
            authManager.SignOut();
            return RedirectToAction("Index","Home");

        }
        
    }
}
