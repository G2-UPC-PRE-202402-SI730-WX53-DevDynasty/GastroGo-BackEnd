using GastroGoPlatform.API.Booking.Domain.Model.Entities;
using GastroGoPlatform.API.Booking.Interfaces.REST.Resources;

namespace GastroGoPlatform.API.Booking.Interfaces.REST.Transform
{
    public static class ProductResourceFromEntityAssembler
    {
        public static ProductResource ToResourceFromEntity(Product entity) =>
            new ProductResource(entity.MenuId, entity.Name, entity.Category.ToString(), entity.Stock, entity.Price.Amount);
    }
}
