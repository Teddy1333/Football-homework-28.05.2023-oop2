using Football_homework_28._05._2023_oop2;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Goalkeeper goalkeeper = new Goalkeeper { Name ="John Doe", Number = 1, Age = 25, Height = 1.85, YearsExperience = 5 };
        Defender defender = new Defender { Name = "Jane Smith", Number = 5, Age = 28, Height = 1.75, DefendedAttacks = 50 };
        Midfielder midfielder = new Midfielder { Name = "David Johnson", Number = 10, Age = 30, Height = 1.80 };
        Striker striker = new Striker { Name = "Michael Brown", Number = 9, Age = 27, Height = 1.82, Strikes = 20 };

        Team team = new Team
        {
            Coach = new Coach { Name = "Alex Ferguson", Age = 55, FavoritePlayer = "Lionel Messi" },
            Players = new List<FootballPlayer> { goalkeeper, defender, midfielder, striker }
        };

        double averageAge = team.GetAveragePlayerAge();
        Console.WriteLine($"Average player age: {averageAge}");

        Game game = new Game
        {
            Team1 = team,
            Referee = new Referee { Name = "John Smith", Age = 40, Biased = false },
            AssistantReferees = new List<AssistantReferee>
            {
                new AssistantReferee { Name = "Mark Davis", Age = 35 },
                new AssistantReferee { Name = "Sarah Johnson", Age = 32 }
            },
            Goals = new List<Goal>
            {
                new Goal { Minute = 15, Player = striker },
                new Goal { Minute = 30, Player = midfielder }
            },
            Result = "2-0",
            Winner = team
        };
       
        Console.WriteLine($"Game result: {game.Result}");
        Console.WriteLine($"Winner: {game.Winner.Coach.Name}");
    }
}
