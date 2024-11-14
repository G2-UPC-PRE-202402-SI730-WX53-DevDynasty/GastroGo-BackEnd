using GastroGoPlatform.API.Worker.Domain.Model.Aggregates;
using GastroGoPlatform.API.Worker.Domain.Model.Queries;

namespace GastroGoPlatform.API.Worker.Domain.Services
{
    public interface ITeamQueryService
    {
        Task<IEnumerable<Team>> Handle(GetAllTeamsByIdQuery query); 
        Task<IEnumerable<Team>> Handle(GetAllMembersByTeamIdQuery query);
        Task<Team?> Handle(GetTeamByIdQuery query);
    }
}
