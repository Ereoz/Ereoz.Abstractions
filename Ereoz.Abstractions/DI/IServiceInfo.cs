using System;

namespace Ereoz.Abstractions.DI
{
    public interface IServiceInfo
    {
        Type ServiceType { get; set; }
        object Resolve();
        void AsSingletone();
        void AsTransient();
    }
}
