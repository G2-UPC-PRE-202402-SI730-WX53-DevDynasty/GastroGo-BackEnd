
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
        
        public Role(int userId, ERoles roleType)
        {
            UserId = userId;
            RoleType = roleType;
        }
        
        public static Role AssignRole(int userId, ERoles roleType)
        {
            return new Role(userId, roleType);
        }
        
    }
}