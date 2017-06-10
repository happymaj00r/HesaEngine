using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using static Nasus.MenuLoader;
using static Nasus.SpellLoader;
using static Nasus.MenuLoader;
using static Nasus.Initialization;
using HesaEngine.SDK.Enums;

namespace Nasus.Modes
{
    public  class Combo
    {


        

        public static void ActivatedCombo()
        {

            var q = ComboMenu.Get<MenuCheckbox>("useQ").Checked && Q.IsReady();
            var w = ComboMenu.Get<MenuCheckbox>("useW").Checked && W.IsReady();
            var e = ComboMenu.Get<MenuCheckbox>("useE").Checked && E.IsReady();
            var r = ComboMenu.Get<MenuCheckbox>("useR").Checked && R.IsReady();
            var QA = ComboMenu.Get<MenuCheckbox>("useQA").Checked;
            var qtarget = TargetSelector.GetTarget(Q.Range);
            var wtarget = TargetSelector.GetTarget(W.Range);
            var rtarget = TargetSelector.GetTarget(R.Range);
            var etarget = TargetSelector.GetTarget(E.Range);




            //-----------------------------------------Basic Combo----------------------------------------------------------------------------//



            if (q && qtarget != null && !QA)
            {


               Q.Cast();


            }

            if (w && wtarget != null)
            {
                W.Cast(wtarget);

            }
            if (r && rtarget != null )

            {
               if (Player.HealthPercent < ComboMenu.Get<MenuSlider>("UseEauto").CurrentValue && Player.HealthPercent != null)
                   
                R.Cast();
            }

            


            if (e && etarget != null )
            {
                E.Cast(etarget.Position);

            }
        }
    }
}