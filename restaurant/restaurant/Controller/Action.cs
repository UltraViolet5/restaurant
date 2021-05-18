using System;
using System.Collections.Generic;
using System.Text;
using restaurant.Model;
using restaurant.Peoples;

namespace restaurant.Controller
{
    class Action
    {

        public void StartRestaurant(int Waiters, int Guests)
        {
            Chef cheff = new Chef();
            List<Order> Orders = new List<Order>();
            for (int i = 1; i < Waiters; i++)
            {
                Waiters waiter = new Waiters($"John{i}");
                int Staff = Waiters + 1;
                int Peoples = Waiters + Guests + 1;

                waiter.GetOrder(Peoples, Staff);
            }
            for (int i = 1; i < Guests; i++)
            {
                Guest guest = new Guest($"John + {i}");
                Orders.Add(guest.order);
            }
        }
    }
}
