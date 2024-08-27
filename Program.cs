using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorDex;
using BlazorDex.Util;

 
var builder = WebAssemblyHostBuilder.CreateDefault(args);
// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<HeroClient>(); // Correct registration of HeroClient
builder.Services.AddScoped<HeroStateService>();
builder.Services.AddScoped<GameAnimationService>();
builder.Services.AddScoped<GameLogic>();
// builder.Services.AddScoped<IActionExecutor>();



builder.Services.AddSingleton<HeroStateService>();
// builder.Services.AddScoped(sp => new HeroClient(new HttpClient { BaseAddress = new Uri("https://kreshnik-api.onrender.com") }));
builder.Services.AddScoped(sp => new HeroClient(new HttpClient { BaseAddress = new Uri("http://localhost:5024/") }));





await builder.Build().RunAsync();
