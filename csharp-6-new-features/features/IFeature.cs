namespace csharp_6.features
{
  public interface IFeature
  {
    string Title { get; }
    void DoOldStyle();
    void DoNewStyle();
  }
}
