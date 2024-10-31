
using GastroGoPlatform.API.Booking.Domain.Model.Entities;
using GastroGoPlatform.API.Shared.Domain.Repositories;

namespace GastroGoPlatform.API.Booking.Domain.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsByMenuIdAsync(int menuId);
    }
}
