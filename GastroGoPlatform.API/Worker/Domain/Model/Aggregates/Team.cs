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
        
    }
}