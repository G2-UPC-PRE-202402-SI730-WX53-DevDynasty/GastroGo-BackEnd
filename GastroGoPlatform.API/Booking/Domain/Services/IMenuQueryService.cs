using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Queries;

namespace GastroGoPlatform.API.Booking.Domain.Services
{
    public interface IMenuQueryService
    {
        Task<Menu?> Handle(GetMenuByIdQuery query);
        Task<IEnumerable<Menu>> Handle(GetAllMenusQuery query);
    }
}
