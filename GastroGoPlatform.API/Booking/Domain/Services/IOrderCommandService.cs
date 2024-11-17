using GastroGoPlatform.API.Booking.Domain.Model.Commands;

namespace GastroGoPlatform.API.Booking.Domain.Services
{
    public interface IOrderCommandService
    {
        Task<Order?> Handle(CreateOrderCommand command);
        Task<Order?> Handle(DeleteOrderCommand command);
    }
}
