using System;
using System.Collections.Generic;

namespace MealVote.Domain
{
    public class History
    {
        public string Tribe { get; set; }
        public DateTime Date { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<Profile> Attendees { get; set; }
    }
}
