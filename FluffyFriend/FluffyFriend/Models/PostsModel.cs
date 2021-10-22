using System;
using System.ComponentModel.DataAnnotations;

namespace FluffyFriend.Models
{
    public class PostsModel
    {
        public PostsModel()
        {
        }

        public string Id { get; set; }
        public string UserId { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        public string Message { get; set; }
        public string Photo { get; set; }
    }
}
