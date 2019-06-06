using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TriHaloDatabase.Kagami;

namespace TriHalo.Pages.Kagami.Individual
{
    public class DeleteModel : PageModel
    {
        private readonly TriHaloDatabase.Kagami.KagamiContext _context;

        public DeleteModel(TriHaloDatabase.Kagami.KagamiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TriHaloDatabase.Kagami.Individual Individual { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Individual = await _context.Individuals.FirstOrDefaultAsync(m => m.ID == id);

            if (Individual == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Individual = await _context.Individuals.FindAsync(id);

            if (Individual != null)
            {
                _context.Individuals.Remove(Individual);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
