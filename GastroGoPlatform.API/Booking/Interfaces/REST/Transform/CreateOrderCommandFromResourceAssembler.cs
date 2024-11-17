using GastroGoPlatform.API.Booking.Domain.Model.Commands;
using GastroGoPlatform.API.Booking.Interfaces.REST.Resources;

namespace GastroGoPlatform.API.Booking.Interfaces.REST.Transform
{
    public static class CreateOrderCommandFromResourceAssembler
    {
        public static CreateOrderCommand ToCommandFromResource(CreateOrderResource resource) =>
            new CreateOrderCommand(resource.OrderId);
    }
}
