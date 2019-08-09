using System;
using System.Collections.Generic;

namespace DesignPatterns.PublishSubscribe
{
    public class BabySitter
    {
        private readonly List<Baby> babies;

        public BabySitter(List<Baby> babies)
        {
            this.babies = babies;

            this.babies.ForEach(baby =>
            {
                baby.BabyAwake += OnBabyIsAwake;
                baby.BabySleep += OnBabyFallingASleep;
                baby.BabyCry += OnBabyCry;
            });
        }

        private void OnBabyCry(object sender, BabyEventArgs e)
        {
            Console.WriteLine($"{((Baby)sender).Name} is crying at {e.Hour} o'clock. It is time for feeding.");
        }

        private void OnBabyFallingASleep(object sender, BabyEventArgs e)
        {
            Console.WriteLine($"{((Baby)sender).Name} is falling a sleep at {e.Hour} o'clock.");
        }

        private void OnBabyIsAwake(object sender, BabyEventArgs e)
        {
            Console.WriteLine($"{((Baby)sender).Name} is awake at {e.Hour} o'clock.");
        }
    }

}
