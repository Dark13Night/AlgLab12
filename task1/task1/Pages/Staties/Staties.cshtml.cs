using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Staties
{
    public class StatiesModel : PageModel
    {
        private IStatiesRepository __db;

        public StatiesModel(IStatiesRepository db)
        {
            __db = db;
        }

        public IEnumerable<Statie> Staties { get; set; }

        public void OnGet()
        {
            Staties = __db.GetAllStaties();
        }
    }
}
