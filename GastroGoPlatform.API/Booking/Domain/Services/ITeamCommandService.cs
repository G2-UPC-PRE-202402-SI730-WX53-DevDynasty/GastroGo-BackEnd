using GastroGoPlatform.API.Worker.Domain.Model.Aggregates;
using GastroGoPlatform.API.Worker.Domain.Model.Commands;

namespace GastroGoPlatform.API.Worker.Domain.Services
{
    public interface ITeamCommandService
    {
        Task<Team?> Handle(CreateTeamCommand command);

        Task<Team?> Handle(AddMemberCommand command);
    }
}
