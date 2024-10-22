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
        public required string TeamName { get; set; }
        public required TeamLeader Leader { get; set; }
        public required List<TeamMember> Members { get; set; }
        public Team(string teamName, TeamLeader leader)
        {
            TeamName = teamName;
            Leader = leader;
            Members = new List<TeamMember>();
        }

        public Team(CreateTeamCommand command)
        {
            this.Id = command.TeamId;
            this.TeamName = command.TeamName;
            this.Leader = new TeamLeader(command.LeaderId);
        }
        
        public void AddMember(TeamMember teamMember)
        {
            Members.Add(teamMember);
        }
        public void RemoveMember(TeamMember teamMember)
        {
            Members.Remove(teamMember);
        }
    }
}