using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerApp.Models
{
    public class Player
    {
        public Player(string name, int goalProbability)
        {
            Name = name;
            GoalProbability = goalProbability;
        }
        public string Name { get; private set; }
        public int GoalProbability { get; private set; }
    }
}
