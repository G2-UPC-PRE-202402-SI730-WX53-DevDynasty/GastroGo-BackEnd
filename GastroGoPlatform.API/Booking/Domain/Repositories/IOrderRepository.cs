using GastroGoPlatform.API.Shared.Domain.Repositories;

namespace GastroGoPlatform.API.Booking.Domain.Repositories
{
    /// IOrderRepository
    /// <summary>
    ///     Defines the repository interface for managing orders in the booking system.
    ///     Provides methods to retrieve orders by customer ID or order ID.
    /// </summary>
    public interface IOrderRepository: IBaseRepository<Order>
    {
        Task<IEnumerable<Order>> FindByCustomerIdAsync(int customerId);
        Task<Order?> FindByOrderIdAsync(int orderId);
    }
}



