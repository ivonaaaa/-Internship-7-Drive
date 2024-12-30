﻿// <auto-generated />
using System;
using DumpDrive.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DumpDrive.Data.Migrations
{
    [DbContext(typeof(DumpDriveDbContext))]
    [Migration("20241230200832_UpdatedMigration")]
    partial class UpdatedMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.AuditLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ChangeType")
                        .HasColumnType("integer");

                    b.Property<int>("ChangedByUserId")
                        .HasColumnType("integer");

                    b.Property<int>("FileId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ChangedByUserId");

                    b.HasIndex("FileId");

                    b.ToTable("AuditLogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChangeType = 0,
                            ChangedByUserId = 1,
                            FileId = 1,
                            Timestamp = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
                            ChangeType = 0,
                            ChangedByUserId = 2,
                            FileId = 2,
                            Timestamp = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 3,
                            ChangeType = 1,
                            ChangedByUserId = 3,
                            FileId = 3,
                            Timestamp = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 4,
                            ChangeType = 0,
                            ChangedByUserId = 4,
                            FileId = 4,
                            Timestamp = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 5,
                            ChangeType = 0,
                            ChangedByUserId = 2,
                            FileId = 5,
                            Timestamp = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 6,
                            ChangeType = 1,
                            ChangedByUserId = 3,
                            FileId = 6,
                            Timestamp = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 7,
                            ChangeType = 0,
                            ChangedByUserId = 1,
                            FileId = 7,
                            Timestamp = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 8,
                            ChangeType = 0,
                            ChangedByUserId = 3,
                            FileId = 8,
                            Timestamp = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 9,
                            ChangeType = 1,
                            ChangedByUserId = 4,
                            FileId = 9,
                            Timestamp = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 10,
                            ChangeType = 0,
                            ChangedByUserId = 5,
                            FileId = 10,
                            Timestamp = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 11,
                            ChangeType = 0,
                            ChangedByUserId = 6,
                            FileId = 11,
                            Timestamp = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FileId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FileId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Great resume!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Lovely picture!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "Nice music!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Content = "Cool video!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 4,
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            Content = "This resume could be better.",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 1,
                            UserId = 4
                        },
                        new
                        {
                            Id = 6,
                            Content = "Beautiful image!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 2,
                            UserId = 3
                        },
                        new
                        {
                            Id = 7,
                            Content = "I don't like this song!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 8,
                            Content = "Amazing video!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 4,
                            UserId = 2
                        },
                        new
                        {
                            Id = 9,
                            Content = "Excellent project plan!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 5,
                            UserId = 2
                        },
                        new
                        {
                            Id = 10,
                            Content = "Great presentation!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 6,
                            UserId = 4
                        },
                        new
                        {
                            Id = 11,
                            Content = "Very detailed report!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 7,
                            UserId = 1
                        },
                        new
                        {
                            Id = 12,
                            Content = "Important archive data.",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 8,
                            UserId = 2
                        },
                        new
                        {
                            Id = 13,
                            Content = "Data needs cleanup.",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 9,
                            UserId = 1
                        },
                        new
                        {
                            Id = 14,
                            Content = "Work file looks great!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 10,
                            UserId = 3
                        },
                        new
                        {
                            Id = 15,
                            Content = "Love the game review!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 11,
                            UserId = 4
                        },
                        new
                        {
                            Id = 16,
                            Content = "Nice recipe!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 12,
                            UserId = 1
                        },
                        new
                        {
                            Id = 17,
                            Content = "Helpful notes!",
                            CreatedAt = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            FileId = 13,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.DumpFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FolderId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FolderId");

                    b.ToTable("Files");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FolderId = 1,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "resume.pdf",
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            FolderId = 2,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "holiday.jpg",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            FolderId = 3,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "song.mp3",
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            FolderId = 4,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "movie.mp4",
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            FolderId = 5,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "project_plan.docx",
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            FolderId = 5,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "presentation.pptx",
                            Status = 1
                        },
                        new
                        {
                            Id = 7,
                            FolderId = 6,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "report.pdf",
                            Status = 0
                        },
                        new
                        {
                            Id = 8,
                            FolderId = 7,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "archive.zip",
                            Status = 1
                        },
                        new
                        {
                            Id = 9,
                            FolderId = 7,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "data.csv",
                            Status = 0
                        },
                        new
                        {
                            Id = 10,
                            FolderId = 8,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "work_report.docx",
                            Status = 1
                        },
                        new
                        {
                            Id = 11,
                            FolderId = 9,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "game_review.txt",
                            Status = 0
                        },
                        new
                        {
                            Id = 12,
                            FolderId = 10,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "recipe.pdf",
                            Status = 1
                        },
                        new
                        {
                            Id = 13,
                            FolderId = 11,
                            LastChanged = new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc),
                            Name = "notes.txt",
                            Status = 0
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Folders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Documents",
                            OwnerId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Photos",
                            OwnerId = 2,
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Music",
                            OwnerId = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            Name = "Videos",
                            OwnerId = 4,
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Projects",
                            OwnerId = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            Name = "Downloads",
                            OwnerId = 2,
                            Status = 1
                        },
                        new
                        {
                            Id = 7,
                            Name = "Archives",
                            OwnerId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 8,
                            Name = "Work",
                            OwnerId = 5,
                            Status = 1
                        },
                        new
                        {
                            Id = 9,
                            Name = "Games",
                            OwnerId = 6,
                            Status = 0
                        },
                        new
                        {
                            Id = 10,
                            Name = "Recipes",
                            OwnerId = 4,
                            Status = 1
                        },
                        new
                        {
                            Id = 11,
                            Name = "Notes",
                            OwnerId = 6,
                            Status = 0
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "ivona@gmail.com",
                            Password = "password123",
                            Username = "ivona"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jure@gmail.com",
                            Password = "password456",
                            Username = "jure"
                        },
                        new
                        {
                            Id = 3,
                            Email = "bruno@gmail.com",
                            Password = "pass9",
                            Username = "bruno"
                        },
                        new
                        {
                            Id = 4,
                            Email = "ana@gmail.com",
                            Password = "pass7",
                            Username = "ana"
                        },
                        new
                        {
                            Id = 5,
                            Email = "marko@gmail.com",
                            Password = "marko123",
                            Username = "marko"
                        },
                        new
                        {
                            Id = 6,
                            Email = "petra@gmail.com",
                            Password = "petra456",
                            Username = "petra"
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.UserSharedFile", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("FileId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "FileId");

                    b.HasIndex("FileId");

                    b.ToTable("UserSharedFiles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            FileId = 2
                        },
                        new
                        {
                            UserId = 2,
                            FileId = 5
                        },
                        new
                        {
                            UserId = 3,
                            FileId = 6
                        },
                        new
                        {
                            UserId = 4,
                            FileId = 8
                        },
                        new
                        {
                            UserId = 1,
                            FileId = 3
                        },
                        new
                        {
                            UserId = 2,
                            FileId = 7
                        },
                        new
                        {
                            UserId = 3,
                            FileId = 4
                        },
                        new
                        {
                            UserId = 4,
                            FileId = 1
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.UserSharedFolder", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("FolderId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "FolderId");

                    b.HasIndex("FolderId");

                    b.ToTable("UserSharedFolders");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            FolderId = 2
                        },
                        new
                        {
                            UserId = 2,
                            FolderId = 6
                        },
                        new
                        {
                            UserId = 3,
                            FolderId = 4
                        },
                        new
                        {
                            UserId = 4,
                            FolderId = 7
                        },
                        new
                        {
                            UserId = 1,
                            FolderId = 3
                        },
                        new
                        {
                            UserId = 2,
                            FolderId = 5
                        },
                        new
                        {
                            UserId = 3,
                            FolderId = 8
                        },
                        new
                        {
                            UserId = 4,
                            FolderId = 1
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.AuditLog", b =>
                {
                    b.HasOne("DumpDrive.Data.Entities.Models.User", "ChangedByUser")
                        .WithMany("AuditLogs")
                        .HasForeignKey("ChangedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DumpDrive.Data.Entities.Models.DumpFile", "File")
                        .WithMany("AuditLogs")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChangedByUser");

                    b.Navigation("File");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Comment", b =>
                {
                    b.HasOne("DumpDrive.Data.Entities.Models.DumpFile", "File")
                        .WithMany("Comments")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DumpDrive.Data.Entities.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("File");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.DumpFile", b =>
                {
                    b.HasOne("DumpDrive.Data.Entities.Models.Folder", "Folder")
                        .WithMany("Files")
                        .HasForeignKey("FolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Folder");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Folder", b =>
                {
                    b.HasOne("DumpDrive.Data.Entities.Models.User", "Owner")
                        .WithMany("Folders")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.UserSharedFile", b =>
                {
                    b.HasOne("DumpDrive.Data.Entities.Models.DumpFile", "File")
                        .WithMany("SharedUsers")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DumpDrive.Data.Entities.Models.User", "User")
                        .WithMany("SharedFiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("File");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.UserSharedFolder", b =>
                {
                    b.HasOne("DumpDrive.Data.Entities.Models.Folder", "Folder")
                        .WithMany("SharedUsers")
                        .HasForeignKey("FolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DumpDrive.Data.Entities.Models.User", "User")
                        .WithMany("SharedFolders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Folder");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.DumpFile", b =>
                {
                    b.Navigation("AuditLogs");

                    b.Navigation("Comments");

                    b.Navigation("SharedUsers");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Folder", b =>
                {
                    b.Navigation("Files");

                    b.Navigation("SharedUsers");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.User", b =>
                {
                    b.Navigation("AuditLogs");

                    b.Navigation("Comments");

                    b.Navigation("Folders");

                    b.Navigation("SharedFiles");

                    b.Navigation("SharedFolders");
                });
#pragma warning restore 612, 618
        }
    }
}