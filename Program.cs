using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FriendLetter
{
    public class Program
  {
      publice static void Main(string{} args)
      {
    var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .useStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}
