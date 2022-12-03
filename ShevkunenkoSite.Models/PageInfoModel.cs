using System.ComponentModel.DataAnnotations;

namespace ShevkunenkoSite.Models;

public class PageInfoModel
{
    [Display(Name = " PageInfoId :")]
    public Guid PageInfoModelId { get; set; }

    [Required(ErrorMessage = "Добавьте заголовок страницы")]
    [DataType(DataType.Text)]
    [Display(Name = "Заголовок страницы :")]
    public string PageTitle { get; set; } = string.Empty;
}
