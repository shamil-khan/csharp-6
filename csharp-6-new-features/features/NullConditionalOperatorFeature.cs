using System.Collections.Generic;
using static System.Console;

namespace csharp_6.features
{
  class NullConditionalOperatorFeature : IFeature
  {
    Person ali = new Person { Name = "Muhammad Ali" };
    Person unknown = new Person();

    string IFeature.Title { get { return "Null Conditional Operator"; } }

    void IFeature.DoNewStyle()
    {
      WriteLine(
        "name: " + (ali?.Name ?? "null") + 
        ", Upper: " + (ali.Name?.ToUpper() ?? "NULL") + 
        ", Length: " + (ali.Name?.Length)
      );
      WriteLine(
        "name: " + (unknown?.Name ?? "null") + 
        ", Upper: " + (unknown.Name?.ToUpper() ?? "NULL") + 
        ", Length: " + (unknown.Name?.Length.ToString() ?? "0")
      );

      List<string> items = null;
      WriteLine(items?[0] ?? "items are null");
    }

    void IFeature.DoOldStyle()
    {
      WriteLine(
        "name: " + (ali.Name != null ? ali.Name : "null") +
        ", Upper: " + (ali.Name != null ? ali.Name.ToUpper() : "NULL") +
        ", Length: " + (ali.Name != null ? ali.Name.Length.ToString() : "0")
      );

      WriteLine(
        "name: " + (unknown.Name != null ? unknown.Name : "null") +
        ", Upper: " + (unknown.Name != null ? unknown.Name.ToUpper() : "NULL") +
        ", Length: " + (unknown.Name != null ? unknown.Name.Length.ToString() : "0")
      );

      List<string> items = null;
      WriteLine(items != null ? items[0] : "items are null");
    }

    class Person
    {
      public string Name { get; set; } = null;
    }
  }
}
