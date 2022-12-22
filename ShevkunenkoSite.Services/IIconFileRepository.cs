namespace ShevkunenkoSite.Services;

public interface IIconFileRepository
{
    IQueryable<IconFileModel> IconFiles { get; }
}
