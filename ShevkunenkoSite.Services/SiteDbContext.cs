﻿namespace ShevkunenkoSite.Services;

public class SiteDbContext : DbContext
{
    public SiteDbContext(DbContextOptions<SiteDbContext> options) : base(options) { }

    public DbSet<PageInfoModel> PageInfo => Set<PageInfoModel>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PageInfoModel>()
            .Property(b => b.BrowserConfig)
            .HasDefaultValue("main.xml");
    }

    public DbSet<BackgroundFileModel> BackgroundFile => Set<BackgroundFileModel>();

    public DbSet<ImageFileModel> ImageFile => Set<ImageFileModel>();

    public DbSet<IconFileModel> IconFile => Set<IconFileModel>();
}