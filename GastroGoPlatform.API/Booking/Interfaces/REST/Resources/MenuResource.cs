namespace GastroGoPlatform.API.Booking.Interfaces.REST.Resources
{
    public record MenuResource(int Id, string Name, List<ProductResource> Products);
}