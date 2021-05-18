using System;
using System.Collections.Generic;
using System.Text;
using restaurant.Model;
using static restaurant.utils.Utils;

namespace restaurant.Model
{
    class Waiters: Man
    {
        public Order order { get; set; }

        public Waiters(string name) : base(name)
        {
            
        }

        public override Order GetOrder(int Peoples, int Staff)
        {
            int GuestId = GetRandom(Staff + 1, Peoples + 1);
            return order;
        }
    }
}
