using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module
{
    public class screen
    {
        string screen_id;
        string hall_id;
        double no_of_seats;
        string screen_name;

        public string Screen_id { get => screen_id; set => screen_id = value; }
        public string Hall_id { get => hall_id; set => hall_id = value; }
        public double No_of_seats { get => no_of_seats; set => no_of_seats = value; }
        public string Screen_name { get => screen_name; set => screen_name = value; }
    }
}