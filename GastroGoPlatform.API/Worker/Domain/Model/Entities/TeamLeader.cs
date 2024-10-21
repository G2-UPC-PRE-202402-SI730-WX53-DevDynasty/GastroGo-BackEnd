using GastroGoPlatform.API.Worker.Domain.Model.Valueobjects;

namespace GastroGoPlatform.API.Worker.Domain.Model.Entities
{
    /// TeamLeader Entity
    /// <summary>
    ///     This is the TeamLeader entity. It represents the leader of a team.
    /// </summary>
    public class TeamLeader
    {
        public int LeaderId { get; set; }
        public int UserId { get; set; }
        public TeamRole Role { get; set; }

        public TeamLeader(int userId)
        {
            UserId = userId;
            Role = TeamRole.Leader;
        }
    }
}
