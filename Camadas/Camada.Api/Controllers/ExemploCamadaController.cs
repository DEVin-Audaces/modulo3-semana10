using Camada.Api.Pattners.Adpter;
using Camada.Api.Pattners.Command;
using Camada.Api.Pattners.Singleton;
using Camada.Negocio;
using Camada.Negocio.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Camada.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExemploCamadaController : ControllerBase
    {
        private readonly IExemploNegocio exemploNegocio;

        public ExemploCamadaController(IExemploNegocio exemploNegocio)
        {
            this.exemploNegocio = exemploNegocio;
        }

        [HttpPost]
        [Route("Post")]
        public ActionResult<int> Post(PizzaDto dto)
        {
            return Ok(exemploNegocio.Save(dto));
        }
    }
}
