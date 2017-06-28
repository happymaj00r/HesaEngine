using HesaEngine.SDK;
using HesaEngine.SDK.Enums;

namespace Fiora2
{
    public static class SpellLoader
    {
        public static Spell Q, W, E, R, Ignite;
        public static float QSkillshotRange = 420;
        public static float QCircleRadius = 350;
        public static void LoadSpells()
        {
            Q = new Spell(SpellSlot.Q, QSkillshotRange + QCircleRadius, TargetSelector.DamageType.Magical);
            W = new Spell(SpellSlot.W, 750, TargetSelector.DamageType.Magical);
            E = new Spell(SpellSlot.E, 725, TargetSelector.DamageType.Magical);
            R = new Spell(SpellSlot.R, 525, TargetSelector.DamageType.Magical);
            Ignite = new Spell(SpellSlot.Summoner1, 700, TargetSelector.DamageType.True);
            Q.SetSkillshot(.25f, 0,500,false,SkillshotType.SkillshotLine);
            W.SetSkillshot(0.5f, 70, 3200, false, SkillshotType.SkillshotLine);
            E.SetTargetted(0f, 0f);
            R.SetTargetted(.066f, 500);

        }

        
        
        
    }
}
