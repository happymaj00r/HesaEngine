using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using static Alistar.MenuLoader;
using static Alistar.SpellLoader;
using static Alistar.MenuLoader;
using static Alistar.Initialization;
using HesaEngine.SDK.Enums;
using static  Alistar.Modes.Functions;

namespace Alistar.Modes
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
            var _Target = ObjectManager.Heroes.Enemies.FirstOrDefault(ee => ee.IsValidTarget(R.Range) && Functions.MyHero.GetSpellDamage(ee, SpellSlot.R) + Functions.MyHero.GetSpellDamage(ee, SpellSlot.R)>= ee.Health);
           

             
            
            //-----------------------------------------Basic Combo----------------------------------------------------------------------------//
            
           

            if (w && wtarget != null )
            {


               W.Cast(wtarget);


            }

            if (q && qtarget != null)
            {
                Q.Cast();

            }
            if (r && rtarget != null )

            {
               if (Player.HealthPercent < ComboMenu.Get<MenuSlider>("UseEauto").CurrentValue && Player.HealthPercent != null && Player.Health != null)
                   
                R.Cast();
            }

            
            
           
            if (e && etarget != null )
            {
                E.Cast();

            }
        }
    }
}