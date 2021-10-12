using SoccerApp.Models;
using System;

namespace SoccerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player("Cristiano Ronaldo", 2);
            var player2 = new Player("Messi", 2);
            var player3 = new Player("Neymar", 4);
            var player4 = new Player("Mbappé", 3);
            var goalManager = GoalManager.GetInstance();
            //recupera a mesma instancia, esta aqui para efeitos de observação de que só existe uma instancia
            var anotherInstance = GoalManager.GetInstance();
            goalManager.TryProbabilityOnKick(player1, 1);
            goalManager.TryProbabilityOnKick(player2, 4);
            anotherInstance.TryProbabilityOnKick(player1, 1);
            goalManager.TryProbabilityOnKick(player2, 3);
            goalManager.TryProbabilityOnKick(player3, 12);
            goalManager.TryProbabilityOnKick(player1, 10);
            goalManager.TryProbabilityOnKick(player1, 1);
            anotherInstance.TryProbabilityOnKick(player1, 1);
            goalManager.TryProbabilityOnKick(player3, 18);
            goalManager.TryProbabilityOnKick(player1, 4);
            goalManager.TryProbabilityOnKick(player1, 7);
            goalManager.TryProbabilityOnKick(player4, 3);
            goalManager.TryProbabilityOnKick(player1, 2);
            anotherInstance.TryProbabilityOnKick(player1, 1);
            goalManager.TryProbabilityOnKick(player1, 1);
            goalManager.TryProbabilityOnKick(player4, 1);
            goalManager.TryProbabilityOnKick(player1, 1);
            anotherInstance.TryProbabilityOnKick(player4, 1);
            goalManager.TryProbabilityOnKick(player1, 2);
            goalManager.TryProbabilityOnKick(player2, 1);
        }
    }
}
