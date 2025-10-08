using System;

namespace Ereoz.Abstractions.DI
{
    public interface IServiceInfo
    {
        Type ServiceType { get; }
        object Resolve();
        void AsSingletone();
        void AsTransient();
    }
}
