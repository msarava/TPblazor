using BlazorLeBonCoin;
using BlazorLeBonCoin.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://api-leboncoin-toulouse.azurewebsites.net") });
builder.Services.AddSingleton<LoginService>();
builder.Services.AddScoped<ArticleService>();

await builder.Build().RunAsync();
