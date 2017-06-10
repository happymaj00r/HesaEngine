using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using static Fiora.Initialization;
namespace Fiora
{
    public static class SpellLoader
    {
        public static Spell Q, W, E, R, Ignite;

        public static void LoadSpells()
        {
            Q = new Spell(SpellSlot.Q, 400, TargetSelector.DamageType.Physical);
            W = new Spell(SpellSlot.W, 380, TargetSelector.DamageType.Magical);
            E = new Spell(SpellSlot.E, Player.GetRealAutoAttackRange() , TargetSelector.DamageType.Magical);
            R = new Spell(SpellSlot.R, 500, TargetSelector.DamageType.Magical);
            Ignite = new Spell(SpellSlot.Summoner1, 700, TargetSelector.DamageType.True);
            
            
            Q.SetSkillshot(0.25f,50,int.MaxValue,false,SkillshotType.SkillshotLine);

           

        }

        
        
        
    }
}