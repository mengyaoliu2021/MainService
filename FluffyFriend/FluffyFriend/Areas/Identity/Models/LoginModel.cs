﻿using System;
namespace FluffyFriend.Areas.Identity.Models
{
    public class LoginModel
    {

        public Guid UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
