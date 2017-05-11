using System.Dynamic;
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using static Kassadin.MenuLoader;
using static Kassadin.SpellLoader;
using static Kassadin.MenuLoader;
using static Kassadin.Initialization;
using HesaEngine.SDK.Enums;

namespace Kassadin.Modes
{
    public  class Combo
    {




        public static void ActivatedCombo()
        {

            var q = ComboMenu.Get<MenuCheckbox>("useQ").Checked && Q.IsReady();
            var w = ComboMenu.Get<MenuCheckbox>("useW").Checked && W.IsReady();
            var e = ComboMenu.Get<MenuCheckbox>("useE").Checked && E.IsReady();
            var r = ComboMenu.Get<MenuCheckbox>("useR").Checked && R.IsReady();
            var qtarget = TargetSelector.GetTarget(Q.Range);
            var wtarget = TargetSelector.GetTarget(W.Range);
            var rtarget = TargetSelector.GetTarget(R.Range);
            var etarget = TargetSelector.GetTarget(E.Range);




            //-----------------------------------------Basic Combo----------------------------------------------------------------------------//



            if (q && qtarget != null)
            {


                    Q.Cast(qtarget);


            }
            if (r && rtarget != null)

            {

                R.Cast(rtarget.Position);
            }

            if (w && wtarget != null)
            {

                {

                    W.Cast();
                }


            }


            if (e && etarget != null )
            {
                E.Cast(etarget);

            }
        }
    }
}