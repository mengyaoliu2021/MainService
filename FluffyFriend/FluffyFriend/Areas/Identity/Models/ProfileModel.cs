using System;
namespace FluffyFriend.Areas.Identity.Models
{
    public class ProfileModel : LoginModel
    {
        public ProfileModel()
        {
        }

        public string Name { get; set; }
        public string Pronouns { get; set; } 
        public string Website { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public int UserType { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public bool IsVerified { get; set; }
        public string Photo { get; set; }
    }
}
