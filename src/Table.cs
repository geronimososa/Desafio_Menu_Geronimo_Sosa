using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        public int Number { get; }
        public bool IsOccupied { get; private set; }

        public Order Order { get; private set; } = new Order();

        public Table(int number)
        {
            this.Number = number;
        }

        public void Occupy()
        {
            IsOccupied = true;
        }

        public void Free()
        {
            IsOccupied = false;
            Order = new Order();
        }
    }
}