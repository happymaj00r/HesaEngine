﻿/*using HesaEngine.SDK;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Policy;
using HesaEngine.SDK;
using SharpDX;
using static Alistar.MenuLoader;
using static Alistar.SpellLoader;
using static Alistar.MenuLoader;
using static Alistar.Initialization;
using static Alistar.Modes.Lasthit;
namespace Alistar
{
    public class PermaActive
    {
      
        public static void Initialize()
        {
            if (MenuLoader.LastHitMenu.Get<MenuCheckbox>("useQAUTO").Checked)
            {
                if (Q.IsReady())
                {

                    var Target = _GetMinionW(SpellLoader.Q);
                    if (Target != null && Target.IsValid())
                    {
                        Core.DelayAction(() => SpellLoader.Q.Cast(Target.Position), 1);
                        Core.Orbwalker.ForceTarget(Target);
                        
                    }
                }
            }
        }
    }
}
*/