using System;
using System.Collections.Generic;

namespace MealVoteDomain
{
    public class History
    {
        public DateTime Date { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<Profile> Attendees { get; set; }
    }
}
