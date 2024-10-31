using GastroGoPlatform.API.Worker.Domain.Model.Commnads;
using GastroGoPlatform.API.Worker.Interfaces.REST.Resources;

namespace GastroGoPlatform.API.Worker.Interfaces.REST.Transform
{
    public static class CreateOrderCommandFromResourceAssembler
    {
        public static CreateOrderCommand ToCommandFromResource(CreateOrderResource resource) =>
            new CreateOrderCommand(resource.OrderId);
    }
}
