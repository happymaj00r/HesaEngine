using System.Media;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using static Alistar.Initialization;

namespace Alistar
{
    public static class SpellLoader
    {
        public static Spell Q, W, E, R;

        public static void LoadSpells()
        {
            Q = new Spell(SpellSlot.Q, 365, TargetSelector.DamageType.Magical);
            W = new Spell(SpellSlot.W, 650, TargetSelector.DamageType.Magical);
            E = new Spell(SpellSlot.E, 365, TargetSelector.DamageType.Magical);
            R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Physical );

           
            W.SetTargetted(0.2f,  1500);
           



        }

    }
}