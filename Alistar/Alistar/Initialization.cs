﻿using System;
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.Args;
using Alistar.Modes;
using SharpDX;
using static HesaEngine.SDK.Logger;
using static Alistar.MenuLoader;
using static Alistar.SpellLoader;
using static Alistar.Modes.Combo;
using static Alistar.Modes.Functions;

// >> FUCK THIS!

namespace Alistar

{
    public class Initialization : IScript
    {



        public string Name => "Alistar";

        public string Version => "1.0.0";

        public string Author => "HappyMajor";

        public static Orbwalker.OrbwalkerInstance Orb => Core.Orbwalker;

        public static AIHeroClient Player = ObjectManager.Player;

        private static AIHeroClient _User = Player;

        public static bool Rult;

        public void OnInitialize()
       

        {

            Game.OnGameLoaded += () =>
            {
                Core.DelayAction(Game_OnGameLoaded, new Random().Next(2500, 3001));
            };

        }

        private void Game_OnGameLoaded()
        {
            if (ObjectManager.Me.Hero == Champion.Alistar)
            {

                LoadMenu();
                LoadSpells();
               
                
                
                Game.OnTick += Game_OnTick;

                
                
                Chat.Print("\r\n" +
                           "Thanks for using my Script in love HappyMajor " + Version);
            }
            else
            {
                Chat.Print("I dont Support "+ObjectManager.Me.Hero);
            }
        }

        
    
        
        

        private static void Game_OnTick()
        {



           




             if (KillstealMenu.Get<MenuCheckbox>("useQS").Checked)
            {
                Killsteal.ActivateKS();
            }

            /* COMBO */
            if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.Combo))
            {
                Combo.ActivatedCombo();
            }

            /* HARASS
            if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.Harass))
            {
                Harass.ActivatedHarass();
            } TODO: IMPLEMENT */


             if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.LaneClear))
             {
                 Laneclear.ActivatedLaneClear();
             }


             if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.LastHit))
            {
                Lasthit.Initialize();
            }

            
            if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.JungleClear))
            {
                JungleClear.ActivatedJungle();
            } 


            
        }

    }
}
