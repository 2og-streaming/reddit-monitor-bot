using System;
using Microsoft.Extensions.Hosting;

namespace RedditMonitorBot
{
  class Program
  {
    static void Main(string[] args)
    {
      var host = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
            {
              
            }).Build();

      host.Run();
    }
  }
}
