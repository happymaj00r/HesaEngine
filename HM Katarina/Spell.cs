using HesaEngine.SDK;
using HesaEngine.SDK.Enums;

namespace HMKatarina
{
    public static class SpellLoader
    {
        public static Spell Q, W, E, R;

        public static void LoadSpells()
        {
            Q = new Spell(SpellSlot.Q, 625, TargetSelector.DamageType.Magical);
            W = new Spell(SpellSlot.W, 350, TargetSelector.DamageType.Magical);
            E = new Spell(SpellSlot.E, 725, TargetSelector.DamageType.Magical);
            R = new Spell(SpellSlot.R, 550, TargetSelector.DamageType.Magical);

            Q.SetTargetted(0.5f, 1500f);

            E.SetTargetted(0.1f, 75f);

        }

    }
}
