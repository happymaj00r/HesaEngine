using System;
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using static Hero.MenuLoader;
using static Hero.SpellLoader;

namespace Hero.Modes
{
    public static class Laneclear
    {
        public static void ActivatedLaneClear()
        {



            
            var q = LaneClearMenu.Get<MenuCheckbox>("useQLC").Checked && Q.IsReady() && Q.IsLearned;
            var e = LaneClearMenu.Get<MenuCheckbox>("useELC").Checked && E.IsReady() && E.IsLearned;
            var w = LaneClearMenu.Get<MenuCheckbox>("useWLC").Checked && W.IsReady() && E.IsLearned;

            var minion = MinionManager.GetMinions(Q.Range);

            foreach (var m in minion)
            {
                if (q && m.IsValidTarget() && m.IsMinion)
                {
                    Q.Cast(m);
                }

                if (e && m.IsMinion && m.IsValidTarget() && !m.Position.IsUnderEnemyTurret())
                {
                  {
                       E.Cast();

                    }
                   
                }

                else if (w && m.IsMinion && m.IsValidTarget())
                {

                    W.Cast(m);
                }
            }
        }
    }
}
//needs dont jumper tower like in Comb