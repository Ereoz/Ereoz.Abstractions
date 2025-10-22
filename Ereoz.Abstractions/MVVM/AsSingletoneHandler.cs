namespace Ereoz.Abstractions.MVVM
{
    public delegate void AsSingletoneHandler();

    public static class AsSingletoneHandlerExtensions
    {
        /// <summary>
        /// Обёртка для метода Invoke.
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="obj"></param>
        public static void AsSingletone(this AsSingletoneHandler handler) =>
            handler?.Invoke();
    }
}
