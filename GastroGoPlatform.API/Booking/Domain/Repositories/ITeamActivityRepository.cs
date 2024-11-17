using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Entities;
using GastroGoPlatform.API.Shared.Domain.Repositories;

namespace GastroGoPlatform.API.Booking.Domain.Repositories
{
    public interface ITeamActivityRepository : IBaseRepository<TeamActivity>
    {
        Task<TeamActivity?> FindByTeamIdAsync(int teamId);
        Task<IEnumerable<Role>> FindRolesByTeamIdAsync(int teamId); 
        
    }
}
