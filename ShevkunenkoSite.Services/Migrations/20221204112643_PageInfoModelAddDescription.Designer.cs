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
    [Migration("20221204112643_PageInfoModelAddDescription")]
    partial class PageInfoModelAddDescription
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShevkunenkoSite.Models.PageInfoModel", b =>
                {
                    b.Property<Guid>("PageInfoModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PageDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PageInfoModelId");

                    b.ToTable("PageInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
