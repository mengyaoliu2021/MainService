// <auto-generated />
using System;
using FluffyFriend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FluffyFriend.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("CreateIdentitySchema")]
    partial class CreateIdentitySchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("FluffyFriend.Models.UserProfileModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(int.MaxValue);

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(int.MaxValue);

                b.Property<string>("Name")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(int.MaxValue);

                b.Property<string>("Pronouns")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

                b.Property<string>("Website")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(300);

                b.Property<string>("FacebookLink")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(300);

                b.Property<string>("InstagramLink")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(300);

                b.Property<int>("UserType")
                    .HasColumnType("INTEGER");

                b.Property<string>("Country")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(300);

                b.Property<string>("State")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(300);

                b.Property<string>("City")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(300);

                b.Property<int>("ZipCode")
                    .HasColumnType("INTEGER");

                b.Property<bool>("IsVerified")
                    .HasColumnType("BIT")
                    .HasMaxLength(300);

                b.Property<string>("Photo")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(300);


                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("UserProfiles");
            });

            modelBuilder.Entity("FluffyFriend.Models.PostsModel", b =>
            {
                b.Property<string>("Id")
                    .ValueGeneratedOnAdd()
                    .IsRequired()
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(int.MaxValue);

                b.Property<string>("CreatedDate")
                    .HasColumnType("DATETIME");

                b.Property<string>("Message")
                    .HasColumnType("VARCHAR");

                b.Property<string>("Photo")
                    .HasColumnType("VARCHAR");

                b.HasKey("Id");

                b.ToTable("Posts");
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100);

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(int.MaxValue);

                b.Property<string>("Name")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(int.MaxValue);

                b.Property<string>("NormalizedName")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(300);

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasName("RoleNameIndex");

                b.ToTable("AspNetRoles");
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("VARCHAR");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("VARCHAR");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("BIT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("BIT");

                    b.Property<string>("LockoutEnd")
                        .HasColumnType("DATETIME");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(300);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(300);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("VARCHAR");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("BIT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("BIT");

                    b.Property<string>("UserName")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("VARCHAR");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("VARCHAR");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(150);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(150);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("VARCHAR");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.Property<string>("RoleId")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(100);

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.Property<string>("LoginProvider")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.Property<string>("Value")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(int.MaxValue);

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}