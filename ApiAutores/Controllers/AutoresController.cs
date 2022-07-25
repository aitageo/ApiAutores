using ApiAutores.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ApiAutores.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>() {
                new Autor() {Id=1 ,Nombre ="Alfonso" },
                new Autor() {Id=2 ,Nombre ="Gloria" }
            };
        }
    }
}
