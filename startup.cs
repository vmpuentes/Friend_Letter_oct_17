using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FriendLetter
{

  public class Startup
{
  public Startup(IHostingEnvironment env)
  {
    var builder = new ConfigurationsBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddEnvironmentVariables();
      Congifuration = builder.Build();
  }

  public IConfigurationRoot Configuration { get; }

  public void ConfigureServices(IServiceCollection services)
  {
    services.AddMvc();
  }

  public void Configure(IapplicationBuilder app)
  {
    app.UseDeveloperExceptionPage();
    app.UseStaticFiles();
    app.UseMvc(routes=>
    {
      routes.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}");        
      });
    }
  }
}
