using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FriendLetter
{
    public static void Main()
  {
    var host = new Main (string {} args)
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .useStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}
