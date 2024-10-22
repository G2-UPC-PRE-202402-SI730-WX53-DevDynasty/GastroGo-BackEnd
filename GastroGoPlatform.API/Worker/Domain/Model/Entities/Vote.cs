namespace GastroGoPlatform.API.Worker.Domain.Model.Entities
{
    public class Vote
    {
        public int Id { get; set; }
        /// <summary>
        ///     Dictionary of votes for each restaurant
        /// </summary>
        public required Dictionary<string, int> Votes { get; set; }
    }
}
