using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Core.Repositories;
using Core.Repositories.Implementation;

namespace Web.Installers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes
                .FromAssembly(typeof(IAgentRepository).Assembly)
                .Where(Component.IsInSameNamespaceAs<AgentRepository>())
                .WithService.DefaultInterfaces()
                .LifestyleTransient());
        }
    }
}