namespace GastroGoPlatform.API.Worker.Domain.Model.Entities
{
    public class Vote
    {
        public int Id { get; set; } 
        public int LeaderId { get; }
        public int MemberId { get; }
        public int RestaurantId { get; }

    }
}
