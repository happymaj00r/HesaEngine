using HesaEngine.SDK;
using static HMKatarina.MenuLoader;
using static HMKatarina.SpellLoader;
using static HMKatarina.MenuLoader;
using static HMKatarina.Initialization;
using static HMKatarina.Dagger;

namespace HMKatarina.Modes
{
    public static class Combo
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
            var d = Dagger.GetClosestDagger();

            if (q && _isUlting != true)
            {
                if (qtarget != null)
                {
                    Q.Cast(qtarget);
                }

            }
            if (!Q.IsReady() && etarget != null && e && _isUlting != true && etarget.Position.IsInRange(d, W.Range))

            {

               E.Cast(GetBestDaggerPoint(d, etarget));
            }
            else if(!Q.IsReady() && etarget != null && _isUlting != true)

            if (W.IsReady() && wtarget != null && _isUlting != true)
            {

                if (wtarget.IsValidTarget(W.Range))

                {
                    W.Cast();
                }


            }


            if (r && rtarget != null && _isUlting != true && !E.IsReady() && !W.IsReady())
            {
                R.Cast(rtarget);

            }






            /*if (E.IsReady() && etarget.IsInRange(Player.Position, E.Range) && etarget != null)
            {

                if (etarget.Position.IsInRange(d, W.Range)) E.Cast(GetBestDaggerPoint(d, etarget));
                else if (Player.Distance(etarget) >= W.Range && etarget != null && d != null)
                    E.Cast(etarget.Position);
            }


          */


         // EWQR *



            //----------------------------------------------------------------------------------------------------------------------------------//
        }
    }
}
