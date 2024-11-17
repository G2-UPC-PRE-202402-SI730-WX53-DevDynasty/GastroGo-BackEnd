using GastroGoPlatform.API.Booking.Domain.Model.Commands;
using GastroGoPlatform.API.Booking.Domain.Model.Entities;
using GastroGoPlatform.API.Worker.Domain.Model.Entities;

namespace GastroGoPlatform.API.Booking.Domain.Model.Aggregates
{
    /// Team Aggregate
    /// <summary>
    ///     This class represents the Team Aggregate. Used to store each team and its respective leader and members. 
    /// </summary>
    public class TeamActivities
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public TeamLeader Leader { get; set; }
        public int LeaderId { get; set; }
        public required List<TeamMember> Members { get; set; }

        public TeamActivities()
        {
            this.TeamName = "";
            this.Leader = new TeamLeader();
            this.Members = new List<TeamMember>();
        }

        public TeamActivities(string teamName, int leader)
        {
            TeamName = teamName;
            LeaderId = leader;
            Members = new List<TeamMember>();
        }

        public TeamActivities(CreateTeamCommand command)
        {
            this.Id = command.TeamId;
            this.TeamName = command.TeamName;
            this.LeaderId = command.LeaderId;
        }
    }
}