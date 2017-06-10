
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using static Alistar.MenuLoader;
using static Alistar.SpellLoader;


namespace Alistar.Modes
{
    public class Laneclear
    {
        public static void ActivatedLaneClear()
        {



            var q = LaneClearMenu.Get<MenuCheckbox>("useQLC").Checked && Q.IsReady() && Q.IsLearned;
            var e = LaneClearMenu.Get<MenuCheckbox>("useELC").Checked && E.IsReady() && E.IsLearned;
            

            var minion = MinionManager.GetMinions(W.Range);

            foreach (var m in minion)
            {
                if (e && m.IsValidTarget() && m.IsMinion)
                {
                    W.Cast(m);
                }

                if (q && m.IsMinion && m.IsValidTarget())
                {



                   Q.Cast();

                }

               
            }
        }
    }
}