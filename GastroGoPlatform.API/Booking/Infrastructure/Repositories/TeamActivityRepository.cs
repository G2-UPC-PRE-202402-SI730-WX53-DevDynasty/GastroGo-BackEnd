using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Entities;
using GastroGoPlatform.API.Booking.Domain.Repositories;
using GastroGoPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using GastroGoPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GastroGoPlatform.API.Booking.Infrastructure.Repositories;

public class TeamActivityRepository(AppDbContext context) : BaseRepository<TeamActivity>(context), ITeamActivityRepository
{
    public new async Task<TeamActivity?> FindByTeamIdAsync(int teamId) =>
    await _context.Set<TeamActivity>().Include(t => t.Roles)
        .Where(t => t.TeamId == teamId).FirstOrDefaultAsync();

    public async Task<IEnumerable<Role>> FindRolesByTeamIdAsync(int teamId)
    {
        var team = await FindByTeamIdAsync(teamId); 
        return team?.Roles ?? Enumerable.Empty<Role>();
    }
    
    public new async Task<IEnumerable<TeamActivity>> ListAsync() =>
        await _context.Set<TeamActivity>()
            .Include(t => t.Roles)
            .ToListAsync();

    public new async Task<TeamActivity?> FindByIdAsync(int id) =>
        await _context.Set<TeamActivity>()
            .Include(t => t.Roles)
            .FirstOrDefaultAsync(t => t.TeamId == id);
}