using static Fiora2.Initialization;
using HesaEngine.SDK;
namespace Fiora2
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
            MainMenu = Menu.AddMenu("HM Fiora");
            

            /* Combo Section */
            ComboMenu = MainMenu.AddSubMenu("Combo Menu");
            ComboMenu.Add(new MenuCheckbox("useQ", "Use Q", true));
            ComboMenu.Add(new MenuCheckbox("useW", "Use W (not recommended)", true));
            ComboMenu.Add(new MenuCheckbox("useE", "Use E", true));
            ComboMenu.Add(new MenuCheckbox("useR", "Use R ", true));
           
            /* Last Hit Section */
            LastHitMenu = MainMenu.AddSubMenu("Last Hit Menu");
            LastHitMenu.Add(new MenuCheckbox("useQLH", "Use Q", true));

            /* Lane Clear Section */
            LaneClearMenu = MainMenu.AddSubMenu("Lane Clear Menu");
            LaneClearMenu.Add(new MenuCheckbox("useQLC", "Use Q", true));
            LaneClearMenu.Add(new MenuCheckbox("useELC", "Use E", true));
            LaneClearMenu.Add(new MenuCheckbox("useWLC", "Use W", true));

            /* Drawings Section */
            DrawingMenu = MainMenu.AddSubMenu("Drawings Menu");
            DrawingMenu.Add(new MenuCheckbox("EnableDrawings", "Enable Drawings?", false));
            DrawingMenu.Add(new MenuCheckbox("useQDraw", "Draw Q", false));
            DrawingMenu.Add(new MenuCheckbox("useWDraw", "Draw W", false));
            DrawingMenu.Add(new MenuCheckbox("useRDraw", "Draw R", false));
            DrawingMenu.Add(new MenuCheckbox("useEDraw", "Draw E", false));

            /* Killsteal Section */
            KillstealMenu = MainMenu.AddSubMenu("Killsteal Menu");
            KillstealMenu.Add(new MenuCheckbox("useKS", "Enable KillSteall", true));

            ItemActivatorMenu = MainMenu.AddSubMenu("Item Menu WIP");
            ItemActivatorMenu.Add(new MenuCheckbox("useG", "Use Items", true));
            


            /* Flee Section */
            FleeMenu = MainMenu.AddSubMenu("Flee Menu");
            FleeMenu.Add(new MenuCheckbox("useWFlee", "Use Q", true));
          
            
            

        }
    }
}
