namespace GastroGoPlatform.API.Booking.Domain.Model.Commands
{
    public record CreateProductCommand(string Name, string Category, int Stock, decimal Price);
}
