namespace GastroGoPlatform.API.Booking.Domain.Model.Commands
{
    public record CreateMenuCommand(string Name, List<CreateProductCommand> Products);
}
