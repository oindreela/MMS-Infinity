using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module
{
    public class feedback
    {
        string feedback_id;
        string movie_id;
        string registration_id;
        string reviews;
        double rating;

        public string Feedback_id { get => feedback_id; set => feedback_id = value; }
        public string Movie_id { get => movie_id; set => movie_id = value; }
        public string Registration_id { get => registration_id; set => registration_id = value; }
        public string Reviews { get => reviews; set => reviews = value; }
        public double Rating { get => rating; set => rating = value; }
    }
}