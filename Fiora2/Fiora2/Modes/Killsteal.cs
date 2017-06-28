using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using static Fiora2.MenuLoader;
using static Fiora2.SpellLoader;
using static Fiora2.Initialization;

using static Fiora2.Modes.Combo;
namespace Fiora2.Modes

{
    public static class Killsteal
    {
        public static void ActivateKS()
        {
            

            if (KillstealMenu.Get<MenuCheckbox>("useKS").Checked)
            {
                if (Functions.CanUseSpell(SpellSlot.Q) && Functions.CanUseSpell(SpellSlot.E))
                {
                    var _Target = ObjectManager.Heroes.Enemies.FirstOrDefault(e => e.IsValidTarget(E.Range) && Functions.MyHero.GetSpellDamage(e, SpellSlot.Q) + Functions.MyHero.GetSpellDamage(e, SpellSlot.E) + 10 >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, E.Range))
                    {
                       

                        E.Cast();

                        Q.Cast(_Target);
                        

                    }
                }


                if ( Functions.CanUseSpell(SpellSlot.E))
                {
                    var _Target = ObjectManager.Heroes.Enemies.FirstOrDefault(e => e.IsValidTarget(E.Range) && Functions.MyHero.GetSpellDamage(e, SpellSlot.E) + Functions.MyHero.GetAutoAttackDamage(e) + 10  >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, E.Range))
                    {
                        if (E.IsReady())
                        {
                            
                            E.Cast();
                        }
                       

                    }
                }
                if (Functions.CanUseSpell(SpellSlot.Q))
                {
                    var _Target = ObjectManager.Heroes.Enemies.FirstOrDefault(e => e.IsValidTarget(Q.Range) && Functions.MyHero.GetSpellDamage(e, SpellSlot.Q)  >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, Q.Range))
                    {
                        


                        Q.Cast(_Target);
                       

                    }
                }
            }
        }
    }
}
