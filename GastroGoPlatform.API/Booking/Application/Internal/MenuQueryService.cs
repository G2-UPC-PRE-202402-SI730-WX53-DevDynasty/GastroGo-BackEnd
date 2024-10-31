using Microsoft.EntityFrameworkCore;
using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Queries;
using GastroGoPlatform.API.Booking.Domain.Repositories;
using GastroGoPlatform.API.Booking.Domain.Services;
using GastroGoPlatform.API.Shared.Domain.Repositories;

namespace GastroGoPlatform.API.Booking.Application.Internal
{
    public class MenuQueryService(IMenuRepository menuRepository, IUnitOfWork unitOfWork) : IMenuQueryService
    {
        public async Task<Menu?> Handle(GetMenuByIdQuery query)
        {
            var menu = await menuRepository.Query()
                .Include(m => m.Products)
                .FirstOrDefaultAsync(m => m.Id == query.MenuId);

            await unitOfWork.CompleteAsync();
            return menu;
        }

        public async Task<IEnumerable<Menu>> Handle(GetAllMenusQuery query)
        {
            var menus = await menuRepository.Query()
                .Include(m => m.Products)
                .ToListAsync();

            await unitOfWork.CompleteAsync();
            return menus;
        }
    }
}
