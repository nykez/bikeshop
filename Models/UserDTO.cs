using System.Collections.Generic;

namespace frontendapi_bikeshop.Models
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}