using static Kassadin.MenuLoader;
using static Kassadin.SpellLoader;
using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.GameObjects;

namespace Kassadin.Modes
{





    public static class Killsteal
    {
        public static void ActivateKS()
        {


            if (KillstealMenu.Get<MenuCheckbox>("useKS").Checked)
            {
                if (Functions.CanUseSpell(SpellSlot.Q) && Functions.CanUseSpell(SpellSlot.R) &&
                    Functions.CanUseSpell(SpellSlot.E))
                {
                    var _Target =
                        ObjectManager.Heroes.Enemies.FirstOrDefault(
                            e => e.IsValidTarget(Q.Range) &&
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.Q) +
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.R) +
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.E) +
                                 100 >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, Q.Range))
                    {


                        R.Cast(_Target.Position);

                        Q.Cast(_Target);
                        if (W.IsReady() && _Target != null)
                        {
                            W.Cast();


                        }
                        if (E.IsReady() && _Target != null)
                        {
                            E.Cast(_Target);
                        }
                    }
                }


                 if (Functions.CanUseSpell(SpellSlot.Q) && Functions.CanUseSpell(SpellSlot.R))
                {
                    var _Target =
                        ObjectManager.Heroes.Enemies.FirstOrDefault(
                            e => e.IsValidTarget(Q.Range) &&
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.Q) +
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.R) +

                                 100 >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, Q.Range))
                    {


                        R.Cast(_Target.Position);

                        Q.Cast(_Target);
                        if (W.IsReady() && _Target != null)
                        {
                            W.Cast();


                        }
                        if (E.IsReady() && _Target != null)
                        {
                            E.Cast(_Target);
                        }
                    }
                }

               if (Functions.CanUseSpell(SpellSlot.E) && Functions.CanUseSpell(SpellSlot.R))
                {
                    var _Target =
                        ObjectManager.Heroes.Enemies.FirstOrDefault(
                            e => e.IsValidTarget(E.Range) &&
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.E) +
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.R) +

                                 100 >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, E.Range))
                    {


                        R.Cast(_Target.Position);

                        E.Cast(_Target);
                        if (W.IsReady() && _Target != null)
                        {
                            W.Cast();


                        }
                        if (Q.IsReady() && _Target != null)
                        {
                            Q.Cast(_Target);
                        }
                    }
                }


                if (Functions.CanUseSpell(SpellSlot.E) && Functions.CanUseSpell(SpellSlot.Q))
                {
                    var _Target =
                        ObjectManager.Heroes.Enemies.FirstOrDefault(
                            e => e.IsValidTarget(E.Range) &&
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.E) +
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.Q) +

                                 100 >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, E.Range))
                    {


                        Q.Cast(_Target.Position);

                        E.Cast(_Target);
                        if (W.IsReady() && _Target != null)
                        {
                            W.Cast();


                        }
                        if (R.IsReady() && _Target != null)
                        {
                            R.Cast(_Target);
                        }
                    }
                }





                if (Functions.CanUseSpell(SpellSlot.Q))
                                 {
                                     var _Target =
                                         ObjectManager.Heroes.Enemies.FirstOrDefault(
                                             e => e.IsValidTarget(Q.Range) &&
                                                  Functions.MyHero.GetSpellDamage(e, SpellSlot.Q) +


                                                  150 >= e.Health);
                                     if (Functions.IsTargetValidWithRange(_Target, Q.Range))
                                     {




                                         Q.Cast(_Target);
                                         if (W.IsReady() && _Target != null)
                                         {
                                             W.Cast();


                                         }
                                         if (E.IsReady() && _Target != null)
                                         {
                                             E.Cast(_Target);
                                         }
                                     }
                                 }


                if (Functions.CanUseSpell(SpellSlot.E))
                {
                    var _Target =
                        ObjectManager.Heroes.Enemies.FirstOrDefault(
                            e => e.IsValidTarget(E.Range) &&
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.E) +


                                 150 >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target,E.Range))
                    {




                        E.Cast(_Target);
                        if (W.IsReady() && _Target != null)
                        {
                            W.Cast();


                        }
                        if (Q.IsReady() && _Target != null)
                        {
                            Q.Cast(_Target);
                        }
                    }
                }




                if (Functions.CanUseSpell(SpellSlot.R))
                {
                    var _Target =
                        ObjectManager.Heroes.Enemies.FirstOrDefault(
                            e => e.IsValidTarget(R.Range) &&
                                 Functions.MyHero.GetSpellDamage(e, SpellSlot.R) +


                                 150 >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target,R.Range))
                    {




                        R.Cast(_Target);
                        if (W.IsReady() && _Target != null)
                        {
                            W.Cast();


                        }
                        if (Q.IsReady() && _Target != null)
                        {
                            Q.Cast(_Target);
                        }
                    }
                }



            }
        }
    }

}

