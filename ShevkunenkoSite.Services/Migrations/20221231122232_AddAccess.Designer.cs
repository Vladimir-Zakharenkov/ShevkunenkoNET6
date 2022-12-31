﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShevkunenkoSite.Services;

#nullable disable

namespace ShevkunenkoSite.Services.Migrations
{
    [DbContext(typeof(SiteDbContext))]
    [Migration("20221231122232_AddAccess")]
    partial class AddAccess
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShevkunenkoSite.Models.AccessModel", b =>
                {
                    b.Property<Guid>("AccessModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccessModelId");

                    b.ToTable("Access");
                });

            modelBuilder.Entity("ShevkunenkoSite.Models.BackgroundFileModel", b =>
                {
                    b.Property<Guid>("BackgroundFileModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("BackgroundFileId");

                    b.Property<string>("LeftBackground")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RightBackground")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BackgroundFileModelId");

                    b.ToTable("BackgroundFile");
                });

            modelBuilder.Entity("ShevkunenkoSite.Models.IconFileModel", b =>
                {
                    b.Property<Guid>("IconFileModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IconFileId");

                    b.Property<string>("IconFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconFileNameExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("IconFileSize")
                        .HasColumnType("bigint");

                    b.Property<long>("IconHeight")
                        .HasColumnType("bigint");

                    b.Property<string>("IconMimeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconRel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("IconWidth")
                        .HasColumnType("bigint");

                    b.HasKey("IconFileModelId");

                    b.ToTable("IconFile");
                });

            modelBuilder.Entity("ShevkunenkoSite.Models.ImageFileModel", b =>
                {
                    b.Property<Guid>("ImageFileModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ImageFileId");

                    b.Property<string>("IconFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconFileNameExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("IconFileSize")
                        .HasColumnType("bigint");

                    b.Property<long>("IconHeight")
                        .HasColumnType("bigint");

                    b.Property<string>("IconMimeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("IconWidth")
                        .HasColumnType("bigint");

                    b.Property<string>("ImageAltTitle")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ImageCaption")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ImageDescription")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ImageFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFileNameExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ImageFileSize")
                        .HasColumnType("bigint");

                    b.Property<long>("ImageHeight")
                        .HasColumnType("bigint");

                    b.Property<string>("ImageMimeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ImageWidth")
                        .HasColumnType("bigint");

                    b.HasKey("ImageFileModelId");

                    b.ToTable("ImageFile");
                });

            modelBuilder.Entity("ShevkunenkoSite.Models.PageInfoModel", b =>
                {
                    b.Property<Guid>("PageInfoModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PageInfoId");

                    b.Property<Guid>("BackgroundFileModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrowserConfig")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("main.xml");

                    b.Property<string>("IconPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageFileModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Manifest")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("main.json");

                    b.Property<string>("OgType")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("website");

                    b.Property<string>("PageDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageKeyWords")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PageLastmod")
                        .HasColumnType("datetime2");

                    b.Property<string>("PageLoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PageInfoModelId");

                    b.HasIndex("BackgroundFileModelId");

                    b.HasIndex("ImageFileModelId");

                    b.ToTable("PageInfo");
                });

            modelBuilder.Entity("ShevkunenkoSite.Models.PageInfoModel", b =>
                {
                    b.HasOne("ShevkunenkoSite.Models.BackgroundFileModel", "BackgroundFileModel")
                        .WithMany()
                        .HasForeignKey("BackgroundFileModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShevkunenkoSite.Models.ImageFileModel", "ImageFileModel")
                        .WithMany()
                        .HasForeignKey("ImageFileModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BackgroundFileModel");

                    b.Navigation("ImageFileModel");
                });
#pragma warning restore 612, 618
        }
    }
}
