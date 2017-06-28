using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using static Fiora2.MenuLoader;
using static Fiora2.Initialization;

namespace Fiora2
{
    public static class Itemactivator
    {
        public static Item Hextechgunblade;
        public static Item Botrk;
        public static Item Cutlass;


        public static void ItemActivator()
        {
            var me = ObjectManager.Player;
            var target = TargetSelector.GetTarget(725f);
            var btarget = TargetSelector.GetTarget(550);
            var ctarget = TargetSelector.GetTarget(550);

            
            Hextechgunblade = new Item(ItemId.Hextech_Gunblade, 725);
            Cutlass = new Item(ItemId.Bilgewater_Cutlass, 550f);
            Botrk = new Item(ItemId.Blade_of_the_Ruined_King, 550f);

            if (ItemActivatorMenu.Get<MenuCheckbox>("useG").Checked)

            {
                if (Hextechgunblade.IsOwned() && Hextechgunblade.IsReady() && Orb.ActiveMode == Orbwalker.OrbwalkingMode.Combo )
                {
                           Hextechgunblade.Cast(target);
                  
                }
                if (Cutlass.IsOwned() && Cutlass.IsReady() && Orb.ActiveMode == Orbwalker.OrbwalkingMode.Combo)
                {
                            Cutlass.Cast(ctarget);
                }
                if (Botrk.IsOwned() && Botrk.IsReady() && Orb.ActiveMode == Orbwalker.OrbwalkingMode.Combo)
                {
                             Botrk.Cast(btarget);
                }
            }
        }
    }
}