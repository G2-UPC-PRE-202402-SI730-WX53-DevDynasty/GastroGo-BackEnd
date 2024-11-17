using GastroGoPlatform.API.Booking.Domain.Repositories;
using GastroGoPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using GastroGoPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GastroGoPlatform.API.Booking.Infrastructure.Repositories
{
    public class OrderRepository(AppDbContext context) : BaseRepository<Order>(context), IOrderRepository
    {

        public async Task<IEnumerable<Order>> FindByCustomerIdAsync(int customerId)
        {
            return await context.Set<Order>().Where(o => o.CustomerId == customerId).ToListAsync();
        }

        public async Task<Order?> FindByOrderIdAsync(int orderId)
        {
            return await context.Set<Order>().FirstOrDefaultAsync(o => o.OrderId == orderId);
        }
    }
    
}



