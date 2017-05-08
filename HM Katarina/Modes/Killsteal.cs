using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using static HMKatarina.MenuLoader;
using static HMKatarina.SpellLoader;
using static HMKatarina.Initialization;
using static HMKatarina.Dagger;
using static HMKatarina.Modes.Combo;
namespace HMKatarina.Modes

{
    public static class Killsteal
    {
        public static void ActivateKS()
        {
            var d = Dagger.GetClosestDagger();

            if (KillstealMenu.Get<MenuCheckbox>("useKS").Checked)
            {
                if (Functions.CanUseSpell(SpellSlot.Q) && Functions.CanUseSpell(SpellSlot.E))
                {
                    var _Target = ObjectManager.Heroes.Enemies.FirstOrDefault(e => e.IsValidTarget(E.Range) && Functions.MyHero.GetSpellDamage(e, SpellSlot.Q) + Functions.MyHero.GetSpellDamage(e, SpellSlot.E) + 100 >= e.Health);
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
                    var _Target = ObjectManager.Heroes.Enemies.FirstOrDefault(e => e.IsValidTarget(E.Range) && Functions.MyHero.GetSpellDamage(e, SpellSlot.E) + Functions.MyHero.GetAutoAttackDamage(e) + 50 >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, E.Range))
                    {
                        if (_Target.Position.IsInRange(d, W.Range))
                        {
                            _isUlting = false;
                            E.Cast(GetBestDaggerPoint(d, _Target));
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
                    var _Target = ObjectManager.Heroes.Enemies.FirstOrDefault(e => e.IsValidTarget(Q.Range) && Functions.MyHero.GetSpellDamage(e, SpellSlot.Q) + 120 >= e.Health);
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
