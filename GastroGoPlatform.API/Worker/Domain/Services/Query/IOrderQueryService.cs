using GastroGoPlatform.API.Worker.Domain.Model.Queries;

namespace GastroGoPlatform.API.Worker.Domain.Services.Query
{
    public interface IOrderQueryService
    {
        Task<Order?> Handle(GetAllOrdersQuery query);
        Task<Order?> Handle(GetOrderByIdQuery query);
        Task<Order?> Handle(GetOrderByCustomerIdQuery query);
    }
}
