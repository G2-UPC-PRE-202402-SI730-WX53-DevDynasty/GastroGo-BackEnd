using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Commands;
using GastroGoPlatform.API.Booking.Domain.Model.Entities;
using GastroGoPlatform.API.Booking.Domain.Model.ValueObjects;
using GastroGoPlatform.API.Booking.Domain.Repositories;
using GastroGoPlatform.API.Booking.Domain.Services;
using GastroGoPlatform.API.Shared.Domain.Repositories;

namespace GastroGoPlatform.API.Booking.Application.Internal;

public class TeamActivityCommandService(ITeamActivityRepository teamActivityRepository, IUnitOfWork unitOfWork): ITeamActivityCommandService
{
    public async Task<TeamActivity?> Handle(CreateTeamActivityCommand command)
    {
        var teamActivity = new TeamActivity(command.Name);
        await teamActivityRepository.AddAsync(teamActivity);
        await unitOfWork.CompleteAsync();
        return teamActivity;

    }

    public async Task<TeamActivity?> Handle(AddRoleCommand command)
    {
        var team = await teamActivityRepository.FindByTeamIdAsync(command.TeamId);
        if (team == null)
        {
            throw new InvalidOperationException("Team not found.");
        }
        
        var role = Role.AssignRole(command.UserId, Enum.Parse<ERoles>(command.RoleType));
        team.AddRole(role);
        await unitOfWork.CompleteAsync();
        
        return team;
    }
}