using GastroGoPlatform.API.Worker.Domain.Model.Entities;
using GastroGoPlatform.API.Worker.Domain.Model.Queries;

namespace GastroGoPlatform.API.Worker.Domain.Services.Query
{
    public interface IOrderQueryService
    {
        Task<IEnumerable<Order>> Handle(GetAllOrdersQuery query);
        Task<Order?> Handle(GetOrderByIdQuery query);
        Task<IEnumerable<Order>> Handle(GetOrderByCustomerIdQuery query);
    }
}
