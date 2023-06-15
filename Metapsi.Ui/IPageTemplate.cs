namespace Metapsi
{
    public interface IPageTemplate<TModel>
    {
        string Render(TModel model);
    }
}