using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module
{
    public class movieshow
    {
        string movieshow_id;
        string movie_id;
        string show_id;
        string screen_id;
        string status;

        public string Movieshow_id { get => movieshow_id; set => movieshow_id = value; }
        public string Movie_id { get => movie_id; set => movie_id = value; }
        public string Show_id { get => show_id; set => show_id = value; }
        public string Screen_id { get => screen_id; set => screen_id = value; }
        public string Status { get => status; set => status = value; }
    }
}