using GastroGoPlatform.API.Booking.Interfaces.REST.Resources;

namespace GastroGoPlatform.API.Booking.Interfaces.REST.Transform
{
    /// <summary>
    ///     Assembles an OrderResource from an Order entity.
    ///     This class provides a method to transform domain entities into REST API resources,
    ///     enabling consistent data representation for API responses.
    /// </summary>
    public static class OrderResourceFromEntityAssembler
    {
        public static OrderResource ToResourceFromEntity(Order entity) =>
            new OrderResource(entity.OrderId,entity.DeliveryTime, entity.Hours);
    }
}