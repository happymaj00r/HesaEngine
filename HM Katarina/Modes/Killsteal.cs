using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using static HMKatarina.MenuLoader;
using static HMKatarina.SpellLoader;
using static HMKatarina.Initialization;
namespace HMKatarina.Modes
{
    public static class Killsteal
    {
        public static void ActivateKS()
        {


            if (KillstealMenu.Get<MenuCheckbox>("useKS").Checked)
            {
                if (Functions.CanUseSpell(SpellSlot.Q) && Functions.CanUseSpell(SpellSlot.E))
                {
                    var _Target = ObjectManager.Heroes.Enemies.FirstOrDefault(e => e.IsValidTarget(725) && Functions.MyHero.GetSpellDamage(e, SpellSlot.Q) + Functions.MyHero.GetSpellDamage(e, SpellSlot.E) + 100 >= e.Health);
                    if (Functions.IsTargetValidWithRange(_Target, 725))
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

            }
        }
    }
}
