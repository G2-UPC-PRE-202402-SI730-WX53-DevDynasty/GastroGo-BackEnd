using GastroGoPlatform.API.Worker.Interfaces.REST.Resources;

namespace GastroGoPlatform.API.Worker.Interfaces.REST.Transform
{
    public static class OrderResourceFromEntityAssembler
    {
        public static OrderResource ToResourceFromEntity(Order entity) =>
            new OrderResource(entity.OrderId);
    }
}
