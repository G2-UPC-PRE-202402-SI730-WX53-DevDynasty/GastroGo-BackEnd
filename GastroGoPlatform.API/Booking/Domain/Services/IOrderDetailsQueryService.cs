using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Queries;

namespace GastroGoPlatform.API.Booking.Domain.Services
{
    public interface IOrderDetailsQueryService
    {
        Task<IEnumerable<OrderDetails>> Handle(GetAllOrderDetailsQuery query);
        Task<OrderDetails?> Handle(GetOrderDetailByIdQuery query);
    }
}