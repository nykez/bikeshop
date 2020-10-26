using System.Collections.Generic;

namespace frontendapi_bikeshop.Models.account
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}