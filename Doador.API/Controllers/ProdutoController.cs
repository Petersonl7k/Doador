using Doador.Domain.Commands;
using Doador.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Doador.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        [HttpGet]
        [Route("GetAsync")]
        public async Task<IEnumerable<ProdutoCommand>> GetAsync()
        {
            return await _produtoService.GetAsync();
        }
        [HttpPost]
        [Route("PostAsync")]
        public async Task<string> PostAsync([FromBody] ProdutoCommand command)
        {
            return await _produtoService.PostAsync(command);
        }
        [HttpPut]
        [Route("UpdateAsync")]
        public async Task<string> UpdateAsync([FromBody] ProdutoCommand command)
        {
            return await _produtoService.UpdateAsync(command);
        }
    }
}
