using AbbyWeb.Data;
using AbbyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    public class indexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<Category> categories { get; set; }

        public indexModel(ApplicationDbContext db)
        {
            _db= db;
        }
        public void OnGet()
        {
            categories = _db.Category;
        }
    }
}
