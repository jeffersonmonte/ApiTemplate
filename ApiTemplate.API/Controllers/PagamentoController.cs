using ApiTemplate.Application.DTOs;
using ApiTemplate.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiTemplate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly IPagamentoService _pagamentoService;

        public PagamentoController(IPagamentoService pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var pagamentos = await _pagamentoService.ObterTodos();
            return Ok(pagamentos);
        }

        [HttpPost]
        public async Task<IActionResult> CriarPagamento([FromBody] PagamentoDTO pagamentoDto)
        {
            await _pagamentoService.Adicionar(pagamentoDto);
            return CreatedAtAction(nameof(ObterTodos), new { id = pagamentoDto.Id }, pagamentoDto);
        }
    }
}
