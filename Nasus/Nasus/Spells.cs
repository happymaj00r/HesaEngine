using System.Media;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using static Nasus.Initialization;

namespace Nasus
{
    public static class SpellLoader
    {
        public static Spell Q, W, E, R;

        public static void LoadSpells()
        {
            Q = new Spell(SpellSlot.Q, Player.GetAutoAttackRange(Player), TargetSelector.DamageType.Physical);
            W = new Spell(SpellSlot.W, 600, TargetSelector.DamageType.Magical);
            E = new Spell(SpellSlot.E, 650, TargetSelector.DamageType.Magical);
            R = new Spell(SpellSlot.R, 0, TargetSelector.DamageType.Physical );

            W.SetTargetted(0.5f, 1500f);
            E.SetTargetted(0.2f,  1500);
           



        }

    }
}