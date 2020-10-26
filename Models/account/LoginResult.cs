namespace frontendapi_bikeshop.Models.account
{
    public class LoginResult
    {
        public bool Successful { get; set; }
        public string message { get; set; }
        public string token { get; set; }
    }
}