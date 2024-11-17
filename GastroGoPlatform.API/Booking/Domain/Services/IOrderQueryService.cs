using GastroGoPlatform.API.Booking.Domain.Model.Queries;
using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;

namespace GastroGoPlatform.API.Booking.Domain.Services
{
    /// <summary>
    /// Interface for the OrderQueryService.
    /// This interface defines the contract for querying order-related data.
    /// </summary>
    public interface IOrderQueryService
    {
        Task<IEnumerable<Order>> Handle(GetAllOrdersQuery query);
        Task<Order?> Handle(GetOrderByIdQuery query);
        Task<IEnumerable<Order>> Handle(GetOrderByCustomerIdQuery query);
    }
}
