using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TriHaloDatabase.Kagami;

namespace TriHalo.Pages.Kagami
{
    public class DetailsModel : PageModel
    {
        private readonly TriHaloDatabase.Kagami.KagamiContext _context;

        public DetailsModel(TriHaloDatabase.Kagami.KagamiContext context)
        {
            _context = context;
        }

        public Individual Individual { get; set; }

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
    }
}
