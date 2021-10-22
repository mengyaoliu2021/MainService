using System;
namespace FluffyFriend.Models
{
    public class FollowModel
    {
        public FollowModel()
        {
        }

        public string Id { get; set; }
        public string UserId { get; set; }
        public string FollowingUserId { get; set; }
    }
}
