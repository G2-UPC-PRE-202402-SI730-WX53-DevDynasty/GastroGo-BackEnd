namespace GastroGoPlatform.API.Booking.Interfaces.REST.Resources
{
    /// <summary>
    ///     Represents the resource used to retrieve or display order information through the REST API.
    ///     This record defines the structure for an order, including its ID, delivery time, and duration in hours.
    /// </summary>
    /// <param name="OrderId">The unique identifier for the order.</param>
    /// <param name="DeliveryTime">The estimated delivery time as a string (e.g., "15 min", "30 min").</param>
    /// <param name="Hours">The duration of the order in hours.</param>
    public record OrderResource(int OrderId, string DeliveryTime, int Hours);
   
}