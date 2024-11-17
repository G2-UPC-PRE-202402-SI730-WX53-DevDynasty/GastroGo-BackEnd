namespace GastroGoPlatform.API.Booking.Domain.Model.Aggregates
{
    public partial class OrderDetails
    {
        public int Id { get; private set; }

        public Order IdOrder { get; private set; }
        public Menu IdMenu { get; private set; }
        public OrderDetails() { }
        public OrderDetails(Order idOrder, Menu idMenu) 
        {
            IdOrder = idOrder;
            IdMenu = idMenu;
        }
    }
}