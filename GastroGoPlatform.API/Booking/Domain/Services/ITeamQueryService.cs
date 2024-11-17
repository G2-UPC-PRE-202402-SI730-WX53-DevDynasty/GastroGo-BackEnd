using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Queries;

namespace GastroGoPlatform.API.Booking.Domain.Services
{
    public interface ITeamQueryService
    {
        Task<IEnumerable<Team>> Handle(GetAllTeamsByIdQuery query); 
        Task<IEnumerable<Team>> Handle(GetAllMembersByTeamIdQuery query);
        Task<Team?> Handle(GetTeamByIdQuery query);
    }
}
