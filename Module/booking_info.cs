using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module
{
    public class booking_info
    {
        string booking_id;
        string movieshow_id;
        string seat_id;
        string registration_id;
        double no_of_seats_booked;
        DateTime date;
        double amount;
        string status;

        public string Booking_id { get => booking_id; set => booking_id = value; }
        public string Movieshow_id { get => movieshow_id; set => movieshow_id = value; }
        public string Seat_id { get => seat_id; set => seat_id = value; }
        public string Registration_id { get => registration_id; set => registration_id = value; }
        public double No_of_seats_booked { get => no_of_seats_booked; set => no_of_seats_booked = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Status { get => status; set => status = value; }
    }
}