using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Repositories;
using GastroGoPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using GastroGoPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace GastroGoPlatform.API.Booking.Infrastructure.Repositories
{
    public class OrderDetailsRepository(AppDbContext context) : BaseRepository<OrderDetails>(context), IOrderDetailsRepository
    {

    }
}