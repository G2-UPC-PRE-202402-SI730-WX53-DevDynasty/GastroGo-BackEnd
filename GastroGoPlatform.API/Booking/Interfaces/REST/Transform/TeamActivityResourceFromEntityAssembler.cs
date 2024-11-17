using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Interfaces.REST.Resources;

namespace GastroGoPlatform.API.Booking.Interfaces.REST.Transform;

public static class TeamActivityResourceFromEntityAssembler
{
    public static TeamActivityResource ToResourceFromEntity(TeamActivity entity)
    {
        return new TeamActivityResource(
            entity.TeamId,
            entity.TeamName,
            entity.Roles
            );
    }
}