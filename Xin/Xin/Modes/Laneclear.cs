
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using static Xin.MenuLoader;
using static Xin.SpellLoader;


namespace Xin.Modes
{
    public class Laneclear
    {
        public static void ActivatedLaneClear()
        {



            var q = LaneClearMenu.Get<MenuCheckbox>("useQLC").Checked && Q.IsReady() && Q.IsLearned;
            var e = LaneClearMenu.Get<MenuCheckbox>("useELC").Checked && E.IsReady() && E.IsLearned;
            

            var minion = MinionManager.GetMinions(Q.Range);

            foreach (var m in minion)
            {
                if (q && m.IsValidTarget() && m.IsMinion)
                {
                    Q.Cast(m);
                }

                if (e && m.IsMinion && m.IsValidTarget())
                {



                   E.Cast(m);

                }

               
            }
        }
    }
}