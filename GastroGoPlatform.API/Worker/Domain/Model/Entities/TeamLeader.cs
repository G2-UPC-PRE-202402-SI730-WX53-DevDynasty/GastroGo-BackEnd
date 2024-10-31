using GastroGoPlatform.API.Worker.Domain.Model.Valueobjects;
namespace GastroGoPlatform.API.Worker.Domain.Model.Entities
{
    /// TeamLeader Entity
    /// <summary>
    ///     This is the TeamLeader entity. It represents the leader of a team.
    /// </summary>
    public class TeamLeader
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public TeamRole Role { get; set; }

        public TeamLeader()
        {
            this.UserId = 0;
            this.Role = TeamRole.Leader;
        }

        public TeamLeader(int userId)
        {
            UserId = userId;
            Role = TeamRole.Leader;
        }


    }
}