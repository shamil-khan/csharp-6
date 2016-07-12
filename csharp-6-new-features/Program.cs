using csharp_6.features;
using static System.Console;

namespace csharp_6
{
  class Program
  {
    static void Main(string[] args)
    {
      foreach(var each in FeatureRepository.GetAll())
      {
        WriteLine($"============================ {each.Title} ============================");

        WriteLine("                  =============== Old Style ========================");
        each.DoOldStyle();

        WriteLine("                  =============== New Style ========================");
        each.DoNewStyle();
        WriteLine();
      }

      Write("Press any key to exit...");
      ReadLine();
    }
  }
}