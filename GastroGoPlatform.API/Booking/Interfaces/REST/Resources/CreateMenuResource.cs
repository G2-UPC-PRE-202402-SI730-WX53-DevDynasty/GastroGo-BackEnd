namespace GastroGoPlatform.API.Booking.Interfaces.REST.Resources
{
    public record CreateMenuResource(string Name, List<CreateProductResource> Products);
}
