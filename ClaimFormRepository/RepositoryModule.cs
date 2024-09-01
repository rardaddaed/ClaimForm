using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace ClaimFormRepository
{
  public class RepositoryModule : Autofac.Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      var asm = Assembly.GetExecutingAssembly();
      builder.RegisterAssemblyTypes(asm)
        .Where(x => x.Name.EndsWith("Repository"))
        .AsImplementedInterfaces()
        .InstancePerLifetimeScope();

      base.Load(builder);
    }
  }
}
