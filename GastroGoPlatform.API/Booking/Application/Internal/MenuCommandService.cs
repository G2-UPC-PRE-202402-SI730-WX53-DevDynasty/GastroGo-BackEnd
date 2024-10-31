using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Commands;
using GastroGoPlatform.API.Booking.Domain.Model.Entities;
using GastroGoPlatform.API.Booking.Domain.Model.ValueObjects;
using GastroGoPlatform.API.Booking.Domain.Repositories;
using GastroGoPlatform.API.Booking.Domain.Services;
using GastroGoPlatform.API.Shared.Domain.Repositories;

namespace GastroGoPlatform.API.Booking.Application.Internal
{
    public class MenuCommandService(IMenuRepository menuRepository, IUnitOfWork unitOfWork) : IMenuCommandService
    {
        public async Task<Menu?> Handle(CreateMenuCommand command)
        {
            var menu = new Menu(command.Name);

            foreach (var productCommand in command.Products)
            {
                var product = new Product(
                    name: productCommand.Name,
                    category: Enum.Parse<Category>(productCommand.Category),
                    stock: productCommand.Stock
                );
                product.SetPrice(new Price(productCommand.Price));
                menu.AddProduct(product);
            }

            await menuRepository.AddAsync(menu);
            await unitOfWork.CompleteAsync();

            return menu;
        }
    }
}
