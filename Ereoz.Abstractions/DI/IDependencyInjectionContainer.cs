using System;
using System.Collections.Generic;

namespace Ereoz.Abstractions.DI
{
    public interface IDependencyInjectionContainer
    {
        IServiceInfo Register<Service>();
        IServiceInfo Register<Service>(Func<object> factory);

        IServiceInfo Register<Contract, Implementation>();       
        IServiceInfo Register<Contract, Implementation>(Func<object> factory);

        IServiceInfo Register(Type service);
        IServiceInfo Register(Type service, Func<object> factory);

        IServiceInfo Register(Type contract, Type implementation);
        IServiceInfo Register(Type contract, Type implementation, Func<object> factory);

        Service Resolve<Service>();
        Service Resolve<Service>(string name);
        IEnumerable<Service> ResolveAllImplementations<Service>();

        object Resolve(Type service);
        object Resolve(Type service, string name);        
        IEnumerable<object> ResolveAllImplementations(Type service);
    }
}
