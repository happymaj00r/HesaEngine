using System.Linq;
using HesaEngine.SDK;
using static Alistar.MenuLoader;
using static Alistar.SpellLoader;

namespace Alistar.Modes
{

    public class JungleClear
    {

        public static void ActivatedJungle()
        {

            var q = JungleClearMenu.Get<MenuCheckbox>("useQV").Checked && Q.IsReady();
            var e = JungleClearMenu.Get<MenuCheckbox>("useEV").Checked && E.IsReady();
            var w = JungleClearMenu.Get<MenuCheckbox>("useWV").Checked && W.IsReady();



            var minion = ObjectManager.MinionsAndMonsters.NeutralCamps.Where(x => x.IsValidTarget(W.Range));

            foreach (var m in minion)
            {
                if (m.IsValidTarget() && !m.IsDead)
                {



                    if (m != null && m.IsValidTarget() && !m.IsDead && w )
                    {


                        {
                            W.Cast(m);
                        }

                    }


                    if (m != null && m.IsValidTarget() && !m.IsDead && q )
                    {


                        {
                            Q.Cast();
                        }

                    }

                    if (m != null && m.IsValidTarget() && !m.IsDead && e )
                    {


                        {
                            E.Cast(m);
                        }

                    }

                }


            }
        }
    }
}