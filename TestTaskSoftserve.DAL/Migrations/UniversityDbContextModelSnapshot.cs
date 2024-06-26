﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestTaskSoftserve.DAL.Database;

#nullable disable

namespace TestTaskSoftServe.DAL.Migrations
{
    [DbContext(typeof(UniversityDbContext))]
    partial class UniversityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<Guid>("CoursesId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("StudentsId")
                        .HasColumnType("char(36)");

                    b.HasKey("CoursesId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("CourseTeacher", b =>
                {
                    b.Property<Guid>("CoursesId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TeachersId")
                        .HasColumnType("char(36)");

                    b.HasKey("CoursesId", "TeachersId");

                    b.HasIndex("TeachersId");

                    b.ToTable("CourseTeacher");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("70a0ed61-be00-4372-93a1-7e36d7a0af76"),
                            RoleId = new Guid("1b0ba6d9-bf8f-46a6-89b4-0a5ce1661fa1")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TestTaskSoftServe.DAL.Entities.User.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1b0ba6d9-bf8f-46a6-89b4-0a5ce1661fa1"),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("16a2491a-d4e4-4816-8c16-26cfa91df356"),
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("TestTaskSoftServe.DAL.Entities.User.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PersonName")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RefreshTokenExpirationDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("70a0ed61-be00-4372-93a1-7e36d7a0af76"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c4e29003-d057-43d2-a12c-fba1e30a4c89",
                            Email = "Admin",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEI67HUJrYUUv74dFbtooGnlCA/GjWiFpuRZKOkswzcXI2tm/bn01ERB7XIE9AM3QjA==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpirationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "68c0c738-25cd-4545-bbfc-a69ab111002d",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("TestTaskSoftserve.DAL.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ea8f8a96-bd6c-4663-9a56-4dab8c0c4fb0"),
                            Description = "Description 1",
                            Title = "Course 1"
                        },
                        new
                        {
                            Id = new Guid("af8cdace-e2fd-482e-a038-ab2b0ba951eb"),
                            Description = "Description 2",
                            Title = "Course 2"
                        },
                        new
                        {
                            Id = new Guid("5cb013ae-0ac2-456c-924c-1b2001fb5a78"),
                            Description = "Description 3",
                            Title = "Course 3"
                        },
                        new
                        {
                            Id = new Guid("f4c59848-f229-41ab-b78f-0fa811ac22c9"),
                            Description = "Description 4",
                            Title = "Course 4"
                        },
                        new
                        {
                            Id = new Guid("b8df8e9a-c93a-4f41-a116-dfcb6605652f"),
                            Description = "Description 5",
                            Title = "Course 5"
                        },
                        new
                        {
                            Id = new Guid("fe5b4947-cf26-41d6-9603-a166d7c06017"),
                            Description = "Description 6",
                            Title = "Course 6"
                        },
                        new
                        {
                            Id = new Guid("9ed56794-fd3d-41ff-93fb-51b39c5e12d8"),
                            Description = "Description 7",
                            Title = "Course 7"
                        },
                        new
                        {
                            Id = new Guid("674461f7-3ddd-4f8a-9265-dd711de014d3"),
                            Description = "Description 8",
                            Title = "Course 8"
                        },
                        new
                        {
                            Id = new Guid("6ab614cd-3131-4bdc-9119-f21943020ed4"),
                            Description = "Description 9",
                            Title = "Course 9"
                        },
                        new
                        {
                            Id = new Guid("86066ef7-0e03-43c7-8430-23f2a453935c"),
                            Description = "Description 10",
                            Title = "Course 10"
                        },
                        new
                        {
                            Id = new Guid("b5e7fed5-016b-4432-ab8f-66b253d23f18"),
                            Description = "Description 11",
                            Title = "Course 11"
                        },
                        new
                        {
                            Id = new Guid("554d947c-6515-4cc7-a7a7-78472ecb25aa"),
                            Description = "Description 12",
                            Title = "Course 12"
                        },
                        new
                        {
                            Id = new Guid("851a2516-9a41-4410-9edf-4ce4b7da7b41"),
                            Description = "Description 13",
                            Title = "Course 13"
                        },
                        new
                        {
                            Id = new Guid("e6dc39fb-f3eb-4a5e-a57e-82f83c3d917e"),
                            Description = "Description 14",
                            Title = "Course 14"
                        },
                        new
                        {
                            Id = new Guid("73229c4b-16c8-4751-9193-f78e9c5dc173"),
                            Description = "Description 15",
                            Title = "Course 15"
                        },
                        new
                        {
                            Id = new Guid("dbcbfa72-d496-4111-bdde-4a566072a965"),
                            Description = "Description 16",
                            Title = "Course 16"
                        },
                        new
                        {
                            Id = new Guid("c1d63cb7-6696-45a7-b864-79e3aee7de2a"),
                            Description = "Description 17",
                            Title = "Course 17"
                        },
                        new
                        {
                            Id = new Guid("454c2bdc-2ab6-4983-88e3-2a92d8f135e9"),
                            Description = "Description 18",
                            Title = "Course 18"
                        },
                        new
                        {
                            Id = new Guid("470c5936-0fc8-4c12-b2b4-8a39fa5d87a5"),
                            Description = "Description 19",
                            Title = "Course 19"
                        },
                        new
                        {
                            Id = new Guid("70fbee91-6f6f-4b80-9b50-3d5dd751cf3d"),
                            Description = "Description 20",
                            Title = "Course 20"
                        });
                });

