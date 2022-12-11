using ShevkunenkoSite.Models;
using System.Net.Http;

public interface IPageInfoRepository
{
    IQueryable<PageInfoModel> PagesInfo { get; }
}
