using ASP.Net_GruppUPG.Objects;
using ASP.Net_GruppUPG.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.Net_GruppUPG.Pages
{

    public class SeriesModel : PageModel
    {
        private readonly SerieService serieService;

       

        public SeriesModel(SerieService serieService)
        {
            this.serieService = serieService;
        }
        public List<Serie> series { get; set; }


        [BindProperty]

        public Serie NewSerie { get; set; }



        public void OnGet()
        {
            series = serieService.GetSeries();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                serieService.AddSerie(NewSerie);
                return RedirectToPage();
            }
            return BadRequest();
        }

        public IActionResult OnPostDelete(int serieId)
        {
            var result = serieService.DeleteSerieById(serieId);
            if (!result)
            {
                return NotFound();
            }
            //series = serieService.GetSeries();
            return Page();
        }
    }
}

