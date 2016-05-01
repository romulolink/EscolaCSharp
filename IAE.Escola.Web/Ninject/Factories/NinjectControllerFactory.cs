using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace IAE.Escola.Web.Ninject.Factories
{
    class NinjectControllerFactory : DefaultControllerFactory
    {

        private IKernel _kernel;

        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : _kernel.Get(controllerType) as IController;
        }

        private void AddBindings()
        {
            _kernel.Load(System.Reflection.Assembly.GetExecutingAssembly());
        }
    }
}
