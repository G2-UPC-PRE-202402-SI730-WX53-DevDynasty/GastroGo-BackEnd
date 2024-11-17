using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Shared.Domain.Repositories;

namespace GastroGoPlatform.API.Booking.Domain.Repositories
{
    public interface ITeamRepository : IBaseRepository<TeamActivities>
    {
        Task<IEnumerable<TeamActivities>> GetAllTeamsByIdAsync(int id);
        Task<IEnumerable<TeamActivities>> GetAllMembersByTeamIdAsync(int id);
        Task<TeamActivities?> GetTeamByIdAsync(int id);
    }
}
