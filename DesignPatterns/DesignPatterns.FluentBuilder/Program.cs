using System;

namespace DesignPatterns.FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fluent Builder");

            ITeamBuilder tb = new TeamBuilder();

            Team team1 = tb.CreateTeam("Chelsea")
                .WithNickName("The blues")
                .WithShirtColor(Color.Blue)
                .FromTown("London")
                .PlayingAt("Stamford Bridge");

            Console.WriteLine(team1);
        }
    }
}
