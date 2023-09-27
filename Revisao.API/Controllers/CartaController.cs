using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartaController : ControllerBase
    {
        private readonly ICartaService _cartaService;

        public CartaController(ICartaService cartaService)
        {
            _cartaService = cartaService;
        }

        [HttpPost]
        public IActionResult Post(NovoRegistraCartaViewModel registraCartaViewModel)
        {
            _cartaService.Adicionar(registraCartaViewModel);
            return Ok("Carta registrada com sucesso");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_cartaService.ObterTodos());

        }
    }
}
