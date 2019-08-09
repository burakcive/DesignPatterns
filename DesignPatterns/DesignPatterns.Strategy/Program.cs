using System;
using System.Threading;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Staregy Pattern");

            var champion = new Champion("Warlock");

            champion.SetSummonStrategy(new SummonFlyingCreature(), summonImmiadetly: true);
            champion.SetSummonStrategy(new SummonMageCreature(), summonImmiadetly: true);
            champion.SetSummonStrategy(new SummonDefenceCreature());
            champion.SummonCompanion();

            Console.WriteLine("\nAll summon strategies are working. Now set on a adventure...\nIt will take 10 seconds...\n");

            var startTime = DateTime.Now;
            while (true)
            {
                var enemy = (EnemyType)typeof(EnemyType).GetRandomEnumValue();
                Console.WriteLine(enemy + " enemy appeared");
                Thread.Sleep(500);
                champion.ReactToEnemy(enemy);
                Thread.Sleep(500);

                //adventure ends
                if (DateTime.Now > startTime.AddSeconds(10))
                {
                    break;
                }
            }

            Console.WriteLine("\nYou have made a good jod...");
        }
    }
}
