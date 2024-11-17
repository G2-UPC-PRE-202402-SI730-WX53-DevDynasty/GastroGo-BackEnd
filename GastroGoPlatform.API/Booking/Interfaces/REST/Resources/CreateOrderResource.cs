using GastroGoPlatform.API.Booking.Domain.Model.Valueobjects;

namespace GastroGoPlatform.API.Booking.Interfaces.REST.Resources
{
    /// <summary>
    ///     Represents the resource used to create a new order through the REST API.
    ///     This record defines the data structure required to create an order, including its date, status, delivery time, duration, and total price.
    /// </summary>
    /// <param name="Date">The date when the order is created.</param>
    /// <param name="Status">The current status of the order (e.g., pending, completed).</param>
    /// <param name="DeliveryTime">The estimated delivery time as a string (e.g., "15 min", "30 min").</param>
    /// <param name="Hours">The duration of the order in hours.</param>
    /// <param name="Totalprice">The total price of the order.</param>
    public record CreateOrderResource(DateTime Date, OrderStatus Status, string DeliveryTime, int Hours, decimal Totalprice);
}