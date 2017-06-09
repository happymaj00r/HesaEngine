using System.Linq;
using HesaEngine.SDK;
using static Xin.MenuLoader;
using static Xin.SpellLoader;

namespace Xin.Modes
{

    public class JungleClear
    {

        public static void ActivatedJungle()
        {

            var q = JungleClearMenu.Get<MenuCheckbox>("useQV").Checked && Q.IsReady();
            var e = JungleClearMenu.Get<MenuCheckbox>("useEV").Checked && E.IsReady();
            var w = JungleClearMenu.Get<MenuCheckbox>("useWV").Checked && W.IsReady();



            var minion = ObjectManager.MinionsAndMonsters.NeutralCamps.Where(x => x.IsValidTarget(E.Range));

            foreach (var m in minion)
            {
                if (m.IsValidTarget() && !m.IsDead)
                {



                    if (m != null && m.IsValidTarget() && !m.IsDead && e )
                    {


                        {
                            E.Cast(m);
                        }

                    }


                    if (m != null && m.IsValidTarget() && !m.IsDead && q )
                    {


                        {
                            Q.Cast();
                        }

                    }

                    if (m != null && m.IsValidTarget() && !m.IsDead && w )
                    {


                        {
                            W.Cast();
                        }

                    }

                }


            }
        }
    }
}