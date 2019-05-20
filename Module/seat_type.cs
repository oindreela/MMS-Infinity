using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module
{
    public class seat_type
    {
        string seat_id;
        string screen_id;
        string seat_type1;
        double price;

        public string Seat_id { get => seat_id; set => seat_id = value; }
        public string Screen_id { get => screen_id; set => screen_id = value; }
        public string Seat_type1 { get => seat_type1; set => seat_type1 = value; }
        public double Price { get => price; set => price = value; }
    }
}