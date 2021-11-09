using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaymentMarketBackend.Core.Interfaces.Services;

namespace PaymentMarketBackend.Api.Controllers
{
    
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AnniosController : ControllerBase
    {
        private readonly IAnnioService _annioService;
        public AnniosController(IAnnioService annioService)
        {
            _annioService = annioService;
        }
        // GET
        [HttpGet("GetAllAnnios")]
        public async Task<IActionResult> GetAllAnnios()
        {
            var result = await _annioService.GetAllAnnio();
            return Ok(new
            {
                result
            });
        }
    }
}