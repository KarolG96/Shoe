using Shoe.Services.ProductAPI.Models;
using Shoe.Services.ProductAPI.Models.Dtos;

namespace Shoe.Services.ProductAPI.Repository
{
    public interface IProductRepository
	{
		Task<IEnumerable<ProductDto>> GetProducts();
		Task<ProductDto> GetProductById(int productId);
		Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
		Task<bool> DeleteProduct(int productId);
	}
}
