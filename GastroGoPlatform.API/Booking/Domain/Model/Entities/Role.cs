
using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace GastroGoPlatform.API.Booking.Domain.Model.Entities
{
    /// Role Entity
    /// <summary>
    ///     This represents the Role Entity. Used to store the roles of team leaders or members.
    ///     This defines
    /// </summary>
    public class Role
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public ERoles RoleType { get; set; }
        
        public int TeamId { get; set; }
        public TeamActivity TeamActivity { get; set; }
        
        public Role(int userId, ERoles roleType, int teamId)
        {
            UserId = userId;
            RoleType = roleType;
            TeamId = teamId;
        }
        
        public static Role AssignRole(int userId, ERoles roleType, int teamId)
        {
            return new Role(userId, roleType, teamId);
        }
        
    }
}