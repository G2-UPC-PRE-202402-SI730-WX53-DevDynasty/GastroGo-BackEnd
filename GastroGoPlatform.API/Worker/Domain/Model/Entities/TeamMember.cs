using GastroGoPlatform.API.Worker.Domain.Model.Valueobjects;

namespace GastroGoPlatform.API.Worker.Domain.Model.Entities
{
    /// TeamMember Entity
    /// <summary>
    ///     This is the TeamMember entity. It represents a member of a team.
    /// </summary>
    public class TeamMember
    {
        public int MemberId { get; private set; }
        public int UserId { get; private set; }
        public TeamRole Role { get; private set; }


        public TeamMember(int userId)
        {
            UserId = userId;
            Role = TeamRole.Member;
        }
    }
}
