using Microsoft.Practices.Unity;
using MS.Challenge.ApplicationService;
using MS.Challenge.Domain.Interfaces.Services;

namespace MS.Challenge.CrossCutting.IOC
{
    public static class DependencyRegister
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<IAuthApplicationService, AuthApplicationService>(new HierarchicalLifetimeManager());
        }
    }
}
