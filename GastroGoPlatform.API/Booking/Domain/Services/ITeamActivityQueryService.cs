using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Queries;

namespace GastroGoPlatform.API.Booking.Domain.Services
{
    public interface ITeamActivityQueryService
    {
        Task<IEnumerable<TeamActivity>> Handle(GetAllTeamsQuery query); 
        Task<TeamActivity?> Handle(GetTeamByIdQuery query);
    }
}
