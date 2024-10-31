namespace GastroGoPlatform.API.Booking.Interfaces.REST.Resources
{
    public record ProductResource(int Id, string Name, string Category, int Stock, decimal Price);
}
