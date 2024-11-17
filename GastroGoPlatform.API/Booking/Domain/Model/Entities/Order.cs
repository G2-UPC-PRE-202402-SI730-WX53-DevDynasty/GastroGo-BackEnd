using GastroGoPlatform.API.Booking.Domain.Model.Valueobjects;
using GastroGoPlatform.API.Booking.Domain.Model.ValueObjects;

public partial class Order : IOrderable
{
    /// Order Entity
    /// <summary>
    ///     This is the Order entity. It represents an order in the booking system.
    /// </summary>
    public int OrderId { get; set; }
    public DateTime Date { get; set; }
    public OrderStatus Status { get; set; }
    public string DeliveryTime { get; set; }
    public int Hours { get; set; }
    public int CustomerId { get; set; }
    public decimal TotalPrice { get; set; }

    public Order()
    {
        this.Date = DateTime.Now;
        this.Status = OrderStatus.Pending;
        this.DeliveryTime = string.Empty;
        this.Hours = 0;
        this.CustomerId = CustomerId;
        this.TotalPrice = 0;
    }

    public Order(DateTime date, OrderStatus status, string deliveryTime, int hours, decimal totalPrice)
    {
        Date = date;
        Status = status;
        DeliveryTime = deliveryTime;
        Hours = hours;
        TotalPrice = totalPrice;
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

    public decimal CalculateTotalPrice()
    {
        return TotalPrice;
    }
}