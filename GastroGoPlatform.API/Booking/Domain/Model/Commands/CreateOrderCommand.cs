using GastroGoPlatform.API.Booking.Domain.Model.Valueobjects;

namespace GastroGoPlatform.API.Booking.Domain.Model.Commands
{
    /// <summary>
    ///     This is the CreateOrderCommand record. 
    ///     It represents the command used to create an order in the booking system.
    /// </summary>
    /// 
    /// <param name="Date"></param>
    /// <param name="Status"></param>
    /// <param name="DeliveryTime"></param>
    /// <param name="Hours"></param>
    /// <param name="TotalPrice"></param>
    public record CreateOrderCommand(DateTime Date, OrderStatus Status, string DeliveryTime, int Hours, decimal TotalPrice )
    {

    }
}