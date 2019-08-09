using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.PublishSubscribe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Publish/Subscribe Pattern");

            var babies = new List<Baby>()
            {
                new Baby { Name = "Carlos" },
                new Baby { Name = "Mike" },
                new Baby { Name = "Anna" },
                new Baby { Name = "Liza" },
                new Baby { Name = "John" }
            };

            var babySitter = new BabySitter(babies);

            //Simulate the Day
            Task.Run(() =>
            {
                for (int hour = 0; hour < 24; hour++)
                {
                    Thread.Sleep(1000);
                    var random = new Random();
                    //check the babies are sleeping or not
                    babies.ForEach(baby =>
                    {
                        if (baby.CheckIfCrying)
                        {
                            baby.OnCry(hour);
                        }
                        if (baby.CheckIfWakesUp)
                        {
                            baby.OnBabyAwake(hour);
                        }
                        else if (baby.CheckIfSleeps(hour))
                        {
                            baby.Sleep(hour);
                        }
                    });
                }
            });

            Console.ReadKey();
        }
    }
}
