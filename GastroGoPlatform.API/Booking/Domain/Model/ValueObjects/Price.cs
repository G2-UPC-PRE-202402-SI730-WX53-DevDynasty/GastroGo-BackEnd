namespace GastroGoPlatform.API.Booking.Domain.Model.ValueObjects
{
    public class Price
    {
        public decimal Amount { get; private set; }

        public Price(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Price amount cannot be negative.");

            Amount = amount;
        }
    }
}
