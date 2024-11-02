using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Costomers
{
    public class IndexModel : PageModel
    {
        private readonly SumpermarketContext _context;

        public IndexModel(SumpermarketContext context)
        {
            _context = context;
        }

        public IList<Customer> Costumers { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Customers != null)
            {
                Costumers = await _context.Customers.ToListAsync();
            }
        }
    }
}
