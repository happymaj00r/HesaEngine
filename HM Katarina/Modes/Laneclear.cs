using HesaEngine.SDK;
using static HMKatarina.MenuLoader;
using static HMKatarina.SpellLoader;

namespace HMKatarina.Modes
{
    public static class Laneclear
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

                else if (e && m.IsMinion && m.IsValidTarget())
                {
                    Logger.Log("E should be castes Lclear");
                    E.Cast(m.Position);
                }
            }
        }
    }
}
//needs dont jumper tower like in Comb