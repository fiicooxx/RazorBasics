using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWeb.Data;
using RazorWeb.Model;

namespace RazorWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _appDbContext;
        public IEnumerable<Category> Categories { get; set; }
        public IndexModel(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void OnGet()
        {
            Categories = _appDbContext.Categories;
        }
    }
}
