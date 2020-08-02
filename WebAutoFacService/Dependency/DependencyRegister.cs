using Autofac;
using WebAutoFacService.Service;

namespace WebAutoFacService.Dependency
{
    public class DependencyRegister : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TestService>().As<ITestService>().InstancePerLifetimeScope();
        }

    }
}
