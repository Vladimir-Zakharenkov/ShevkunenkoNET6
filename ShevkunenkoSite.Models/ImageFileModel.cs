namespace ShevkunenkoSite.Models;

public class ImageFileModel
{
    [Key]
    [Display(Name = "Идентификатор картинки :")]
    [Column("ImageFileId")]
    public Guid ImageId { get; set; }

    [Required(ErrorMessage = "Введите название картинки")]
    [DataType(DataType.Text)]
    [MaxLength(40, ErrorMessage = "{0} не должно содержать больше {1} символов")]
    [Display(Name = "Название картинки :")]
    public string ImageCaption { get; set; } = string.Empty;

    [Required(ErrorMessage = "Введите описание картинки")]
    [DataType(DataType.Text)]
    [MaxLength(300, ErrorMessage = "{0} не должно содержать больше {1} символов")]
    [Display(Name = "Описание картинки :")]
    public string ImageDescription { get; set; } = string.Empty;

    [DataType(DataType.Text)]
    [MaxLength(40, ErrorMessage = "{0} не должно содержать больше {1} символов")]
    [Display(Name = "Свойства «alt» и «title» :")]
    public string ImageAltTitle { get; set; } = string.Empty;

    [DataType(DataType.Text)]
    [Display(Name = "Каталог картинки :")]
    public string ImagePath { get; set; } = string.Empty;

    [DataType(DataType.Text)]
    [Display(Name = "Файл картинки :")]
    public string ImageFileName { get; set; } = string.Empty;

    [DataType(DataType.Text)]
    [Display(Name = "Расширение файла картинки :")]
    public string ImageFileNameExtension { get; set; } = "png";

    [DataType(DataType.Text)]
    [Display(Name = "MimeType файла картинки :")]
    public string ImageMimeType { get; set; } = "image/png";

    [DataType(DataType.Text)]
    [Display(Name = "Размер файла картинки :")]
    public uint ImageFileSize { get; set; } = 1;

    [Display(Name = "Ширина картинки в px :")]
    public uint ImageWidth { get; set; } = 1;

    [Display(Name = "Высота картинки в px :")]
    public uint ImageHeight { get; set; } = 1;

    [DataType(DataType.Text)]
    [Display(Name = "Файл иконки :")]
    public string IconFileName { get; set; } = string.Empty;

    [DataType(DataType.Text)]
    [Display(Name = "Расширение файла иконки :")]
    public string IconFileNameExtension { get; set; } = "png";

    [DataType(DataType.Text)]
    [Display(Name = "MimeType файла иконки :")]
    public string IconMimeType { get; set; } = "image/png";

    [DataType(DataType.Text)]
    [Display(Name = "Размер файла иконки :")]
    public uint IconFileSize { get; set; } = 1;

    [Display(Name = "Ширина иконки в px :")]
    public uint IconWidth { get; set; } = 1;

    [Display(Name = "Высота иконки в px :")]
    public uint IconHeight { get; set; } = 1;
}