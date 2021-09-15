using Grpc.Core;
using System.Threading.Tasks;
using static Catalog.Catalog;

namespace Catalog.API.Grpc
{
    public class CatalogService : CatalogBase
    {
        public override async Task<CatalogItemResponse> GetItemById(CatalogItemRequest request, ServerCallContext context)
        {
            return new CatalogItemResponse()
            {
                Id = request.Id,
                Name = "Test"
            };
        }
    }
}
