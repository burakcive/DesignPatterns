using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class SummonDefenceCreature : SummonCompanionStrategy
    {
        public SummonDefenceCreature() : base("RockRub(Defence)")
        {
        }

        public override void SummonCompanion()
        {
            Console.WriteLine($"{creatureToSummon} has summoned.");
        }
    }

    public class SummonMageCreature : SummonCompanionStrategy
    {
        public SummonMageCreature() : base("Aery(Mage)")
        {
        }

        public override void SummonCompanion()
        {
            Console.WriteLine($"{creatureToSummon} has summoned.");
        }
    }

    public class SummonFlyingCreature : SummonCompanionStrategy
    {
        public SummonFlyingCreature() : base("Shadow Wing(Flying)")
        {
        }

        public override void SummonCompanion()
        {
            Console.WriteLine($"{creatureToSummon} has summoned.");
        }
    }

    public class SummonDefaultCreature : SummonCompanionStrategy
    {
        public SummonDefaultCreature() : base("Smiley Thing(Default)")
        {
        }

        public override void SummonCompanion()
        {
            Console.WriteLine($"{creatureToSummon} has summoned.");
        }
    }
}
