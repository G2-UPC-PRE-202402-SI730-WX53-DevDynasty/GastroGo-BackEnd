using GastroGoPlatform.API.Booking.Domain.Model.Commands;
using GastroGoPlatform.API.Booking.Domain.Services;

namespace GastroGoPlatform.API.Booking.Application.Internal
{
    public class OrderCommadService : IOrderCommandService
    {
        public Task<Order?> Handle(CreateOrderCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<Order?> Handle(DeleteOrderCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
