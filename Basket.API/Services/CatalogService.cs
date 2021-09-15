using Basket.API.Models;
using Catalog;
using System.Threading.Tasks;

namespace Basket.API.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly Catalog.Catalog.CatalogClient _client;

        public CatalogService(Catalog.Catalog.CatalogClient client)
        {
            _client = client;
        }

        public async Task<CatalogItem> GetCatalogItemAsync(int id)
        {
           var response = await _client.GetItemByIdAsync(new CatalogItemRequest { Id = id });
            return MapToCatalogItemResponse(response);
        }

        private CatalogItem MapToCatalogItemResponse(CatalogItemResponse catalogItemResponse)
        {
            return new CatalogItem
            {
                Id = catalogItemResponse.Id,
                Name = catalogItemResponse.Name
            };
        }
    }
}
