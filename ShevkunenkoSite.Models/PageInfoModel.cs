namespace ShevkunenkoSite.Models;

public class PageInfoModel
{
    [Display(Name = " PageInfoId :")]
    [Column ("PageInfoId")]
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

    [Required(ErrorMessage = "Добавте ключевые слова")]
    [DataType(DataType.Text)]
    [Display(Name = "Ключевые слова:")]
    public string PageKeyWords { get; set; } = "сергей шевкуненко,сергей шевкуненко фото,сергей " +
        "шевкуненко криминальная,шевкуненко сергей юрьевич,сергей шевкуненко биография," +
        "сергей шевкуненко криминальная биография,сергей шевкуненко убийство," +
        "сергей шевкуненко фото убийство,сергей шевкуненко жена,сергей шевкуненко википедия," +
        "фильм криминальная звезда сергей шевкуненко,сергей шевкуненко похороны," +
        "актер сергей шевкуненко,памяти сергей шевкуненко,сергей шевкуненко документальный фильм," +
        "сергей шевкуненко документальный фильм криминальная звезда,криминальная звезда " +
        "документальный фильм памяти сергея шевкуненко,сергей шевкуненко видео," +
        "сестра сергея шевкуненко,шевкуненко сергей юрьевич похороны,сергей шевкуненко кортик," +
        "елена шевкуненко жена сергея шевкуненко,сергей шевкуненко могила," +
        "сергей шевкуненко смерть,сергей шевкуненко похороны видео,сергей шевкуненко личная жизнь," +
        "сергей шевкуненко фото смерть,шевкуненко сергей юрьевич вспоминают друзья," +
        "актер сергей шевкуненко биография,судьба сергея шевкуненко," +
        "сергей шевкуненко фото перед смертью,сергей шевкуненко криминал," +
        "шевкуненко сергей юрьевич криминал";

    [Required(ErrorMessage = "Необходимо указать дату")]
    [DataType(DataType.Date)]
    [Display(Name = "Дата изменения:")]
    public DateTime PageLastmod { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "Необходимо ввести адрес страницы")]
    [Display(Name = "Адрес страницы:")]
    public string PageLoc { get; set; } = "/index";

    [Required(ErrorMessage = "Необходимо ввести каталог с иконками")]
    [Display(Name = "Каталог с иконками:")]
    public string IconPath { get; set; } = "main";

    [Required(ErrorMessage = "Необходимо указать файл browserconfig")]
    [Display(Name = "Файл browserconfig:")]
    public string BrowserConfig { get; set; } = "main";

    public Guid BackgroundFileModelId { get; set; }
    public BackgroundFileModel BackgroundFileModel { get; set; } = null!;

    public Guid ImageFileModelId { get; set; }
    public ImageFileModel ImageFileModel { get; set; } = null!;
}
