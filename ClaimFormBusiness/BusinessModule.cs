using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace ClaimFormBusiness
{
    public class BusinessModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var asm = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(asm)
              .Where(x => x.Name.EndsWith("Service")
              || x.Name.EndsWith("Validator")
              || x.Name.EndsWith("Handler"))
              .AsImplementedInterfaces()
              .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
