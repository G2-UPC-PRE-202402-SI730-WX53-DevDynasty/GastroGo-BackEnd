using GastroGoPlatform.API.Worker.Domain.Model.Valueobjects;
namespace GastroGoPlatform.API.Worker.Domain.Model.Entities
{
    /// TeamMember Entity
    /// <summary>
    ///     This is the TeamMember entity. It represents a member of a team.
    /// </summary>
    public class TeamMember
    {
        public Guid MemberId { get; private set; }
        public int UserId { get; private set; }
        public TeamRole Role { get; private set; }
        public TeamMember(int userId)
        {
            MemberId = Guid.NewGuid();
            UserId = userId;
            Role = TeamRole.Member;
        }
    }
}