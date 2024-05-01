using AuctionBlazorWeb;
using AuctionBlazorWeb.Helpers;
using AuctionBlazorWeb.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(Constants.prodDevelopmentUrl) });
builder.Services.AddSingleton<WalletService>();

await builder.Build().RunAsync();
