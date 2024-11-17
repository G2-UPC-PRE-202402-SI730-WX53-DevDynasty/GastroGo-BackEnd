using GastroGoPlatform.API.Booking.Domain.Model.Commands;
using GastroGoPlatform.API.Booking.Domain.Model.Valueobjects;
using GastroGoPlatform.API.Booking.Interfaces.REST.Resources;

namespace GastroGoPlatform.API.Booking.Interfaces.REST.Transform
{
    /// <summary>
    ///     Assembles a CreateOrderCommand from a CreateOrderResource.
    ///     This class provides a method to transform incoming REST API resources into domain commands, 
    ///     enabling seamless communication between the REST layer and the domain layer.
    /// </summary>
    public static class CreateOrderCommandFromResourceAssembler
    {
        public static CreateOrderCommand ToCommandFromResource(CreateOrderResource resource) =>
            new CreateOrderCommand(DateTime.Now, OrderStatus.Pending, resource.DeliveryTime, resource.Hours, resource.Totalprice);
    }
}