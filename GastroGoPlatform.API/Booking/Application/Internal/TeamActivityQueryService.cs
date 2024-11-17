using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Queries;
using GastroGoPlatform.API.Booking.Domain.Repositories;
using GastroGoPlatform.API.Booking.Domain.Services;

namespace GastroGoPlatform.API.Booking.Application.Internal;

public class TeamActivityQueryService(ITeamActivityRepository teamActivityRepository) : ITeamActivityQueryService
{
    public async Task<IEnumerable<TeamActivity>> Handle(GetAllTeamsQuery query)
    {
        return await teamActivityRepository.ListAsync();
    }

    public async Task<TeamActivity?> Handle(GetTeamByIdQuery query)
    {
        return await teamActivityRepository.FindByTeamIdAsync(query.TeamId);
    }
}