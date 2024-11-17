using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Queries;

namespace GastroGoPlatform.API.Booking.Domain.Services
{
    public interface ITeamQueryService
    {
        Task<IEnumerable<TeamActivities>> Handle(GetAllTeamsByIdQuery query); 
        Task<IEnumerable<TeamActivities>> Handle(GetAllMembersByTeamIdQuery query);
        Task<TeamActivities?> Handle(GetTeamByIdQuery query);
    }
}
