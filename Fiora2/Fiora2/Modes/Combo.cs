using System.Linq;
using System.Runtime.Serialization.Formatters;
using HesaEngine.SDK;
using SharpDX;
using static Fiora2.MenuLoader;
using static Fiora2.SpellLoader;
using static Fiora2.MenuLoader;
using static Fiora2.Initialization;


namespace Fiora2.Modes
{
    public static class Combo
    {
        public static bool IsValidVector(this Vector3 source) => source != Vector3.Zero;

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

            if (r && rtarget != null&&  rtarget.HealthPercent < ComboMenu.Get<MenuSlider>("UseEauto").CurrentValue  )
            {
                R.Cast(rtarget);

            }
           

            if (q && qtarget != null )
            {

                Q.Cast(qtarget);

            }
            
           
           
            
             
            if (w && wtarget != null )
            {

                
                  W.Cast(wtarget);
                


            }
            


           

           
          


            // EWQR *



            //----------------------------------------------------------------------------------------------------------------------------------//
        }
    }
}