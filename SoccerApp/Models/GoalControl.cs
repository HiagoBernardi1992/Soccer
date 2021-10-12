using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerApp.Models
{
    public class GoalControl
    {
        public GoalControl(Player player, int kicksMade)
        {
            Player = player;
            KicksMade = kicksMade;
            ProbabityOfGoal = player.GoalProbability;
        }
        public Player Player { get; private set; }
        public int KicksMade { get; set; }
        public int ProbabityOfGoal { get; private set; }

        public int SetProbabityOfGoal(GoalControl goalControl, int kicks)
        {
            int golsOfkicks = 0;
            if(kicks == goalControl.ProbabityOfGoal)
            {
                goalControl.ProbabityOfGoal = Player.GoalProbability;
                golsOfkicks = 1;
                Console.WriteLine("O Jogador " + 
                    goalControl.Player.Name + 
                    " marcou 1 Gol");
            }
            else if(kicks > goalControl.ProbabityOfGoal)
            {
                kicks -= goalControl.ProbabityOfGoal;
                golsOfkicks = 1;
                while (kicks >= goalControl.Player.GoalProbability)
                {
                    golsOfkicks += 1;
                    kicks -= goalControl.Player.GoalProbability;
                }
                goalControl.ProbabityOfGoal = goalControl.Player.GoalProbability - kicks;
                Console.WriteLine("O Jogador " +
                    goalControl.Player.Name +
                    " marcou " + golsOfkicks.ToString() + " Gols");
            }
            else
            {
                goalControl.ProbabityOfGoal -= kicks;
                Console.WriteLine("O Jogador " + 
                    goalControl.Player.Name + 
                    " não marcou Gol, mas se chutar mais " + 
                    goalControl.ProbabityOfGoal + 
                    " provavelmente vai marcar");
            }
            return golsOfkicks;
        }
    }

}