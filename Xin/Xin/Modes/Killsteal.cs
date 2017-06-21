using static Xin.MenuLoader;
using static Xin.SpellLoader;
using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.GameObjects;

namespace Xin.Modes
{





    public static class Killsteal
    {
        public static void ActivateKS()
        {


            if (KillstealMenu.Get<MenuCheckbox>("useQS").Checked)
            {
                if (Functions.CanUseSpell(SpellSlot.Q))

                {
                    var _Target =
                        ObjectManager.Heroes.Enemies.FirstOrDefault(
                            e => e.IsValidTarget(Q.Range) &&
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.Q) +


                                 20 >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, Q.Range))
                    {




                        Q.Cast(_Target);
                        

                    }
                }
                
                if (Functions.CanUseSpell(SpellSlot.E))

                {
                    var _Target =
                        ObjectManager.Heroes.Enemies.FirstOrDefault(
                            e => e.IsValidTarget(E.Range) &&
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.E) +


                                 100 >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, E.Range) && _Target != null)
                    {




                        
                            E.Cast(_Target.Position);
                        }
                    }
                }


            }
        }
    }



