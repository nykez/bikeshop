using System.Threading.Tasks;

using frontendapi_bikeshop.Models.account;

namespace frontendapi_bikeshop.Services
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);
    }
}