using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Interfaces.REST.Resources;

namespace GastroGoPlatform.API.Booking.Interfaces.REST.Transform
{
    public static class MenuResourceFromEntityAssembler
    {
        public static MenuResource ToResourceFromEntity(Menu entity) =>
            new MenuResource(entity.Id, entity.Name, entity.Products.Select(ProductResourceFromEntityAssembler.ToResourceFromEntity).ToList());
    }
}
