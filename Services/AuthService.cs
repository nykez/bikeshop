using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using frontendapi_bikeshop.Models.account;
using Microsoft.AspNetCore.Components.Authorization;

namespace frontendapi_bikeshop.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ILocalStorageService _loclStorage;
        public AuthService(HttpClient httpClient, AuthenticationStateProvider authStateProvider, ILocalStorageService loclStorage)
        {
            _loclStorage = loclStorage;
            _authStateProvider = authStateProvider;
            _httpClient = httpClient;
        }

        public async Task<RegisterResult> Register(RegisterModel registerModel)
        {

            var registerJson = JsonSerializer.Serialize(registerModel);
            var response = await _httpClient.PostAsync("api/auth/register", new StringContent(registerJson, Encoding.UTF8, "application/json"));
            var registerResult = JsonSerializer.Deserialize<RegisterResult>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions {PropertyNameCaseInsensitive = true});

            return registerResult;
        }

        public async Task<LoginResult> Login(LoginModel loginModel)
        {
            var loginasJson = JsonSerializer.Serialize(loginModel);
            var response = await _httpClient.PostAsync("api/auth/login", new StringContent(loginasJson, Encoding.UTF8, "application/json"));
            var loginResult = JsonSerializer.Deserialize<LoginResult>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
            
            if ( (int) response.StatusCode == 200)
            {
                loginResult.Successful = true;
            }
            else
            {
                loginResult.Successful = false;
            }

            if (!response.IsSuccessStatusCode)
            {
                return loginResult;
            }

            await _loclStorage.SetItemAsync("authToken", loginResult.token);
            ((ApiAuthenticatedStateProvider)_authStateProvider).MarkUserAsAuthenticated("chiing cong!");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResult.token);

            return loginResult;
        }

        public async Task Logout()
        {
            await _loclStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticatedStateProvider)_authStateProvider).MarkUserLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

    }
}