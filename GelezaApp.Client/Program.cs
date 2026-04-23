using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
using Microsoft.EntityFrameworkCore;
using GelezaApp.Data;

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=Geleza.db"));

await builder.Build().RunAsync();
