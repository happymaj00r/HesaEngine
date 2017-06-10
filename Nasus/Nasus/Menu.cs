using static Nasus.Initialization;

using HesaEngine.SDK;
namespace Nasus
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
            MainMenu = Menu.AddMenu("Nasus");
            

            /* Combo Section */
            ComboMenu = MainMenu.AddSubMenu("Combo Menu");
            ComboMenu.Add(new MenuCheckbox("useQ", "Use Q", true));
            ComboMenu.Add(new MenuCheckbox("useW", "Use W", true));
            ComboMenu.Add(new MenuCheckbox("useE", "Use E", true));
            ComboMenu.Add(new MenuCheckbox("useR", "Use R ", true));
            ComboMenu.Add(new MenuSlider("UseEauto", "Use R at X% Health", 0,100,0));
            ComboMenu.Add(new MenuCheckbox("useQA", "Use Q AA cancel ", true));

            /* Last Hit Section */
            LastHitMenu = MainMenu.AddSubMenu("Last Hit Menu");
            LastHitMenu.Add(new MenuCheckbox("useQLH", "Use Q", true));
            LastHitMenu.Add(new MenuCheckbox("useQAUTO", "Auto Q Not working", true));

            /* Lane Clear Section */
            LaneClearMenu = MainMenu.AddSubMenu("Lane Clear Menu");
            LaneClearMenu.Add(new MenuCheckbox("useQLC", "Use Q", true));
            LaneClearMenu.Add(new MenuCheckbox("useELC", "Use E", true));
           

            

            /* Killsteal Section */
            KillstealMenu = MainMenu.AddSubMenu("Killsteal Menu");
            KillstealMenu.Add(new MenuCheckbox("useQS", "Enable KillSteall", true));

            ItemActivatorMenu = MainMenu.AddSubMenu("Item Menu WIP");
            ItemActivatorMenu.Add(new MenuCheckbox("useG", "Just tick this", true));


            /* Flee Section */
            FleeMenu = MainMenu.AddSubMenu("Flee Menu");

            FleeMenu.Add(new MenuCheckbox("useRFlee", "Use W", true));

        }
    }
}