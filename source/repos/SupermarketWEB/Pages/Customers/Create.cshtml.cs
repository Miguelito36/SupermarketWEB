using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Costomers
{
	public class CreateModel : PageModel
	{
		private readonly SumpermarketContext _context;

		public CreateModel(SumpermarketContext context)
		{
			_context = context;
		}
		public IActionResult OnGet()
		{
			return Page();
		}

		[BindProperty]
		public Customer Customer { get; set; } = default!;

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid || _context.Categories == null || Customer == null)
			{
				var errors = ModelState.Values.SelectMany(m => m.Errors);
				foreach (var error in errors)
				{
					Console.WriteLine(error.ErrorMessage);
				}
				return Page();
			}

			_context.Customers.Add(Customer);
			await _context.SaveChangesAsync();

			return RedirectToPage("./Index");
		}
	}
}