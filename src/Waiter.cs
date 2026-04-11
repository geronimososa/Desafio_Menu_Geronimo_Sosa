using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private List<Table> assignedTables = new List<Table>();
        public string name;

        public Waiter(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AssignTable(Table table)
        {
            assignedTables.Add(table);
        }

        public void TakeOrder(Table table, Dish dish)
        {
            table.Order.AddDish(dish);
        }

        public void TakeOrder(TakeawayOrder takeaway, Dish dish)
        {
            takeaway.Order.AddDish(dish);
        }

        // Waiter no calcula el total directamente, delegandolo a Order, que es quien
        // tiene la lista de platillos y sus precios.
        public double GetBillAmount(Table table)
        {
            return table.Order.GetTotal();
        }
        
        public double GetBillAmount(TakeawayOrder takeaway)
        {
            return takeaway.Order.GetTotal();
        }
    }
}