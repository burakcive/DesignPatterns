using System;

namespace DesignPatterns.FactoryMethod
{
    public class DefenceRecruiter : Recruiter
    {
        private readonly string Target = "Defence";

        public DefenceRecruiter(FootballerZone footballerZone) : base(footballerZone)
        {
            name = "Micheal Stevens";
        }

        public override void SearchForFootballers()
        {
            Console.WriteLine($"{this}. Searching {Target} footballers from {footballerZone}");
        }
    }
}
