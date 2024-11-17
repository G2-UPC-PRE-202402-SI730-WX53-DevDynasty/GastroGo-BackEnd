using GastroGoPlatform.API.Booking.Domain.Model.Commands;
using GastroGoPlatform.API.Booking.Domain.Model.Entities;
using GastroGoPlatform.API.Booking.Domain.Model.ValueObjects;

namespace GastroGoPlatform.API.Booking.Domain.Model.Aggregates
{
    /// Team Aggregate
    /// <summary>
    ///     This class represents the Team Aggregate. Used to store each team and its respective leader and members. 
    /// </summary>
    public class TeamActivity
    {
        public int TeamId { get; set; } 
        public string TeamName { get; set; }
        public List<Role> Roles { get; set; }

        public TeamActivity(string teamName)
        {
            TeamName = teamName;
        }
        
        /// Add Role Method
        /// <summary>
        ///     This method adds a role to the team.
        /// </summary>
        /// <param name="role">To verify the role that is about to be added.</param>
        /// <exception cref="InvalidOperationException">This is an exception to verify if the user already exists.</exception>

        public void AddRole(Role role)
        {
            if (Roles.Any(r => r.UserId == role.UserId))
            {
                throw new InvalidOperationException($"The user with ID {role.UserId} is already in the team.");
            }
            Roles.Add(role);
        }
    }
}