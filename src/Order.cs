using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Order
    {
        private List<Dish> dishes = new List<Dish>();

        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }

        public bool HasDishes()
        {
            return dishes.Count > 0;
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (Dish dish in dishes)
            {
                total += dish.Price;
            }
            return total;
        }
    }
}