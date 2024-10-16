﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using portal_job_FN.Data;

#nullable disable

namespace portal_job_FN.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240418151533_huha")]
    partial class huha
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("portal_job_FN.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("JobLocationId")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("company_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("create_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("date_of_birth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hard_skills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("introduce_company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("introduce_yourself")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("is_active")
                        .HasColumnType("int");

                    b.Property<int>("location_id")
                        .HasColumnType("int");

                    b.Property<string>("mobile_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("poisition_user")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("position_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soft_skills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobLocationId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("portal_job_FN.Models.ApplyJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("applicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("application_userId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("companyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_noCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cover_letter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("create_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("emailCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("post_JobId")
                        .HasColumnType("int");

                    b.Property<DateTime>("update_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("url_cv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("applicationUserId");

                    b.HasIndex("post_JobId");

                    b.ToTable("apply_Jobs");
                });

            modelBuilder.Entity("portal_job_FN.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MajorId")
                        .HasColumnType("int");

                    b.Property<string>("applicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("end_date")
                        .HasColumnType("datetime2");

                    b.Property<float?>("gpa")
                        .HasColumnType("real");

                    b.Property<DateTime?>("start_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("universityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MajorId");

                    b.HasIndex("applicationUserId");

                    b.HasIndex("universityId");

                    b.ToTable("educations");
                });

            modelBuilder.Entity("portal_job_FN.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("experience_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("experience");
                });

            modelBuilder.Entity("portal_job_FN.Models.JobLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("province_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("job_location");
                });

            modelBuilder.Entity("portal_job_FN.Models.Major", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("major_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("majors");
                });

            modelBuilder.Entity("portal_job_FN.Models.PostJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("applicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("apply_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("benefit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("create_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("detail_location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employmentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("experienceId")
                        .HasColumnType("int");

                    b.Property<int?>("is_active")
                        .HasColumnType("int");

                    b.Property<int?>("job_LocationId")
                        .HasColumnType("int");

                    b.Property<string>("job_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("job_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("majorId")
                        .HasColumnType("int");

                    b.Property<string>("required_skill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("salary_max")
                        .HasColumnType("int");

                    b.Property<int?>("salary_min")
                        .HasColumnType("int");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("applicationUserId");

                    b.HasIndex("experienceId");

                    b.HasIndex("job_LocationId");

                    b.HasIndex("majorId");

                    b.ToTable("post_Jobs");
                });

            modelBuilder.Entity("portal_job_FN.Models.PostJobImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("post_JobId")
                        .HasColumnType("int");

                    b.Property<string>("post_image_url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("post_JobId");

                    b.ToTable("post_Jobs_images");
                });

            modelBuilder.Entity("portal_job_FN.Models.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("university_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("universities");
                });

            modelBuilder.Entity("portal_job_FN.Models.UserImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("applicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("applicationUser_image_url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("applicationUserId");

                    b.ToTable("company_image");
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
                    b.HasOne("portal_job_FN.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("portal_job_FN.Models.ApplicationUser", null)
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

                    b.HasOne("portal_job_FN.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("portal_job_FN.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("portal_job_FN.Models.ApplicationUser", b =>
                {
                    b.HasOne("portal_job_FN.Models.JobLocation", null)
                        .WithMany("applicationUsers")
                        .HasForeignKey("JobLocationId");
                });

            modelBuilder.Entity("portal_job_FN.Models.ApplyJob", b =>
                {
                    b.HasOne("portal_job_FN.Models.ApplicationUser", "applicationUser")
                        .WithMany("apply_Jobs")
                        .HasForeignKey("applicationUserId");

                    b.HasOne("portal_job_FN.Models.PostJob", "post_Job")
                        .WithMany("applyJobs")
                        .HasForeignKey("post_JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("applicationUser");

                    b.Navigation("post_Job");
                });

            modelBuilder.Entity("portal_job_FN.Models.Education", b =>
                {
                    b.HasOne("portal_job_FN.Models.Major", "Major")
                        .WithMany("educations")
                        .HasForeignKey("MajorId");

                    b.HasOne("portal_job_FN.Models.ApplicationUser", "applicationUser")
                        .WithMany("educations")
                        .HasForeignKey("applicationUserId");

                    b.HasOne("portal_job_FN.Models.University", "university")
                        .WithMany("educations")
                        .HasForeignKey("universityId");

                    b.Navigation("Major");

                    b.Navigation("applicationUser");

                    b.Navigation("university");
                });

            modelBuilder.Entity("portal_job_FN.Models.PostJob", b =>
                {
                    b.HasOne("portal_job_FN.Models.ApplicationUser", "applicationUser")
                        .WithMany("post_Jobs")
                        .HasForeignKey("applicationUserId");

                    b.HasOne("portal_job_FN.Models.Experience", "experience")
                        .WithMany("post_Jobs")
                        .HasForeignKey("experienceId");

                    b.HasOne("portal_job_FN.Models.JobLocation", "job_Location")
                        .WithMany("post_Jobs")
                        .HasForeignKey("job_LocationId");

                    b.HasOne("portal_job_FN.Models.Major", "major")
                        .WithMany("post_jobs")
                        .HasForeignKey("majorId");

                    b.Navigation("applicationUser");

                    b.Navigation("experience");

                    b.Navigation("job_Location");

                    b.Navigation("major");
                });

            modelBuilder.Entity("portal_job_FN.Models.PostJobImage", b =>
                {
                    b.HasOne("portal_job_FN.Models.PostJob", "post_Job")
                        .WithMany("post_Job_Images")
                        .HasForeignKey("post_JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("post_Job");
                });

            modelBuilder.Entity("portal_job_FN.Models.UserImage", b =>
                {
                    b.HasOne("portal_job_FN.Models.ApplicationUser", "applicationUser")
                        .WithMany("company_Images")
                        .HasForeignKey("applicationUserId");

                    b.Navigation("applicationUser");
                });

            modelBuilder.Entity("portal_job_FN.Models.ApplicationUser", b =>
                {
                    b.Navigation("apply_Jobs");

                    b.Navigation("company_Images");

                    b.Navigation("educations");

                    b.Navigation("post_Jobs");
                });

            modelBuilder.Entity("portal_job_FN.Models.Experience", b =>
                {
                    b.Navigation("post_Jobs");
                });

            modelBuilder.Entity("portal_job_FN.Models.JobLocation", b =>
                {
                    b.Navigation("applicationUsers");

                    b.Navigation("post_Jobs");
                });

            modelBuilder.Entity("portal_job_FN.Models.Major", b =>
                {
                    b.Navigation("educations");

                    b.Navigation("post_jobs");
                });

            modelBuilder.Entity("portal_job_FN.Models.PostJob", b =>
                {
                    b.Navigation("applyJobs");

                    b.Navigation("post_Job_Images");
                });

            modelBuilder.Entity("portal_job_FN.Models.University", b =>
                {
                    b.Navigation("educations");
                });
#pragma warning restore 612, 618
        }
    }
}
