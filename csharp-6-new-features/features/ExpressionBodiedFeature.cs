using static System.Console;

namespace csharp_6.features
{
  class ExpressionBodiedFeature : IFeature
  {
    string firstName = "Muhammad";
    string lastName = "Ali";

    //not possible
    //string FullNameOldStyle = firstName + lastName;
    string GetFullNameOldStyle()
    {
      return firstName + " " + lastName;
    }

    string FullName => firstName + " " + lastName;
    string GetFullNameNewStyle() => firstName + " " + lastName;

    string IFeature.Title { get { return "Expression Bodied Function and Property"; } }

    void IFeature.DoNewStyle()
    {
      WriteLine($"{FullName} is my name!");
      WriteLine($"{GetFullNameNewStyle()} is my name!");
    }

    void IFeature.DoOldStyle()
    {
      WriteLine($"{GetFullNameOldStyle()} is my name!");
    }

  }
}
