using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FluffyFriend.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<FluffyFriend.Models.PostsModel> Posts { get; set; }
        public DbSet<FluffyFriend.Models.UserProfileModel> UserProfiles { get; set; }
        //public DbSet<FluffyFriend.Areas.Identity.Models.ProfileModel> Profile { get; set; }

    }
}
