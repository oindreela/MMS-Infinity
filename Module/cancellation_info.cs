using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module
{
    public class cancellation_info
    {
        string cancellation_id;
        string booking_id;
        double refunded_amount;

        public string Cancellation_id { get => cancellation_id; set => cancellation_id = value; }
        public string Booking_id { get => booking_id; set => booking_id = value; }
        public double Refunded_amount { get => refunded_amount; set => refunded_amount = value; }
    }
}