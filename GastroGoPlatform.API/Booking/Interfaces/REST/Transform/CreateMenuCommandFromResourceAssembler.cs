using GastroGoPlatform.API.Booking.Domain.Model.Commands;
using GastroGoPlatform.API.Booking.Interfaces.REST.Resources;

namespace GastroGoPlatform.API.Booking.Interfaces.REST.Transform
{
    public static class CreateMenuCommandFromResourceAssembler
    {
        public static CreateMenuCommand ToCommandFromResource(CreateMenuResource resource)
        {
            var products = resource.Products
                .Select(p => new CreateProductCommand(p.Name, p.Category, p.Stock, p.Price))
                .ToList();

            return new CreateMenuCommand(resource.Name, products);
        }
    }
}
