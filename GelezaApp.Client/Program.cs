using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// This tells the app how to run in the browser
await builder.Build().RunAsync();