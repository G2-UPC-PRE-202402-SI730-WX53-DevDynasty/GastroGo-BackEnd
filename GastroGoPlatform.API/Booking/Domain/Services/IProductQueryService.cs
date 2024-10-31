using GastroGoPlatform.API.Booking.Domain.Model.Entities;

namespace GastroGoPlatform.API.Booking.Domain.Services
{
    public interface IProductQueryService
    {
        Task<Product> GetProductByIdAsync(int menuId, int productId);
        Task<IEnumerable<Product>> GetProductsByMenuIdAsync(int menuId);
    }
}
