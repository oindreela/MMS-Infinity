using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module
{
    public class show
    {
        string show_id;
        DateTime time;
        string show_name;

        public string Show_id { get => show_id; set => show_id = value; }
        public DateTime Time { get => time; set => time = value; }
        public string Show_name { get => show_name; set => show_name = value; }
    }
}