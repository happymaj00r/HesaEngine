using System;
using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.Args;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.GameObjects;
using SharpDX;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using Fiora.Modes;
using HesaEngine.SDK.Events;
using static Fiora.Modes.Combo;
namespace Fiora
{
    public class Initialization : IScript
    {



        public string Name => "Fiora";

        public string Version => "1.5.1";

        public string Author => "HappyMajor";

        public static Orbwalker.OrbwalkerInstance Orb => Core.Orbwalker;

        public static AIHeroClient Player = ObjectManager.Player;

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
            if (ObjectManager.Me.Hero == Champion.Fiora)
            {



                Game.OnTick += Game_OnTick;



                Chat.Print("Now u can call yourself Fiora\r\n" +
                           "Thanks for using my Script in love HappyMajor " + Version);
            }
            else
            {
                Chat.Print("I dont Support "+ObjectManager.Me.Hero);
            }
        }




        private static void Game_OnTick()
        {








            /*if (KillstealMenu.Get<MenuCheckbox>("useKS").Checked)
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

            /* LAST HIT */
            /*if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.LastHit))
           {
               LastHit.Initialize();
           }

           /* JUNGLE CLEAR
           if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.JungleClear))
           {
               Jungleclear.ActivatedJungleClear();
           } TODO: IMPLEMENT */

            /* FLEE */
           // if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.Flee))
            //{
             //   Flee.FleeActivate();
           // }
        }

    }
}
