using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Queries;
using GastroGoPlatform.API.Booking.Domain.Repositories;
using GastroGoPlatform.API.Booking.Domain.Services;
using GastroGoPlatform.API.Shared.Domain.Repositories;

namespace GastroGoPlatform.API.Booking.Application.Internal
{
    public class OrderDetailsQueryService(IOrderDetailsRepository orderDetailsRepository, IUnitOfWork unitOfWork) : IOrderDetailsQueryService
    {
        public async Task<IEnumerable<OrderDetails>> Handle(GetAllOrderDetailsQuery query)
        {
            var orderDetails = await orderDetailsRepository.ListAsync();
            await unitOfWork.CompleteAsync();

            return orderDetails;
        }

        public async Task<OrderDetails?> Handle(GetOrderDetailByIdQuery query)
        {
            var orderDetail = await orderDetailsRepository.FindByAsync(query.Id);
            await unitOfWork.CompleteAsync();

            return orderDetail;
        }
    }
}