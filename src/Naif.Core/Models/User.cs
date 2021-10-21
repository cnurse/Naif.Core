using System.Collections.Generic;

namespace Naif.Core.Models
{
    public class User
    {
        public User()
        {
            Roles = new List<Role>();
        }
        
        public string EmailAddress { get; set; }

        public bool IsAuthenticated { get; set; }
        
        public string Name { get; set; }
        
        public string ProfileImage { get; set; }
        
        public IList<Role> Roles { get; set; }
    }
}