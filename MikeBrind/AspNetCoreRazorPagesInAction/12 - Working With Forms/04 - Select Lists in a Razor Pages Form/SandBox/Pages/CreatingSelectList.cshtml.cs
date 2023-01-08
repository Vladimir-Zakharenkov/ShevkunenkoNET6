using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace SandBox.Pages
{
    public class Author2
    {
        public int AuthorId { get; set; }
        public string Name { get; set; } = null!;
    }

    public class CreatingSelectListModel : PageModel
    {
        readonly List<Author> authorList = new()
            {
                new Author() { AuthorId = 1, Name = "��������"},
                new Author() { AuthorId = 2, Name = "ϸ��"},
                new Author() { AuthorId = 3, Name = "����"}
            };

        Dictionary<string, string> authorDict = new()
        {
            {"���1", "���2"},
            {"����1", "����2"},
            {"����1", "����2"}
        };

        public SelectList Options { get; set; } = null!;

        public void OnGet()
        {
            Options = new SelectList(authorList, nameof(Author.AuthorId), nameof(Author.Name));

            //Options = new SelectList(authorDict, "Key", "Value");
        }

        public void OnPost()
        {
            Options = new SelectList(authorList, nameof(Author.AuthorId), nameof(Author.Name));

            //Options = new SelectList(authorDict, "Key", "Value");
        }

    }
}
