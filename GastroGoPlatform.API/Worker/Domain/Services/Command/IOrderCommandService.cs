using GastroGoPlatform.API.Worker.Domain.Model.Commnads;


namespace GastroGoPlatform.API.Worker.Domain.Services.Command
{
    public interface IOrderCommandService
    {
        Task<Order?> Handle(CreateOrderCommand command);
        Task<Order?> Handle(DeleteOrderCommand command);
    }
}
