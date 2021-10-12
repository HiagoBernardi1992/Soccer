using System;
using System.Collections.Generic;
using System.Linq;

namespace SoccerApp.Models
{
    public class GoalManager
    {
        private static GoalManager _instance;
        private static List<GoalControl> control;
        private static int goals;

        private GoalManager() 
        {
        }

        public static GoalManager GetInstance()
        {
            if(_instance == null)
            {
                _instance = new GoalManager();
                control = new List<GoalControl>();
                goals = 0;
            }
            return _instance;
        }

        public void TryProbabilityOnKick(Player player, int kicks)
        {
            Console.WriteLine("############################################################");
            var currentPlayer = control.Where(x => x.Player == player).FirstOrDefault();
            if (currentPlayer == null)
            {
                currentPlayer = new GoalControl(player, kicks);
            }
            else
            {
                control.Remove(currentPlayer);
                currentPlayer.KicksMade += kicks;
            }
            Console.WriteLine("O Jogador " +
                currentPlayer.Player.Name + " vai chutar " + kicks.ToString() + " vez(es).");
            goals += currentPlayer.SetProbabityOfGoal(currentPlayer, kicks);
            control.Add(currentPlayer);
            Console.WriteLine("O Jogador " + 
                currentPlayer.Player.Name + 
                " chutou " + 
                currentPlayer.KicksMade.ToString() + 
                " vez(es) até agora nessa partida.");
            Console.WriteLine("Foram Feitos " 
                + goals.ToString() + " até o momento");
            Console.WriteLine("############################################################");
        }
    }
}

