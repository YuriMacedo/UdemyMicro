using GeekShoppingProductAPI.Data.ValueObjects;
using GeekShoppingProductAPI.Models;

namespace GeekShoppingProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> GetAll();
        Task<ProductVO> FindById(long id);
        Task<ProductVO> Create(ProductVO product);
        Task<ProductVO> Update(ProductVO product);
        Task<bool> DeleteById(long id);
    }
}
