namespace NetCoreCv.WebApp.Interfaces;
public interface IViewModel<T, U> where T : IViewModel<T, U>
{
    static abstract explicit operator T (U model);

    static abstract explicit operator U (T viewModel);
}
