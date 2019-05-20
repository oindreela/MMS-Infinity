using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module
{
    public class movie
    {
        string movie_id;
        string movie_name;
        string cast;
        DateTime duration;
        string language;
        double rating;
        string description;
        string status;

        public string Movie_id { get => movie_id; set => movie_id = value; }
        public string Movie_name { get => movie_name; set => movie_name = value; }
        public string Cast { get => cast; set => cast = value; }
        public DateTime Duration { get => duration; set => duration = value; }
        public string Language { get => language; set => language = value; }
        public double Rating { get => rating; set => rating = value; }
        public string Description { get => description; set => description = value; }
        public string Status { get => status; set => status = value; }
    }
}