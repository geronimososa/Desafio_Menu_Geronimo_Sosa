namespace Ucu.Poo.Restaurant
{
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