namespace GastroGoPlatform.API.Booking.Domain.Model.Queries
{
    /// <summary>
    ///   Query to get order by id
    /// </summary>
    /// <param name="OrderId"></param>
    public record GetOrderByIdQuery(int OrderId)
    {
    }
}