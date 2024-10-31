using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;


namespace SupermarketWEB.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly SumpermarketContext _context;

        public IndexModel(SumpermarketContext context)
        {
            _context = context;
        }

        public IList<Category> Categories { get; set; } = default!;

        public async void OnGetAsync()
        {
            if (_context.Categories != null)
            {
                Categories = await _context.Categories.ToListAsync();
            }
        }
    }    
}
