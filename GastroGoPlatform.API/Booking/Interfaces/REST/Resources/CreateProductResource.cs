namespace GastroGoPlatform.API.Booking.Interfaces.REST.Resources
{
    public record CreateProductResource(string Name, string Category, int Stock, decimal Price);
}
