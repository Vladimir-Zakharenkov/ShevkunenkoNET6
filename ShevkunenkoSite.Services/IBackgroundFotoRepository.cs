public interface IBackgroundFotoRepository
{
    IQueryable<BackgroundFileModel> BackgroundFiles { get; }

    Task<BackgroundFileModel> GetBackgroundFotoByPathAsync(string pagePath);

}
