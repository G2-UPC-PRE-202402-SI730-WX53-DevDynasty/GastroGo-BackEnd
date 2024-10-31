using GastroGoPlatform.API.Shared.Domain.Repositories;
using GastroGoPlatform.API.Worker.Domain.Model.Commnads;
using GastroGoPlatform.API.Worker.Domain.Model.Queries;
using GastroGoPlatform.API.Worker.Domain.Repositories;
using GastroGoPlatform.API.Worker.Domain.Services.Command;
using GastroGoPlatform.API.Worker.Domain.Services.Query;

namespace GastroGoPlatform.API.Worker.Application.Internal
{
    public class OrderQueryService : IOrderQueryService
    {
        public Task<IEnumerable<Order>> Handle(GetAllOrdersQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<Order?> Handle(GetOrderByIdQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<Order?> Handle(GetOrderByCustomerIdQuery query)
        {
            throw new NotImplementedException();
        }
    }

}
