using System;
using static System.Console;

namespace csharp_6.features
{
  class AutoPropertyIntFeature : IFeature
  {
    string IFeature.Title { get { return "Auto-Property Initialization"; } }
    void IFeature.DoNewStyle()
    {
      var value = new ProductOldStyle();
      WriteLine(value.ProductID);
    }

    void IFeature.DoOldStyle()
    {
      var value = new ProductNewStyle();
      WriteLine(value.ProductID);
    }

    class ProductOldStyle
    {
      public Guid ProductID { get; set; }
      public ProductOldStyle()
      {
        ProductID = Guid.NewGuid();
      }
    }

    class ProductNewStyle
    {
      public Guid ProductID { get; set; } = Guid.NewGuid();
    }

  }
}
