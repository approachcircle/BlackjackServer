using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BlackjackServer;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddSignalR();
        builder.Logging.AddFilter("Microsoft.AspNetCore.SignalR", LogLevel.Debug);
        builder.Logging.AddFilter("Microsoft.AspNetCore.Http.Connections", LogLevel.Debug);
        var app = builder.Build();
        app.MapHub<OnlinePlayHub>("/online");
        app.Run();
    }
}