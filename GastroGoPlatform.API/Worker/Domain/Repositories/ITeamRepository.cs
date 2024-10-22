using GastroGoPlatform.API.Shared.Domain.Repositories;
using GastroGoPlatform.API.Worker.Domain.Model.Aggregates;

namespace GastroGoPlatform.API.Worker.Domain.Repositories
{
    public interface ITeamRepository : IBaseRepository<Team>
    {
        Task<IEnumerable<Team>> GetAllTeamsByIdAsync(int id);
        Task<IEnumerable<Team>> GetAllMembersByTeamIdAsync(int id);
        Task<Team?> GetTeamByIdAsync(int id);
    }
}
