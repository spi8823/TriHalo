using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TriHaloDatabase.Kagami;

namespace TriHalo.Pages.Kagami
{
    public class CreateModel : PageModel
    {
        private readonly TriHaloDatabase.Kagami.KagamiContext _context;

        public CreateModel(TriHaloDatabase.Kagami.KagamiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Individual Individual { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Individuals.Add(Individual);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}