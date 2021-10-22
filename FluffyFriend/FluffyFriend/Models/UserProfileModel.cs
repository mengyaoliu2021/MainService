using System;
namespace FluffyFriend.Models
{
    public class UserProfileModel
    {
        public UserProfileModel()
        {
        }

        public string Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string pronouns { get; set; }
        public string Website { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        /* 
         * 0: animal lover
         * 1: pet parent
         * 2: breeder
         * 3: vet
         */
        public int UserType { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public bool IsVerified { get; set; }
        public string Photo { get; set; }

    }
}
