using System;
using System.Collections.Generic;
using static System.Console;

namespace csharp_6.features
{
  class DictionaryInitFeature : IFeature
  {
    string IFeature.Title { get { return "Dicitionay Initialization"; } }

    void IFeature.DoOldStyle()
    {
      var values = new Dictionary<string, string>()
      {
        { "Javed Minadad", "Cricket" },
        { "Jhangir Khan", "Squash" },
        { "Muhammad Ali", "Boxing" }
      };

      foreach (var each in values)
      {
        WriteLine(each.Key + ": " + each.Value);
      }
    }

    void IFeature.DoNewStyle()
    {
      var values = new Dictionary<string, string>()
      {
        ["Javed Minadad"] = "Cricket",
        ["Jhangir Khan"] = "Squash",
        ["Muhammad Ali"] = "Boxing"
      };

      foreach (var each in values)
      {
        WriteLine(each.Key + ": " + each.Value);
      }
    }
  }
}
