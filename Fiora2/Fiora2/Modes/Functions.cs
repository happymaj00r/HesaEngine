using System.Collections.Generic;
using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.GameObjects;

namespace Fiora2.Modes
{

    internal static class Functions
    {

        public static AIHeroClient MyHero => ObjectManager.Me;

        public static bool IsEmpty<T>(this IEnumerable<T> source)
        {
            return !source.Any();
        }

        public static bool CanUseSpell(SpellSlot spell)
        {
            return MyHero.Spellbook.GetSpellState(spell) == SpellState.Ready;
        }



        public static bool IsTargetValid(AIHeroClient target)
        {
            return target != null && target.IsValidTarget();
        }


        public static bool IsTargetValidWithRange(AIHeroClient target, float range)
        {
            return target != null && target.IsValidTarget(range);
        }



    }
}

