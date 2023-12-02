using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Authors
{
    public class AuthorsModel : PageModel
    {
        private readonly IAuthorsRepository __db;

        public AuthorsModel(IAuthorsRepository db)
        {
            __db = db;
        }

        public IEnumerable<Author> Authors { get; set; }

        public void OnGet()
        {
            Authors = __db.GetAllAuthors();
        }
    }
}

