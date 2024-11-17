namespace GastroGoPlatform.API.Booking.Domain.Model.Commands
{
    /// AddRoleCommand
    /// <summary>
    /// This is the command for adding a role to a user in a team.
    /// </summary>
    /// <param name="TeamId"></param>
    /// <param name="UserId"></param>
    /// <param name="RoleType"></param>
    public record AddRoleCommand(int TeamId, int UserId, string RoleType)
    {

    }
}