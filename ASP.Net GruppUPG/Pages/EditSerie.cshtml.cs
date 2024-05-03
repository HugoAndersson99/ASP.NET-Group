using ASP.Net_GruppUPG.Objects;
using ASP.Net_GruppUPG.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.Net_GruppUPG.Pages
{
    public class EditSerieModel : PageModel
    {
        private SerieService serieService;

        public EditSerieModel(SerieService serieService)
        {
            this.serieService = serieService;
        }
        [BindProperty]
        public Serie Serie { get; set; }



        public IActionResult OnGet(int id)
        {
            Serie = serieService.GetSerieById(id);

            if (Serie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var success = serieService.EditSerie(Serie);
            if (!success)
            {
                return BadRequest();
            }
            return RedirectToPage("/Series");
        }
    }
}
