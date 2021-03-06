﻿using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using static Hero.MenuLoader;
using static Hero.SpellLoader;
using static Hero.Initialization;

using static Hero.Modes.Combo;
namespace Hero.Modes

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
                        _isUlting = false;

                        E.Cast(_Target.Position);

                        Q.Cast(_Target);
                        if (W.IsReady() && _Target != null)
                        {
                            W.Cast(_Target);

                        }

                    }
                }


                if ( Functions.CanUseSpell(SpellSlot.E))
                {
                    var _Target = ObjectManager.Heroes.Enemies.FirstOrDefault(e => e.IsValidTarget(E.Range) && Functions.MyHero.GetSpellDamage(e, SpellSlot.E) + Functions.MyHero.GetAutoAttackDamage(e) + 10  >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, E.Range))
                    {
                        if (E.IsReady())
                        {
                            _isUlting = false;
                            E.Cast(_Target.Position);
                        }
                        else
                        {
                            _isUlting = false;

                            E.Cast(_Target.Position);


                            if (W.IsReady() && _Target != null)
                            {
                                W.Cast(_Target);

                            }
                        }


                    }
                }
                if (Functions.CanUseSpell(SpellSlot.Q))
                {
                    var _Target = ObjectManager.Heroes.Enemies.FirstOrDefault(e => e.IsValidTarget(Q.Range) && Functions.MyHero.GetSpellDamage(e, SpellSlot.Q)  >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, Q.Range))
                    {
                        _isUlting = false;


                        Q.Cast(_Target);
                        if (W.IsReady() && _Target != null)
                        {
                            W.Cast(_Target);

                        }

                    }
                }
            }
        }
    }
}
