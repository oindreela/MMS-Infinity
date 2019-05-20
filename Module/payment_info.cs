using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module
{
    public class payment_info
    {
        string payment_id;
        string booking_id;
        string mode_of_payment;
        double paid_amount;
        double card_no;
        string card_type;

        public string Payment_id { get => payment_id; set => payment_id = value; }
        public string Booking_id { get => booking_id; set => booking_id = value; }
        public string Mode_of_payment { get => mode_of_payment; set => mode_of_payment = value; }
        public double Paid_amount { get => paid_amount; set => paid_amount = value; }
        public double Card_no { get => card_no; set => card_no = value; }
        public string Card_type { get => card_type; set => card_type = value; }
    }
}