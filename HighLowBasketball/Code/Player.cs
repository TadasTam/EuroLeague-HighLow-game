using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HighLowBasketball.Code
{
    public class Player
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Team { get; set; }
        public string Nationality { get; set; }
        public double[] Stats { get; set; }

        public Player(string lastName, string name, string position, string team, string nationality, double[] stats)
        {
            Name = name;
            LastName = lastName;
            Position = position;
            Team = team;
            Nationality = nationality;
            Stats = stats;
        }
    }
}