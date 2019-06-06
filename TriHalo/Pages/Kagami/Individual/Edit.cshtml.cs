using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TriHaloDatabase.Kagami;

namespace TriHalo.Pages.Kagami.Individual
{
    public class EditModel : PageModel
    {
        private readonly TriHaloDatabase.Kagami.KagamiContext _context;

        public EditModel(TriHaloDatabase.Kagami.KagamiContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Individual).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndividualExists(Individual.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool IndividualExists(int id)
        {
            return _context.Individuals.Any(e => e.ID == id);
        }
    }
}
