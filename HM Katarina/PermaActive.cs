using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Policy;
using HesaEngine.SDK;
using SharpDX;
using static HMKatarina.MenuLoader;
using static HMKatarina.SpellLoader;
using static HMKatarina.MenuLoader;
using static HMKatarina.Initialization;
using static HMKatarina.Dagger;



namespace HMKatarina
{
   public class PermaActive
   {
      
      public static void PermaActivee()
      {

         
         
         var minion = MinionManager.GetMinions(E.Range, MinionTypes.All, MinionTeam.All);
         
            if (  Player.HealthPercent < FleeMenu.Get<MenuSlider>("UseEauto").CurrentValue && Player.HealthPercent != null && Player.Health != null && Player.IsUnderEnemyTurret() && E.IsReady())
            {
               foreach (var m in minion)
               {
                  if (!m.IsUnderEnemyTurret()&& m.IsValid() && m.IsMinion) E.Cast(m.Position);

               }

            }
            
         
        

        
      }
   }
}