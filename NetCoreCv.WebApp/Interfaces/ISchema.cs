namespace NetCoreCv.WebApp.Interfaces;
public interface ISchema<U, T> where U : ISchema<U, T>
{
    public int Id { get; }

    static abstract explicit operator T (U model);

    static abstract explicit operator U (T viewModel);
}