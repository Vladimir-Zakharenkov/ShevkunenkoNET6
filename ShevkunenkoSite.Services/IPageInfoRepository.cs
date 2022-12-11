using ShevkunenkoSite.Models;

public interface IPageInfoRepository
{
    IQueryable<PageInfoModel> PagesInfo { get; }
}
