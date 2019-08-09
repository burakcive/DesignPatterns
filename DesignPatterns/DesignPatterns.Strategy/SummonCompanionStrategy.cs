namespace DesignPatterns.Strategy
{
    public abstract class SummonCompanionStrategy
    {
        protected readonly string creatureToSummon;

        public SummonCompanionStrategy(string creatureToSummon)
        {
            this.creatureToSummon = creatureToSummon;
        }
        public abstract void SummonCompanion();
    }
}
