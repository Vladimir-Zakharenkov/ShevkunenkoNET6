using ShevkunenkoSite.Models;

namespace ShevkunenkoSite.Services;

public interface IPageInfoRepository
{
    IQueryable<PageInfoModel> PagesInfo { get; }
}
