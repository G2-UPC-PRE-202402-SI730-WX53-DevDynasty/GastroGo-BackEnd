using GastroGoPlatform.API.Worker.Domain.Model.Valueobjects;
namespace GastroGoPlatform.API.Worker.Domain.Model.Entities
{
    /// TeamMember Entity
    /// <summary>
    ///     This is the TeamMember entity. It represents a member of a team.
    /// </summary>
    public class TeamMember
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public TeamRole Role { get; private set; }

        public TeamMember()
        {
            this.UserId = 0;
            this.Role = TeamRole.Member;
        }

        public TeamMember(int userId)
        {
            UserId = userId;
            Role = TeamRole.Member;
        }
    }
}