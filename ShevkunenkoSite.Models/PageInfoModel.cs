using System.ComponentModel.DataAnnotations;

namespace ShevkunenkoSite.Models;

public class PageInfoModel
{
    [Display(Name = " PageInfoId :")]
    public Guid PageInfoModelId { get; set; }

    [Required(ErrorMessage = "Добавьте заголовок страницы")]
    [DataType(DataType.Text)]
    [Display(Name = "Заголовок страницы :")]
    public string PageTitle { get; set; } = "Сайт памяти Сергея Шевкуненко";

    [Required(ErrorMessage = "Добавте описание")]
    [DataType(DataType.Text)]
    [Display(Name = "Описание страницы:")]
    public string PageDescription { get; set; } = "Эта история по-своему уникальна и практически не имеет " +
                    "аналогов в истории российского кинематографа. Подававший большие надежды " +
                    "актер волею судьбы угодил в тюрьму и довольно быстро добился славы и " +
                    "признания совсем в другой среде - уголовной. Последней ступенькой, " +
                    "на которую сумел забраться в преступной иерархии этот бывший актер, " +
                    "была должность «положенца», которая предшествует самому высокому " +
                    "титулу в уголовной среде - вора в законе. Имя этого человека - " +
                    "Сергей Шевкуненко.";


}
