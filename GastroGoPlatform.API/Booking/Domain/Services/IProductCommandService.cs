using GastroGoPlatform.API.Booking.Domain.Model.Commands;

namespace GastroGoPlatform.API.Booking.Domain.Services
{
    public interface IProductCommandService
    {
        Task CreateProductAsync(CreateProductCommand command);
    }
}
