using System;
using System.Threading.Tasks;
using static System.Console;

namespace csharp_6.features
{
  class AwaitInCatchFinallyFeature :IFeature
  {
    string IFeature.Title { get { return "Await in Catch and Finally Block"; } }

    void IFeature.DoNewStyle()
    {
      var t = DoWorkAsync();
      t.Wait();
    }

    void IFeature.DoOldStyle()
    {
      WriteLine("not implemented");
    }

    async Task DoWorkAsync()
    {
      try
      {
        await SomeTaskAsync();
      }
      catch (Exception ex)
      {
        await ShowAsync("catch block - " + ex.Message);
      }
      finally
      {
        await ShowAsync("finally block");
      }
    }

    async Task SomeTaskAsync()
    {
      WriteLine("{0:hh:mm:ss:fff} - Some Task - Started ", DateTime.Now);
      await Task.Delay(3 * 1000);
      WriteLine("{0:hh:mm:ss:fff} - Some Task - Throw Exception", DateTime.Now);
      throw new Exception("some exception");
    }

    async Task ShowAsync(string value)
    {
      Write("{0:hh:mm:ss:fFf} - ", DateTime.Now);
      await Task.Delay(3 * 1000);
      WriteLine("{0} - {1:hh:mm:ss:fFf}", value, DateTime.Now);
    }
  }
}
