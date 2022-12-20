namespace ShevkunenkoSite.Models;

public class BackgroundFileModel
{
    [Display(Name = " BackgroundFileId :")]
    [Column("BackgroundFileId")]
    public Guid BackgroundFileModelId { get; set; }

    public string LeftBackground { get; set; } = "Fotoplenka.png";

    public string RightBackground { get; set; } = "FotoPlenka.png";
}
