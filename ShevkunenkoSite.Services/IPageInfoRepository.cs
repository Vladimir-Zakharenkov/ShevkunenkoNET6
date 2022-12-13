public interface IPageInfoRepository
{
    IQueryable<PageInfoModel> PagesInfo { get; }

    Task<PageInfoModel> GetPageInfoByPathAsync(string pagePath);
}
