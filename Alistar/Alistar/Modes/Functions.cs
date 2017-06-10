using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.GameObjects;
using static Alistar.SpellLoader;

namespace Alistar.Modes
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
        
        
        public static float GetUnitTotalAD(Obj_AI_Base unit)
        {
            return unit.BaseAttackDamage + unit.FlatBaseAttackDamageMod;
        }

        public static double GetWdmg(Obj_AI_Base target)
        {
            int qedmg = 0;
            if (ObjectManager.Player.GetSpell(SpellSlot.R).Level == 1)
            {
                qedmg = 75;
            }
            if (ObjectManager.Player.GetSpell(SpellSlot.R).Level == 2)
            {
                qedmg = 175;
            }
            if (ObjectManager.Player.GetSpell(SpellSlot.R).Level == 3)
            {
                qedmg = 275;
            }

            double calc = GetUnitTotalAD(ObjectManager.Me) * 1.0;
            double full = calc + qedmg;
            double damage = ObjectManager.Player.CalcDamage(target, Damage.DamageType.Physical, full);
            return damage;

        }

    }
}

