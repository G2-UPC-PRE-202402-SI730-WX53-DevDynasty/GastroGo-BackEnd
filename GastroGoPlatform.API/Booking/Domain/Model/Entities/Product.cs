using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.ValueObjects;

namespace GastroGoPlatform.API.Booking.Domain.Model.Entities
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; protected set; }
        public Category Category { get; protected set; }
        public int Stock { get; protected set; }
        public Price Price { get; protected set; }

        public int MenuId { get; private set; }
        public Menu Menu { get; private set; }

        private Product() { }

        public Product(string name, Category category, int stock)
        {
            Name = name;
            Category = category;
            Stock = stock;
        }

        public void SetPrice(Price price)
        {
            Price = price;
        }
    }
}
