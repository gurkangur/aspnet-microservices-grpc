using Basket.API.Models;
using Basket.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Basket.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICatalogService _catalogService;

        public WeatherForecastController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogItem>> Get(int id)
        {
            return await _catalogService.GetCatalogItemAsync(id);
        }

    }
}
