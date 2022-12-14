public class SiteDbContext : DbContext
{
    public SiteDbContext(DbContextOptions<SiteDbContext> options) : base(options) { }

    public DbSet<PageInfoModel> PageInfo => Set<PageInfoModel>();

    public DbSet<BackgroundFileModel> BackgroundFile => Set<BackgroundFileModel>();
}
