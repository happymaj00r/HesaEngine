using static Alistar.MenuLoader;
using static Alistar.SpellLoader;
using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.GameObjects;

namespace Alistar.Modes
{





    public static class Killsteal
    {
        public static void ActivateKS()
        {


            
                
                if (Functions.CanUseSpell(SpellSlot.W) && Functions.CanUseSpell(SpellSlot.Q))

                {
                    var _Target =
                        ObjectManager.Heroes.Enemies.FirstOrDefault(
                            e => e.IsValidTarget(W.Range) &&
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.W) +
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.Q)
                                 


                                  >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, W.Range) && _Target != null)
                    {




                        
                            W.Cast(_Target);


                        Q.Cast();
                    }
                    }
                }


            }
        }
    



