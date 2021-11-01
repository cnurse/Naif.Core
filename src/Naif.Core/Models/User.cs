using System.Collections.Generic;

namespace Naif.Core.Models
{
    public class User
    {
        public User()
        {
            Created = System.DateTime.MinValue;
            Roles = new List<Role>();
            LastUpdated = System.DateTime.MinValue;
        }
        
        public System.DateTime Created {get; set;}
        
        public string EmailAddress { get; set; }
        
        public bool EmailVerified {get; set; }
        
        public string GivenName {get; set;}
        
        public string Identifier {get; set; }

        public bool IsAuthenticated { get; set; }
        
        public System.DateTime LastUpdated {get; set;}
        
        public string Locale {get; set;}
        
        public string NickName { get; set; }

        public string Name { get; set; }
        
        public string ProfileImage { get; set; }
        
        public IList<Role> Roles { get; set; }
        
        public string Surname {get; set; }
    }
}