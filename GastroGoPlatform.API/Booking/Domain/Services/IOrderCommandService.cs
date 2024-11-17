using GastroGoPlatform.API.Booking.Domain.Model.Commands;

namespace GastroGoPlatform.API.Booking.Domain.Services
{
    /// Interface for order command service
    /// <summary>
    ///    Service to handle order commands
    /// </summary>
    public interface IOrderCommandService
    {
        Task<Order?> Handle(CreateOrderCommand command);
        Task<Order?> Handle(DeleteOrderCommand command);
    }
}
