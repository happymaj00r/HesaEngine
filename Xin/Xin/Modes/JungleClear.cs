using System.Linq;
using HesaEngine.SDK;
using static Xin.MenuLoader;
using static Xin.SpellLoader;

namespace Xin.Modes
{

    public class JungleClear
    {

        public static void ActivatedLaneClear()
        {

            var q = LaneClearMenu.Get<MenuCheckbox>("useQV").Checked && Q.IsReady();
            var e = LaneClearMenu.Get<MenuCheckbox>("useEV").Checked && E.IsReady();
            var w = LaneClearMenu.Get<MenuCheckbox>("useWV").Checked && W.IsReady();



            var minion = ObjectManager.MinionsAndMonsters.NeutralCamps.Where(x => x.IsValidTarget(Q.Range));

            foreach (var m in minion)
            {
                if ( m.IsValidTarget() && !m.IsDead && e)
                {
                 
                            
                            {
                                E.Cast(m);
                            }
                
                }
                
                
                if ( m.IsValidTarget() && !m.IsDead && q)
                {
                 
                            
                    {
                        Q.Cast();
                    }
                
                }
                
                if ( m.IsValidTarget() && !m.IsDead && w)
                {
                 
                            
                    {
                        W.Cast();
                    }
                
                }
                
                
                
                
            }
        }
    }
}