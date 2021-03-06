﻿using static Alistar.Initialization;

using HesaEngine.SDK;
namespace Alistar
{
     internal class MenuLoader
    {
        public static Menu MainMenu,
            ItemActivatorMenu,
            ComboMenu,
            HarassMenu,
            LastHitMenu,
            LaneClearMenu,
            JungleClearMenu,
            DrawingMenu,
            KillstealMenu,
            FleeMenu;

        public static void LoadMenu()
        {
            MainMenu = Menu.AddMenu("Alistar");
            

            /* Combo Section */
            ComboMenu = MainMenu.AddSubMenu("Combo Menu");
            ComboMenu.Add(new MenuCheckbox("useQ", "Use Normal Q", true));          
            ComboMenu.Add(new MenuCheckbox("useW", "Use W", true));
            ComboMenu.Add(new MenuCheckbox("useE", "Use E", true));
            ComboMenu.Add(new MenuCheckbox("useR", "Use R at X% Health ", true));
            ComboMenu.Add(new MenuSlider("UseEauto", "Use R at X% Health", 0,100,0));          
           
           
           

            /* Last Hit Section */
            

            /* Lane Clear Section */
            LaneClearMenu = MainMenu.AddSubMenu("Lane Clear Menu");
            LaneClearMenu.Add(new MenuCheckbox("useQLC", "Use Q", true));
            LaneClearMenu.Add(new MenuCheckbox("useELC", "Use W", true));
           
            /* Jungle CLear Section */
            JungleClearMenu = MainMenu.AddSubMenu("Jungle Clear Menu");
            JungleClearMenu.Add(new MenuCheckbox("useQV", "Use Q", true));
            JungleClearMenu.Add(new MenuCheckbox("useEV", "Use E", true));
            JungleClearMenu.Add(new MenuCheckbox("useWV", "Use W", true));
            

            /* Killsteal Section */
            KillstealMenu = MainMenu.AddSubMenu("Killsteal Menu");
            KillstealMenu.Add(new MenuCheckbox("useQS", "Enable KillSteall", true));

            ItemActivatorMenu = MainMenu.AddSubMenu("Item Menu WIP");
            ItemActivatorMenu.Add(new MenuCheckbox("useG", "Just tick this", true));


            /* Flee Section */
            

        }
    }
}