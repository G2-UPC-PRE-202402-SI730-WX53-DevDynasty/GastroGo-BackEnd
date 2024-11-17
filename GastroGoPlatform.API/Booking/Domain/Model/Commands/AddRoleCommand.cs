namespace GastroGoPlatform.API.Booking.Domain.Model.Commands
{
    public record AddRoleCommand(int TeamId, int UserId, string RoleType)
    {

    }
}