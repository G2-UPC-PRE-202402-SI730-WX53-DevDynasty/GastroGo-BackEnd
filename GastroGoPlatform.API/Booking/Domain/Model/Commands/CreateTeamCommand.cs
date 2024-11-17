namespace GastroGoPlatform.API.Booking.Domain.Model.Commands
{
    /// <summary>
    ///     Command to create a team by the leader.
    /// </summary>
    /// <param name="TeamId">Id from the Team</param>
    /// <param name="TeamName">Name of the Team</param>
    /// <param name="LeaderId">Id of the creator of the Team</param>
    public record CreateTeamCommand(int TeamId, string TeamName, int LeaderId) { }
}