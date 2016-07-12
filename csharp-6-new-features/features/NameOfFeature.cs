using System;
using static System.Console;

namespace csharp_6.features
{
  class NameofFeature : IFeature
  {
    string IFeature.Title { get { return "nameof"; } }

    void IFeature.DoNewStyle()
    {
      Action<string, string> show = (someValue1, changeValue2) =>
      {
        if (someValue1 == null) WriteLine("{0} is null", nameof(someValue1));
        if (changeValue2 == null) WriteLine("{0} is null, after refactoring someValue2 to changeValue2, the message displays the name accordingly.C", nameof(changeValue2));
      };
      show(null, null);
    }

    void IFeature.DoOldStyle()
    {
      Action<string, string> show = (someValue1, changeValue2) =>
      {
        if (someValue1 == null) WriteLine("someValue1 is null");
        if (changeValue2 == null) WriteLine("someValue2 is null. after refactoring someValue2 to changeValue2, the message doesnot display the refactored name.");
      };
      show(null, null);
    }
  }
}
