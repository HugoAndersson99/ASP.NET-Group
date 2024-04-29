using ASP.Net_GruppUPG.Objects;
using ASP.Net_GruppUPG.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_GruppUPG.Controllers
{
    [Route("api/serie")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        SerieService serieService;

        public SerieController(SerieService serieService)
        {
            this.serieService = serieService;
        }

        [HttpGet("all")]
        public List<Serie> GetAll()
        {
            return serieService.GetSeries();
        }

        [HttpGet("byid")]
        public Serie GetSerieById(int id)
        {
            return serieService.GetSerieById(id);
        }

        [HttpPost("add")]
        public ActionResult AddSerie(Serie serie)
        {
            bool success = serieService.AddSerie(serie);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut("edit")]
        public ActionResult EditSerie(Serie serie)
        {
            bool success = serieService.EditSerie(serie);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("delete")]
        public ActionResult DeleteSerie(int id)
        {
            bool success = serieService.DeleteSerieById(id);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
