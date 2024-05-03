using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.Net_GruppUPG.Objects;

namespace ASP.Net_GruppUPG.Pages
{
    public class EditSeriesModel : PageModel
    {
        private readonly ASP.Net_GruppUPG.Objects.DatabaseContext _context;

        public EditSeriesModel(ASP.Net_GruppUPG.Objects.DatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Serie Serie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serie =  await _context.Serie.FirstOrDefaultAsync(m => m.SerieId == id);
            if (serie == null)
            {
                return NotFound();
            }
            Serie = serie;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Update(Serie);

            await _context.SaveChangesAsync();
            //_context.Attach(Serie).State = EntityState.Modified;


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SerieExists(Serie.SerieId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("Series");
        }

        private bool SerieExists(int id)
        {
            return _context.Serie.Any(e => e.SerieId == id);
        }
    }
}
