using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Commands;
using GastroGoPlatform.API.Booking.Domain.Repositories;
using GastroGoPlatform.API.Booking.Domain.Services;
using GastroGoPlatform.API.Shared.Domain.Repositories;

namespace GastroGoPlatform.API.Booking.Application.Internal;

public class TeamActivityCommandService(ITeamActivityRepository teamActivityRepository, IUnitOfWork unitOfWork): ITeamActivityCommandService
{
    public async Task<TeamActivity?> Handle(CreateTeamCommand command)
    {
        var teamActivity = new TeamActivity(command.Name);
        await teamActivityRepository.AddAsync(teamActivity);
        await unitOfWork.CompleteAsync();
        return teamActivity;

    }
}