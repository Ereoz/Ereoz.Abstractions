using System;

namespace Ereoz.Abstractions.DI
{
    public interface IServiceInfo
    {
        Type ServiceType { get; }
        Func<object> Factory { get; }
        bool IsSingletone { get; }
        object SingletoneInstance { get; set; }
        void AsSingletone();
        void AsTransient();
    }
}
