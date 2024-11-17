namespace GastroGoPlatform.API.Booking.Domain.Model.Commands
{
    /// <summary>
    ///     Command to delete an order
    /// </summary>
    /// 
    /// <param name="OrderId"></param>
    public record  DeleteOrderCommand (int OrderId)
    {

    }
}