using System.Media;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using static Kassadin.Initialization;
using static Kassadin.Modes.Item;
namespace Kassadin
{
    public static class SpellLoader
    {
        public static Spell Q, W, E, R;

        public static void LoadSpells()
        {
            Q = new Spell(SpellSlot.Q, 650, TargetSelector.DamageType.Magical);
            W = new Spell(SpellSlot.W, Player.GetAutoAttackRange(Player), TargetSelector.DamageType.Magical);
            E = new Spell(SpellSlot.E, 670, TargetSelector.DamageType.Magical);
            R = new Spell(SpellSlot.R, 600, TargetSelector.DamageType.Magical);

            Q.SetTargetted(0.5f, 1500f);
            E.SetTargetted(0.2f,  3000f);
            R.SetTargetted(500, 2000);



        }

    }
}