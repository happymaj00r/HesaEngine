using System.Media;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using static Xin.Initialization;

namespace Xin
{
    public static class SpellLoader
    {
        public static Spell Q, W, E, R;

        public static void LoadSpells()
        {
            Q = new Spell(SpellSlot.Q, Player.GetAutoAttackRange(Player), TargetSelector.DamageType.Physical);
            W = new Spell(SpellSlot.W, Player.GetAutoAttackRange(Player), TargetSelector.DamageType.Physical);
            E = new Spell(SpellSlot.E, 650, TargetSelector.DamageType.Magical);
            R = new Spell(SpellSlot.R, 500, TargetSelector.DamageType.Physical );

           
            E.SetTargetted(0.2f,  1500);
           



        }

    }
}