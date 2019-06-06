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
    public class IndexModel : PageModel
    {
        private readonly TriHaloDatabase.Kagami.KagamiContext _context;

        public IndexModel(TriHaloDatabase.Kagami.KagamiContext context)
        {
            _context = context;
        }

        public IList<TriHaloDatabase.Kagami.Individual> Individual { get;set; }

        public async Task OnGetAsync()
        {
            Individual = await _context.Individuals.ToListAsync();
        }
    }
}
