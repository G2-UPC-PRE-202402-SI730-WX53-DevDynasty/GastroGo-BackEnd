using GastroGoPlatform.API.Booking.Interfaces.REST.Resources;

namespace GastroGoPlatform.API.Booking.Interfaces.REST.Transform
{
    public static class OrderResourceFromEntityAssembler
    {
        public static OrderResource ToResourceFromEntity(Order entity) =>
            new OrderResource(entity.OrderId);
    }
}
