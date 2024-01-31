using Doador.Domain.Commands;
using Doador.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Doador.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoadorController : ControllerBase
    {
        private readonly IDoadorService _doadorService;
        public DoadorController(IDoadorService doadorService)
        {
            _doadorService = doadorService;
        }
        [HttpGet]
        [Route("GetAsync")]
        public async Task<IEnumerable<DoadorCommand>> GetAsync()
        {
            return await _doadorService.GetAsync();
        }
        [HttpPost]
        [Route("PostAsync")]
        public async Task<string> PostAsync([FromBody]DoadorCommand command)
        {
            return await _doadorService.PostAsync(command);
        }
    }
}
