using System.Linq;
using System.Runtime.Serialization.Formatters;
using HesaEngine.SDK;
using SharpDX;
using static Hero.MenuLoader;
using static Hero.SpellLoader;
using static Hero.MenuLoader;
using static Hero.Initialization;


namespace Hero.Modes
{
    public static class Combo
    {
        public static bool IsValidVector(this Vector3 source) => source != Vector3.Zero;

        public static void ActivatedCombo()
        {

            var q = ComboMenu.Get<MenuCheckbox>("useQ").Checked && Q.IsReady();
            var w = ComboMenu.Get<MenuCheckbox>("useW").Checked && W.IsReady();
            var e = ComboMenu.Get<MenuCheckbox>("useE").Checked && E.IsReady();
                   
            var qtarget = TargetSelector.GetTarget(Q.Range);
            var wtarget = TargetSelector.GetTarget(W.Range);
           
            var etarget = TargetSelector.GetTarget(E.Range);



            //-----------------------------------------Basic Combo----------------------------------------------------------------------------//


            
            
            

       
           

            if (q && _isUlting != true)
            {
                if (qtarget != null)
                {
                    Q.Cast(qtarget);
                }

            }
            
            if (w && wtarget != null && _isUlting != true)
            {

                if (wtarget.IsValidTarget(W.Range))

                {
                    W.Cast(wtarget);
                }


            }
            
            
            if ( etarget != null && e && _isUlting != true )
            {
              
                    E.Cast(etarget);
            }
           
           
 
            
             
            


            

           

           
          


            // EWQR *



            //----------------------------------------------------------------------------------------------------------------------------------//
        }
    }
}