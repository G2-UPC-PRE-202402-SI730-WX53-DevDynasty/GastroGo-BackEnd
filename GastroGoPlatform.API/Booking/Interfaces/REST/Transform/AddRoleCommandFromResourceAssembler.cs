using GastroGoPlatform.API.Booking.Domain.Model.Commands;
using GastroGoPlatform.API.Booking.Domain.Model.ValueObjects;
using GastroGoPlatform.API.Booking.Interfaces.REST.Resources;

namespace GastroGoPlatform.API.Booking.Interfaces.REST.Transform;

public class AddRoleCommandFromResourceAssembler
{
    public static AddRoleCommand ToCommandFromResource(AddRoleResource resource, int teamId)
    {
        return new AddRoleCommand(teamId, resource.UserId, resource.RoleType);
    }
}