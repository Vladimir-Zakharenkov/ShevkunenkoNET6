using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SandBox.Pages
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; } = null!;
    }

    public class MapDataToColOfSelectListItemModel : PageModel
    {
        readonly List<Author> authorList = new()
            {
                new Author() { AuthorId = 1, Name = "��������"},
                new Author() { AuthorId = 2, Name = "ϸ��"},
                new Author() { AuthorId = 3, Name = "����"}
            };
        public List<SelectListItem> Options { get; set; } = null!;

        public void OnGet()
        {
            Options = authorList.Select(a =>
                                  new SelectListItem
                                  {
                                      Value = a.Name.ToString(),
                                      Text = a.AuthorId.ToString()
                                  }).ToList();
        }

        public void OnPost()
        {
            Options = authorList.Select(a =>
                                  new SelectListItem
                                  {
                                      Value = a.Name.ToString(),
                                      Text = a.AuthorId.ToString()
                                  }).ToList();
        }
    }
}
