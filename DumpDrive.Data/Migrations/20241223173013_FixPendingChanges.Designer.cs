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
    [Migration("20241223173013_FixPendingChanges")]
    partial class FixPendingChanges
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
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ChangeType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ChangedByUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("FileId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ChangedByUserId");

                    b.HasIndex("FileId");

                    b.ToTable("AuditLogs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b8def73f-a43f-404c-882b-e85470b0b4c6"),
                            ChangeType = "Created",
                            ChangedByUserId = new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b"),
                            FileId = new Guid("18cac455-ad41-4319-a634-2a9d17689cca"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9084)
                        },
                        new
                        {
                            Id = new Guid("8c5f70d1-6ab0-49a3-a7d1-8e179a96a35a"),
                            ChangeType = "Created",
                            ChangedByUserId = new Guid("768c24d1-830d-417b-ad80-f796b8b431e5"),
                            FileId = new Guid("abe87502-e27c-4b33-b738-0525f612dd89"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9109)
                        },
                        new
                        {
                            Id = new Guid("618df100-5171-46ec-8041-fedda87083ef"),
                            ChangeType = "Updated",
                            ChangedByUserId = new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"),
                            FileId = new Guid("7f4f3756-0cc1-4512-972e-52a278b6c448"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9114)
                        },
                        new
                        {
                            Id = new Guid("9256f822-3cdc-4d5d-a796-c8f0545d5947"),
                            ChangeType = "Created",
                            ChangedByUserId = new Guid("8448c96d-994e-499a-b088-4b000ad75f14"),
                            FileId = new Guid("8591a6e3-ae28-4252-ab1d-46269a1029e4"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9118)
                        },
                        new
                        {
                            Id = new Guid("0c88bb93-533d-4d60-90b0-de4bc3ecc834"),
                            ChangeType = "Created",
                            ChangedByUserId = new Guid("768c24d1-830d-417b-ad80-f796b8b431e5"),
                            FileId = new Guid("2917e05a-7319-4f5b-a018-122b2e479d94"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9122)
                        },
                        new
                        {
                            Id = new Guid("b2c17a3e-e9a0-4cd9-89bc-7f05f53dc7f3"),
                            ChangeType = "Updated",
                            ChangedByUserId = new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"),
                            FileId = new Guid("5ec7786d-67a2-45e8-9519-2c6a4c355d08"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9130)
                        },
                        new
                        {
                            Id = new Guid("559b093d-706f-4885-8c8d-713dae37e82e"),
                            ChangeType = "Created",
                            ChangedByUserId = new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b"),
                            FileId = new Guid("ad9be4dc-22c6-453d-a653-1f226a5740db"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9134)
                        },
                        new
                        {
                            Id = new Guid("281bcc96-36ea-4ff1-85d2-4a460b9039f3"),
                            ChangeType = "Created",
                            ChangedByUserId = new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"),
                            FileId = new Guid("af0f1246-c605-438a-8b86-74b4b10df437"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9139)
                        },
                        new
                        {
                            Id = new Guid("aff5ccd9-ef3a-4de0-9c6f-a7ec4f62a1ef"),
                            ChangeType = "Updated",
                            ChangedByUserId = new Guid("8448c96d-994e-499a-b088-4b000ad75f14"),
                            FileId = new Guid("761d0321-9776-4220-b0c9-92af5776bade"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9142)
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("FileId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("FileId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d9cb7556-a96a-4fd4-9159-59414303a4bb"),
                            Content = "Great resume!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(6996),
                            FileId = new Guid("18cac455-ad41-4319-a634-2a9d17689cca"),
                            UserId = new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b")
                        },
                        new
                        {
                            Id = new Guid("5a11c4a1-c92e-4f51-becc-963a171a0be3"),
                            Content = "Lovely picture!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7019),
                            FileId = new Guid("abe87502-e27c-4b33-b738-0525f612dd89"),
                            UserId = new Guid("768c24d1-830d-417b-ad80-f796b8b431e5")
                        },
                        new
                        {
                            Id = new Guid("fb1fe139-546a-4540-a12c-ff5f13eaf207"),
                            Content = "Nice music!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7030),
                            FileId = new Guid("7f4f3756-0cc1-4512-972e-52a278b6c448"),
                            UserId = new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e")
                        },
                        new
                        {
                            Id = new Guid("ae829c37-aa06-450d-a8a7-7bf53d9e5938"),
                            Content = "Cool video!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7035),
                            FileId = new Guid("8591a6e3-ae28-4252-ab1d-46269a1029e4"),
                            UserId = new Guid("8448c96d-994e-499a-b088-4b000ad75f14")
                        },
                        new
                        {
                            Id = new Guid("0614504b-1978-4248-a506-e62c2ab224fc"),
                            Content = "This resume could be better.",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7039),
                            FileId = new Guid("18cac455-ad41-4319-a634-2a9d17689cca"),
                            UserId = new Guid("8448c96d-994e-499a-b088-4b000ad75f14")
                        },
                        new
                        {
                            Id = new Guid("ccecd784-80dd-4fb2-8ddb-8186f6ece6e7"),
                            Content = "Beautiful image!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7044),
                            FileId = new Guid("abe87502-e27c-4b33-b738-0525f612dd89"),
                            UserId = new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e")
                        },
                        new
                        {
                            Id = new Guid("7145adab-0e1a-4c64-b4ae-e0f836909dd8"),
                            Content = "I dont like this song!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7052),
                            FileId = new Guid("7f4f3756-0cc1-4512-972e-52a278b6c448"),
                            UserId = new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e")
                        },
                        new
                        {
                            Id = new Guid("d032ba0b-3310-4c36-a546-42450ef15d59"),
                            Content = "Amazing video!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7056),
                            FileId = new Guid("8591a6e3-ae28-4252-ab1d-46269a1029e4"),
                            UserId = new Guid("768c24d1-830d-417b-ad80-f796b8b431e5")
                        },
                        new
                        {
                            Id = new Guid("c9b4e8ef-0908-43e7-8386-ae102d7aa1c5"),
                            Content = "Excellent project plan!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7060),
                            FileId = new Guid("2917e05a-7319-4f5b-a018-122b2e479d94"),
                            UserId = new Guid("768c24d1-830d-417b-ad80-f796b8b431e5")
                        },
                        new
                        {
                            Id = new Guid("575b9fe9-8198-48a7-a4a6-d58ed7a09e21"),
                            Content = "Great presentation!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7065),
                            FileId = new Guid("5ec7786d-67a2-45e8-9519-2c6a4c355d08"),
                            UserId = new Guid("8448c96d-994e-499a-b088-4b000ad75f14")
                        },
                        new
                        {
                            Id = new Guid("ede3a530-6c71-478b-b2b6-b1ec406bff7f"),
                            Content = "Very detailed report!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7072),
                            FileId = new Guid("ad9be4dc-22c6-453d-a653-1f226a5740db"),
                            UserId = new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b")
                        },
                        new
                        {
                            Id = new Guid("00e61005-5264-4f64-ae23-a0100dacca9a"),
                            Content = "Important archive data.",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7076),
                            FileId = new Guid("af0f1246-c605-438a-8b86-74b4b10df437"),
                            UserId = new Guid("768c24d1-830d-417b-ad80-f796b8b431e5")
                        },
                        new
                        {
                            Id = new Guid("fdcc3103-55fa-4286-87f5-7db925ca5ce4"),
                            Content = "Data needs cleanup.",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7079),
                            FileId = new Guid("761d0321-9776-4220-b0c9-92af5776bade"),
                            UserId = new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b")
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.DumpFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("FolderId")
                        .HasColumnType("uuid");

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
                            Id = new Guid("18cac455-ad41-4319-a634-2a9d17689cca"),
                            FolderId = new Guid("ba5de896-154a-470f-ae0b-75e7025a31d1"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 30, 12, 545, DateTimeKind.Local).AddTicks(3460),
                            Name = "resume.pdf",
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("abe87502-e27c-4b33-b738-0525f612dd89"),
                            FolderId = new Guid("04ab7409-d9c3-4a27-ad6c-3c072c684d43"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4481),
                            Name = "holiday.jpg",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("7f4f3756-0cc1-4512-972e-52a278b6c448"),
                            FolderId = new Guid("fce49196-a5ce-4a2c-879c-7ac7d29503a6"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4509),
                            Name = "song.mp3",
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("8591a6e3-ae28-4252-ab1d-46269a1029e4"),
                            FolderId = new Guid("e7ff57c0-f9e0-487d-bc60-f86156f23c7e"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4513),
                            Name = "movie.mp4",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("2917e05a-7319-4f5b-a018-122b2e479d94"),
                            FolderId = new Guid("e5e83150-d222-44d9-83c7-a358c7e88cdf"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4517),
                            Name = "project_plan.docx",
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("5ec7786d-67a2-45e8-9519-2c6a4c355d08"),
                            FolderId = new Guid("e5e83150-d222-44d9-83c7-a358c7e88cdf"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4533),
                            Name = "presentation.pptx",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("ad9be4dc-22c6-453d-a653-1f226a5740db"),
                            FolderId = new Guid("c82b7434-7bb1-4970-899d-217227b4c8e6"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4537),
                            Name = "report.pdf",
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("af0f1246-c605-438a-8b86-74b4b10df437"),
                            FolderId = new Guid("e5dd2bd2-ade5-4807-9d77-470f82e81a80"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4539),
                            Name = "archive.zip",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("761d0321-9776-4220-b0c9-92af5776bade"),
                            FolderId = new Guid("e5dd2bd2-ade5-4807-9d77-470f82e81a80"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4542),
                            Name = "data.csv",
                            Status = 0
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Folder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Folders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba5de896-154a-470f-ae0b-75e7025a31d1"),
                            Name = "Documents",
                            OwnerId = new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("04ab7409-d9c3-4a27-ad6c-3c072c684d43"),
                            Name = "Photos",
                            OwnerId = new Guid("768c24d1-830d-417b-ad80-f796b8b431e5"),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("fce49196-a5ce-4a2c-879c-7ac7d29503a6"),
                            Name = "Music",
                            OwnerId = new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("e7ff57c0-f9e0-487d-bc60-f86156f23c7e"),
                            Name = "Videos",
                            OwnerId = new Guid("8448c96d-994e-499a-b088-4b000ad75f14"),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("e5e83150-d222-44d9-83c7-a358c7e88cdf"),
                            Name = "Projects",
                            OwnerId = new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("c82b7434-7bb1-4970-899d-217227b4c8e6"),
                            Name = "Downloads",
                            OwnerId = new Guid("768c24d1-830d-417b-ad80-f796b8b431e5"),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("e5dd2bd2-ade5-4807-9d77-470f82e81a80"),
                            Name = "Archives",
                            OwnerId = new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b"),
                            Status = 0
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

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
                            Id = new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b"),
                            Email = "ivona@gmail.com",
                            Password = "password123",
                            Username = "ivona"
                        },
                        new
                        {
                            Id = new Guid("768c24d1-830d-417b-ad80-f796b8b431e5"),
                            Email = "jure@gmail.com",
                            Password = "password456",
                            Username = "jure"
                        },
                        new
                        {
                            Id = new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"),
                            Email = "bruno@gmail.com",
                            Password = "pass9",
                            Username = "bruno"
                        },
                        new
                        {
                            Id = new Guid("8448c96d-994e-499a-b088-4b000ad75f14"),
                            Email = "ana@gmail.com",
                            Password = "pass7",
                            Username = "ana"
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

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.DumpFile", b =>
                {
                    b.Navigation("AuditLogs");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Folder", b =>
                {
                    b.Navigation("Files");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.User", b =>
                {
                    b.Navigation("AuditLogs");

                    b.Navigation("Comments");

                    b.Navigation("Folders");
                });
#pragma warning restore 612, 618
        }
    }
}