using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Shared.Domain.Repositories;

namespace GastroGoPlatform.API.Booking.Domain.Repositories
{
    public interface ITeamRepository : IBaseRepository<Team>
    {
        Task<IEnumerable<Team>> GetAllTeamsByIdAsync(int id);
        Task<IEnumerable<Team>> GetAllMembersByTeamIdAsync(int id);
        Task<Team?> GetTeamByIdAsync(int id);
    }
}
