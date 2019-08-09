namespace DesignPatterns.Strategy
{
    public class Champion
    {
        private SummonCompanionStrategy summonCompanionStrategy;
        public string Name { get; }

        public Champion(string name)
        {
            summonCompanionStrategy = new SummonDefaultCreature();
            Name = name;
        }

        public void SetSummonStrategy(SummonCompanionStrategy summonStrategy, bool summonImmiadetly = false)
        {
            summonCompanionStrategy = summonStrategy;
            if (summonImmiadetly)
            {
                SummonCompanion();
            }
        }

        public void SummonCompanion()
        {
            summonCompanionStrategy.SummonCompanion();
        }

        public void ReactToEnemy(EnemyType enemyType)
        {
            SetSummonStrategy(CompanionFactory.Create(enemyType), summonImmiadetly: true);
        }
    }
}
