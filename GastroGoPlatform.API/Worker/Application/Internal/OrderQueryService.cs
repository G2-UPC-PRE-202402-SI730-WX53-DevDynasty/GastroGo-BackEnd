using GastroGoPlatform.API.Booking.Domain.Repositories;
using GastroGoPlatform.API.Shared.Domain.Repositories;
using GastroGoPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using GastroGoPlatform.API.Worker.Domain.Model.Commnads;
using GastroGoPlatform.API.Worker.Domain.Model.Queries;
using GastroGoPlatform.API.Worker.Domain.Repositories;
using GastroGoPlatform.API.Worker.Domain.Services.Command;
using GastroGoPlatform.API.Worker.Domain.Services.Query;
using GastroGoPlatform.API.Worker.Infrastructure.Repositories;

namespace GastroGoPlatform.API.Worker.Application.Internal
{
    public class OrderQueryService(IOrderRepository orderRepository, IUnitOfWork unitOfWork) : IOrderQueryService
    {
        public async Task<IEnumerable<Order>> Handle(GetAllOrdersQuery query)
        {
            var orders = await orderRepository.ListAsync();
            await unitOfWork.CompleteAsync();
            return orders;
        }

        public async Task<Order?> Handle(GetOrderByIdQuery query)
        {
            var order = await orderRepository.FindByOrderIdAsync(query.Id);
            await unitOfWork.CompleteAsync();
            return order;
        }

        public async Task<IEnumerable<Order>> Handle(GetOrderByCustomerIdQuery query)
        {
            var orders = await orderRepository.FindByCustomerIdAsync(query.CustomerId);
            await unitOfWork.CompleteAsync();
            return orders;
        }
    }

}
