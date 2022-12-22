namespace ShevkunenkoSite.Services;

public interface IImageFileRepository
{
    IQueryable<ImageFileModel> ImageFiles { get; }
}
