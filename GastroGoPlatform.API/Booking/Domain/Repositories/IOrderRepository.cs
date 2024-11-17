using GastroGoPlatform.API.Shared.Domain.Repositories;

namespace GastroGoPlatform.API.Booking.Domain.Repositories
{
    public interface IOrderRepository: IBaseRepository<Order>
    {
        Task<IEnumerable<Order>> FindByCustomerIdAsync(int customerId);
        Task<Order?> FindByOrderIdAsync(int orderId);
    }
}