            modelBuilder.Entity("TestTaskSoftserve.DAL.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("StudyYear")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("24d5d9fc-9a33-4923-9a33-b489b8952c48"),
                            Age = 99,
                            Group = "Group 1",
                            Name = "Student's name 1",
                            StudyYear = 2,
                            Surname = "Student's surname 1"
                        },
                        new
                        {
                            Id = new Guid("4e7adf3b-027b-4b88-bcd9-2ff7f873d7a9"),
                            Age = 46,
                            Group = "Group 2",
                            Name = "Student's name 2",
                            StudyYear = 4,
                            Surname = "Student's surname 2"
                        },
                        new
                        {
                            Id = new Guid("6431cc82-8f79-4360-a003-67a955b7db5e"),
                            Age = 32,
                            Group = "Group 3",
                            Name = "Student's name 3",
                            StudyYear = 5,
                            Surname = "Student's surname 3"
                        },
                        new
                        {
                            Id = new Guid("00f6eead-7014-4f06-94c6-757893050993"),
                            Age = 78,
                            Group = "Group 4",
                            Name = "Student's name 4",
                            StudyYear = 9,
                            Surname = "Student's surname 4"
                        },
                        new
                        {
                            Id = new Guid("c9062ef1-ae96-410c-a215-56c153852fc5"),
                            Age = 49,
                            Group = "Group 5",
                            Name = "Student's name 5",
                            StudyYear = 0,
                            Surname = "Student's surname 5"
                        },
                        new
                        {
                            Id = new Guid("93469f3b-fa89-4ee1-a6c7-d8c04ad01c4f"),
                            Age = 94,
                            Group = "Group 6",
                            Name = "Student's name 6",
                            StudyYear = 5,
                            Surname = "Student's surname 6"
                        },
                        new
                        {
                            Id = new Guid("4a5facf3-a08c-478a-bb15-f42ae89a996f"),
                            Age = 40,
                            Group = "Group 7",
                            Name = "Student's name 7",
                            StudyYear = 7,
                            Surname = "Student's surname 7"
                        },
                        new
                        {
                            Id = new Guid("f3dd87e7-9222-4e21-8ff7-d202d5c045e8"),
                            Age = 60,
                            Group = "Group 8",
                            Name = "Student's name 8",
                            StudyYear = 16,
                            Surname = "Student's surname 8"
                        },
                        new
                        {
                            Id = new Guid("fa7dfd04-4824-49c2-9398-1a6b2eb80ae8"),
                            Age = 60,
                            Group = "Group 9",
                            Name = "Student's name 9",
                            StudyYear = 9,
                            Surname = "Student's surname 9"
                        },
                        new
                        {
                            Id = new Guid("c1d8b68f-2f8d-4e63-bedf-d132e81c8307"),
                            Age = 70,
                            Group = "Group 10",
                            Name = "Student's name 10",
                            StudyYear = 5,
                            Surname = "Student's surname 10"
                        });
                });

            modelBuilder.Entity("TestTaskSoftserve.DAL.Entities.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a319384b-0a29-478f-bc19-6e699d612e59"),
                            Age = 21,
                            Experience = 2,
                            Name = "Teacher's name 1",
                            Surname = "Teacher's surname 1"
                        },
                        new
                        {
                            Id = new Guid("36593933-ba68-44af-b058-e5fd04380dba"),
                            Age = 50,
                            Experience = 4,
                            Name = "Teacher's name 2",
                            Surname = "Teacher's surname 2"
                        },
                        new
                        {
                            Id = new Guid("58f9ea3d-548a-47c4-9ced-d4250064c64d"),
                            Age = 35,
                            Experience = 0,
                            Name = "Teacher's name 3",
                            Surname = "Teacher's surname 3"
                        },
                        new
                        {
                            Id = new Guid("2d4000c6-b611-4d2a-b48f-09576f31552d"),
                            Age = 61,
                            Experience = 3,
                            Name = "Teacher's name 4",
                            Surname = "Teacher's surname 4"
                        },
                        new
                        {
                            Id = new Guid("cb4b44a6-c286-472a-acea-b0f44ff2cb2b"),
                            Age = 18,
                            Experience = 8,
                            Name = "Teacher's name 5",
                            Surname = "Teacher's surname 5"
                        },
                        new
                        {
                            Id = new Guid("10e98920-24ae-4612-90d4-8eccfdb9c9a2"),
                            Age = 26,
                            Experience = 9,
                            Name = "Teacher's name 6",
                            Surname = "Teacher's surname 6"
                        },
                        new
                        {
                            Id = new Guid("954b8de0-3721-4c70-9807-4a5d4a982acc"),
                            Age = 52,
                            Experience = 15,
                            Name = "Teacher's name 7",
                            Surname = "Teacher's surname 7"
                        },
                        new
                        {
                            Id = new Guid("99be3cbe-2852-4e03-a107-5bbaeebb9b59"),
                            Age = 26,
                            Experience = 17,
                            Name = "Teacher's name 8",
                            Surname = "Teacher's surname 8"
                        },
                        new
                        {
                            Id = new Guid("c03b169d-b7a4-449d-9c62-f56730242e07"),
                            Age = 22,
                            Experience = 18,
                            Name = "Teacher's name 9",
                            Surname = "Teacher's surname 9"
                        },
                        new
                        {
                            Id = new Guid("68eb2508-cbfe-47f8-9894-66d4776f345a"),
                            Age = 44,
                            Experience = 21,
                            Name = "Teacher's name 10",
                            Surname = "Teacher's surname 10"
                        });
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("TestTaskSoftserve.DAL.Entities.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestTaskSoftserve.DAL.Entities.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseTeacher", b =>
                {
                    b.HasOne("TestTaskSoftserve.DAL.Entities.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestTaskSoftserve.DAL.Entities.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("TestTaskSoftServe.DAL.Entities.User.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("TestTaskSoftServe.DAL.Entities.User.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("TestTaskSoftServe.DAL.Entities.User.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("TestTaskSoftServe.DAL.Entities.User.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestTaskSoftServe.DAL.Entities.User.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("TestTaskSoftServe.DAL.Entities.User.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
