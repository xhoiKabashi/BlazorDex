using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorDex;
using BlazorDex.Util;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register the root components
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register HttpClient with a base address
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://kreshnik-api.onrender.com") });

// Register other services
builder.Services.AddScoped<HeroClient>();
builder.Services.AddScoped<HeroStateService>();
builder.Services.AddScoped<GameAnimationService>();
builder.Services.AddScoped<GameLogic>();

await builder.Build().RunAsync();

// builder.Services.AddScoped(sp => new HeroClient(new HttpClient { BaseAddress = new Uri("http://localhost:5024/") }));