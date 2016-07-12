using System;
using static csharp_6.features.UsingStaticFeature.SomeStaticClass;

namespace csharp_6.features
{
  class UsingStaticFeature : IFeature
  {
    string IFeature.Title { get { return "Using Static"; } }

    void IFeature.DoNewStyle()
    {
      HelloUsingStatic();
    }

    void IFeature.DoOldStyle()
    {
      Console.WriteLine("Hello World!");
    }

    public static class SomeStaticClass
    {
      public static void HelloUsingStatic()
      {
        Console.WriteLine("Hello Using Static!");
      }
    }

  }
}
