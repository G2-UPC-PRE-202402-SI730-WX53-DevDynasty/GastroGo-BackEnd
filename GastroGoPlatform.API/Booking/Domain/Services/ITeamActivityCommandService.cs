using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Commands;

namespace GastroGoPlatform.API.Booking.Domain.Services
{
    public interface ITeamActivityCommandService
    {
        Task<TeamActivity?> Handle(CreateTeamActivityCommand command);
        Task<TeamActivity?> Handle(AddRoleCommand command);
    }
}
