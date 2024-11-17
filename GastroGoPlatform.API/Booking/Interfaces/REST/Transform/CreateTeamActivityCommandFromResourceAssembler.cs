using GastroGoPlatform.API.Booking.Domain.Model.Commands;
using GastroGoPlatform.API.Booking.Interfaces.REST.Resources;

namespace GastroGoPlatform.API.Booking.Interfaces.REST.Transform;

public static class CreateTeamActivityCommandFromResourceAssembler
{
    public static CreateTeamActivityCommand ToCommandFromResource(CreateTeamActivityResource resource)
    {
        return new CreateTeamActivityCommand(resource.Name);
    }
}