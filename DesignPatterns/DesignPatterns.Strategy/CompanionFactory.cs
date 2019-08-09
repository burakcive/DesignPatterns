using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class CompanionFactory
    {
        public static SummonCompanionStrategy Create(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Legendary:
                    return new SummonFlyingCreature();
                case EnemyType.Competent:
                    return new SummonDefenceCreature();
                case EnemyType.Small:
                    return new SummonMageCreature();
                case EnemyType.Critter:
                    return new SummonDefaultCreature();
                default:
                    return new SummonDefaultCreature();
            }
        }

    }
}
