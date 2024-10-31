using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Shared.Domain.Repositories;

namespace GastroGoPlatform.API.Booking.Domain.Repositories
{
    public interface IMenuRepository : IBaseRepository<Menu>
    {
        IQueryable<Menu> Query();
    }
}
