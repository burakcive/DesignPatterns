using System;

namespace DesignPatterns.FactoryMethod
{
    public class MidfielderRecruiter : Recruiter
    {
        private readonly string Target = "Midfielder";

        public MidfielderRecruiter(FootballerZone footballerZone) : base(footballerZone)
        {
            name = "Antony Turk";
        }

        public override void SearchForFootballers()
        {
            Console.WriteLine($"{this}. Searching {Target} footballers from {footballerZone}. I know my job");
        }
    }
}
