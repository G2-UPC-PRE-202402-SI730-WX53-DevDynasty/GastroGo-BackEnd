using GastroGoPlatform.API.Booking.Domain.Model.Valueobjects;
using GastroGoPlatform.API.Booking.Domain.Model.ValueObjects;

public partial class Order : IOrderable
{
    public int OrderId { get; set; }
    public DateTime Date { get; set; }
    public OrderStatus Status { get; set; }
    public string DeliveryTime { get; set; }
    public int CustomerId { get; set; }

    public Order()
    {
        this.Date = DateTime.Now;
        this.Status = OrderStatus.Pending;
        this.DeliveryTime = string.Empty;
    }


    public void OrderCancelled()
    {
        Status = OrderStatus.Cancelled;
    }

    public void OrderDelivered()
    {
        Status = OrderStatus.Delivered;
    }

    public void OrderInProgress()
    {
        Status = OrderStatus.InProgress;
    }

    public void OrderPending()
    {
        Status = OrderStatus.Pending;
    }

    public virtual object GetContent()
    {
        return string.Empty;
    }
}
