using System;

namespace Ereoz.Abstractions.MVVM
{
    public interface INavigationManager
    {
        event EventHandler<EventArgs> ViewChanged;

        object Navigate<T>(object sender, params object[] parameters);
        object Navigate(object sender, Type viewOrViewModelType, params object[] parameters);
    }
}
