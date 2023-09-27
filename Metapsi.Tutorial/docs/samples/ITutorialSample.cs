namespace Metapsi.Tutorial.Samples;

public interface ITutorialSample
{

}

public abstract class TutorialSample<TModel> : ITutorialSample
{
    public abstract TModel GetSampleData();
}