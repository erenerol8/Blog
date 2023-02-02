﻿// <auto-generated />
using System;
using Blog.Data.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230202131446_DALExtension")]
    partial class DALExtension
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9daea9e3-7342-444b-af5d-147aa8a17c0b"),
                            CategoryId = new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"),
                            Content = "Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 2, 2, 16, 14, 45, 770, DateTimeKind.Local).AddTicks(571),
                            ImageId = new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"),
                            IsDeleted = false,
                            Title = "ASP.NET Core Deneme Makalesi",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("8b03e030-2c94-4058-b4e6-22c1100f7aaa"),
                            CategoryId = new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"),
                            Content = "Entity Framework Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 2, 2, 16, 14, 45, 770, DateTimeKind.Local).AddTicks(582),
                            ImageId = new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"),
                            IsDeleted = false,
                            Title = "Entity Framework Core Deneme Makalesi",
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 2, 2, 16, 14, 45, 770, DateTimeKind.Local).AddTicks(1122),
                            IsDeleted = false,
                            Name = "ASP. NET CORE"
                        },
                        new
                        {
                            Id = new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 2, 2, 16, 14, 45, 770, DateTimeKind.Local).AddTicks(1129),
                            IsDeleted = false,
                            Name = "Entity"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 2, 2, 16, 14, 45, 770, DateTimeKind.Local).AddTicks(1356),
                            FileName = "image/testimage",
                            FileType = "jpeg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 2, 2, 16, 14, 45, 770, DateTimeKind.Local).AddTicks(1364),
                            FileName = "image/testimage",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.HasOne("Blog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}