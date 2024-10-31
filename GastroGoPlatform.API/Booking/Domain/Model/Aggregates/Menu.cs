using GastroGoPlatform.API.Booking.Domain.Model.Entities;

namespace GastroGoPlatform.API.Booking.Domain.Model.Aggregates
{
    public partial class Menu
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private readonly List<Product> _products = new List<Product>();
        public IReadOnlyCollection<Product> Products => _products.AsReadOnly();

        public Menu(string name)
        {
            Name = name;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }
}
