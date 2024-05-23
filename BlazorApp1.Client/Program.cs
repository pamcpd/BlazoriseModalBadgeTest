using Blazorise;
using Blazorise.Icons.FontAwesome;
using Blazorise.Tailwind;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp1.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Add Blazorise
            builder.Services.AddBlazorise()
                .AddTailwindProviders()
                .AddFontAwesomeIcons();

            await builder.Build().RunAsync();
        }
    }
}
