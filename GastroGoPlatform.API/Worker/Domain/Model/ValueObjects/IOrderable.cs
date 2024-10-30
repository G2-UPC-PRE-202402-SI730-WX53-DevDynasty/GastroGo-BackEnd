namespace GastroGoPlatform.API.Worker.Domain.Model.ValueObjects
{
    public interface IOrderable
    {
        void OrderInProgress();
        void OrderPending();
        void OrderDelivered();
        void OrderCancelled();

    }
}
