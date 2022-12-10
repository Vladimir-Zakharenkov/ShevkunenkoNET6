﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShevkunenkoSite.Services;

#nullable disable

namespace ShevkunenkoSite.Services.Migrations
{
    [DbContext(typeof(SiteDbContext))]
    partial class SiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

            modelBuilder.Entity("ShevkunenkoSite.Models.PageInfoModel", b =>
                {
                    b.Property<Guid>("PageInfoModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PageInfoId");

                    b.Property<Guid>("BackgroundFileModelId")
                        .HasColumnType("uniqueidentifier");

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

                    b.ToTable("PageInfo");
                });

            modelBuilder.Entity("ShevkunenkoSite.Models.PageInfoModel", b =>
                {
                    b.HasOne("ShevkunenkoSite.Models.BackgroundFileModel", "BackgroundFileModel")
                        .WithMany()
                        .HasForeignKey("BackgroundFileModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BackgroundFileModel");
                });
#pragma warning restore 612, 618
        }
    }
}
