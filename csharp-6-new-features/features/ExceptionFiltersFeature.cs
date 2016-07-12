using System;
using static System.Console;

namespace csharp_6.features
{
  class ExceptionFiltersFeature : IFeature
  {
    string IFeature.Title { get { return "Exception Filters"; } }

    void IFeature.DoNewStyle()
    {
      var code = 404;
      Write("HTTP Error: ");

      try
      {
        throw new Exception(code.ToString());
      }
      catch (Exception ex) when (ex.Message.Equals("400"))
      {
        Write("Bad Request");
      }
      catch (Exception ex) when (ex.Message.Equals("401"))
      {
        Write("Unauthorized");
      }
      catch (Exception ex) when (ex.Message.Equals("402"))
      {
        Write("Payment Required");
      }
      catch (Exception ex) when (ex.Message.Equals("403"))
      {
        Write("Forbidden");
      }
      catch (Exception ex) when (ex.Message.Equals("404"))
      {
        Write("Not Found");
      }
    }

    void IFeature.DoOldStyle()
    {
      var code = 404;
      Write("HTTP Error: ");

      try
      {
        throw new Exception(code.ToString());
      }
      catch (Exception ex)
      {
        if (ex.Message.Equals("500"))
          Write("Bad Request");
        else if (ex.Message.Equals("401"))
          Write("Unauthorized");
        else if (ex.Message.Equals("402"))
          Write("Payment Required");
        else if (ex.Message.Equals("403"))
          Write("Forbidden");
        else if (ex.Message.Equals("404"))
          Write("Not Found");
      }
    }

  }
}
