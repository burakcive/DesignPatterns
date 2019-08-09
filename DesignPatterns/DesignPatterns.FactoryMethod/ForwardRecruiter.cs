using System;

namespace DesignPatterns.FactoryMethod
{
    public class ForwardRecruiter : Recruiter
    {
        private readonly string Target = "Forward";

        public ForwardRecruiter(FootballerZone footballerZone) : base(footballerZone)
        {
            name = "Chris Lothbrook";
        }

        public override void SearchForFootballers()
        {
            Console.WriteLine($"{this}. Searching {Target} footballers from {footballerZone}. {footballerZone} is a heaven");
        }
    }
}
