using System;

namespace Ereoz.Abstractions.MVVM
{
    public interface INavigationManager
    {
        event EventHandler<EventArgs> ViewChanged;

        object Navigate<T>(object sender, params object[] parameters);
        object Navigate(object sender, Type viewOrViewModelType, params object[] parameters);

        AsSingletoneHandler RegisterViewWithViewModel<TView, TViewModel>();
        AsSingletoneHandler RegisterViewWithViewModel(Type view, Type viewModel);

        void AutoRegisterAllViewsWithViewModels();

        T CreateMainWindow<T>();
    }
}
