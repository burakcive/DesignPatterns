namespace DesignPatterns.FactoryMethod
{
    public abstract class Recruiter
    {
        protected string name;
        protected FootballerZone footballerZone;

        public Recruiter(FootballerZone footballerZone)
        {
            this.footballerZone = footballerZone;
        }

        public abstract void SearchForFootballers();

        public override string ToString()
        {
            return $"I am {name}";
        }
    }
}
