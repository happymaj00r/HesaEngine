using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using static HMKatarina.MenuLoader;
using static HMKatarina.Initialization;

namespace HMKatarina
{
    public static class Itemactivator
    {
        public static Item Hextechgunblade;
        


        public static void ItemActivator()
        {
            var me = ObjectManager.Player;
            var target = TargetSelector.GetTarget(725f);
            

            
            Hextechgunblade = new Item(ItemId.Hextech_Gunblade, 725);
            

            if (ItemActivatorMenu.Get<MenuCheckbox>("useG").Checked)

            {
                if (Hextechgunblade.IsOwned() && Hextechgunblade.IsReady() && Orb.ActiveMode == Orbwalker.OrbwalkingMode.Combo && !_isUlting)
                {
                   
                    
                        
                        
                            Hextechgunblade.Cast(target);
                        
                    
                }
            }
        }
    }
}