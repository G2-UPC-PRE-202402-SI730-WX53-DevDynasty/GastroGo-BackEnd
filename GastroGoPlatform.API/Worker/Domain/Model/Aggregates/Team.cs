using GastroGoPlatform.API.Worker.Domain.Model.Commands;
using GastroGoPlatform.API.Worker.Domain.Model.Entities;
namespace GastroGoPlatform.API.Worker.Domain.Model.Aggregates
{
    /// Team Aggregate
    /// <summary>
    ///     This class represents the Team Aggregate. Used to store each team and its respective leader and members. 
    /// </summary>
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public TeamLeader Leader { get; set; }
        public int LeaderId { get; set; }
        public required List<TeamMember> Members { get; set; }

        public Team()
        {
            this.TeamName = "";
            this.Leader = new TeamLeader();
            this.Members = new List<TeamMember>();
        }

        public Team(string teamName, int leader)
        {
            TeamName = teamName;
            LeaderId = leader;
            Members = new List<TeamMember>();
        }

        public Team(CreateTeamCommand command)
        {
            this.Id = command.TeamId;
            this.TeamName = command.TeamName;
            this.LeaderId = command.LeaderId;
        }
    }
}