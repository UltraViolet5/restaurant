﻿using System;
using System.Collections.Generic;
using System.Text;
using restaurant.Enums;
using restaurant.utils;

namespace restaurant.Model
{
    class Order
    {
        public Food food { get; set; }
        public int GuestId { get; set; }

        public Order(int id)
        {
            GuestId = id;
            food = (Food) Utils.GetRandom(1, 3);
        }
    }
}
