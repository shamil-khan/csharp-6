using static System.Console;

namespace csharp_6.features
{
  class StringInterpolationFeature : IFeature
  {
    string firstName = "Muhammad";
    string lastName = "Ali";

    string IFeature.Title { get { return "String Interpolation"; } }

    void IFeature.DoNewStyle()
    {
      WriteLine($"{firstName} {lastName} is my name!");
    }

    void IFeature.DoOldStyle()
    {
      WriteLine("Name : " + firstName + " " + lastName);
      WriteLine("Name : {0} {1}", firstName, lastName);
    }
  }
}
