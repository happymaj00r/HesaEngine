using HesaEngine.SDK;
using HesaEngine.SDK.Enums;

namespace Hero
{
    public static class SpellLoader
    {
        public static Spell Q, W, E, R, Ignite;

        public static void LoadSpells()
        {
            Q = new Spell(SpellSlot.Q, 600, TargetSelector.DamageType.Magical);
            W = new Spell(SpellSlot.W, 600, TargetSelector.DamageType.Magical);
            E = new Spell(SpellSlot.E, 580, TargetSelector.DamageType.Magical);
            R = new Spell(SpellSlot.R, 525, TargetSelector.DamageType.Magical);
            Ignite = new Spell(SpellSlot.Summoner1, 700, TargetSelector.DamageType.True);
            Q.SetTargetted(0.5f, 1500f);
            W.SetTargetted(0.5f, 1500f);
            E.SetSkillshot(0.5f, 1500f,int.MaxValue, false, SkillshotType.SkillshotCone);

        }

        
        
        
    }
}
