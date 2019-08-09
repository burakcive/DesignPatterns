using System;

namespace DesignPatterns.PublishSubscribe
{
    public class Baby
    {
        public string Name { get; set; }
        public bool IsSleeping { get; set; } = true;
        public int LastSleptAt { get; set; } = 0;

        public bool CheckIfCrying => !IsSleeping && new Random().Next(0, 4) == 1;
        public bool CheckIfWakesUp => IsSleeping && new Random().Next(0, 3) == 1;
        public bool CheckIfSleeps(int hour) => !IsSleeping && hour == LastSleptAt + 4;

        public event EventHandler<BabyEventArgs> BabyAwake;
        public event EventHandler<BabyEventArgs> BabySleep;
        public event EventHandler<BabyEventArgs> BabyCry;

        public void OnBabyAwake(int hour)
        {
            IsSleeping = false;
            BabyAwake?.Invoke(this, new BabyEventArgs(hour));
        }

        public void Sleep(int hour)
        {
            IsSleeping = true;
            LastSleptAt = hour;
            BabySleep?.Invoke(this, new BabyEventArgs(hour));
        }

        public void OnCry(int hour)
        {
            BabyCry?.Invoke(this, new BabyEventArgs(hour));
        }

    }

    public class BabyEventArgs : EventArgs
    {
        public int Hour { get; }
        public BabyEventArgs(int hour)
        {
            Hour = hour;
        }
    }
}
