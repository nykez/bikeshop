using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazored.Toast;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;
using frontendapi_bikeshop.Services;

namespace frontendapi_bikeshop
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://se2-database.azurewebsites.net") });
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticatedStateProvider>();
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddSweetAlert2();
            builder.Services.AddBlazoredToast();

            await builder.Build().RunAsync();
        }
    }
}
