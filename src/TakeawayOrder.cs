namespace Ucu.Poo.Restaurant
{
// Una orden para llevar maneja datos distintos a una mesa: necesita el nombre
// del cliente y no tiene nada que ver con si hay lugar ocupado o no
    public class TakeawayOrder
    {
        public string CustomerName { get; }
        public Order Order { get; } = new Order();
        
        public TakeawayOrder(string customerName)
        {
            this.CustomerName = customerName;
        }
    }
}