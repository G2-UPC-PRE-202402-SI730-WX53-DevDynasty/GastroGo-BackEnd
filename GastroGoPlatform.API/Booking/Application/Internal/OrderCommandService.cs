using GastroGoPlatform.API.Worker.Domain.Model.Commnads;
using GastroGoPlatform.API.Worker.Domain.Services.Command;

namespace GastroGoPlatform.API.Worker.Application.Internal
{
    public class OrderCommadService : IOrderCommandService
    {
        public Task<Order?> Handle(CreateOrderCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<Order?> Handle(DeleteOrderCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
