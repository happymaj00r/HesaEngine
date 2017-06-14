using System;
using HMKatarina.Modes;
using static HMKatarina.SpellLoader;
using static HMKatarina.MenuLoader;
using static HMKatarina.DrawingsLoader;
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.Args;
using static HesaEngine.SDK.Logger;
using static HMKatarina.Itemactivator;
// >> FUCK THIS!

namespace HMKatarina

{
    public class Initialization : IScript
    {



        public string Name => "HM DaqqerQueen";

        public string Version => "1.7.0";

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
            if (ObjectManager.Me.Hero == Champion.Katarina)
            {

              LoadMenu();
              LoadSpells();
              LoadDrawings();

                Game.OnTick += Game_OnTick;
                Obj_AI_Base.OnBuffGained += OnBuffGain;
                Obj_AI_Base.OnBuffLost += OnBuffLose;


              Chat.Print("Now u can call yourself DaqqerQueen\r\n" +
                         "Thanks for using my Script in love HappyMajor " + Version);
            }
            else
            {
              Chat.Print("I dont Support "+ObjectManager.Me.Hero);
            }
        }

       public static bool _isChannelingImportantSpell;
        public static bool _isUlting;

       public static void OnBuffGain(Obj_AI_Base sender, Obj_AI_BaseBuffGainedEventArgs args)

        {
            if (args.Buff.Name.ToLower() == "katarinarsound" || args.Buff.Name.ToLower() == "katarinar" || _isChannelingImportantSpell )
            {

               Logger.Log("1");
                Orbwalker.Move = false;
                Orbwalker.Attack = false;
                _isUlting = true;



            }
        }

       public static void OnBuffLose(Obj_AI_Base sender, Obj_AI_BaseBuffLostEventArgs args)
        {
            if (args.Buff.Name.ToLower() == "katarinarsound" || args.Buff.Name.ToLower() == "katarinar")
            {
                Log("2");
                Orbwalker.Move = true;
                Orbwalker.Attack = true;
                _isUlting = false;
            }
        }


        private static void Game_OnTick()
        {









            if (KillstealMenu.Get<MenuCheckbox>("useKS").Checked)
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
            if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.LastHit))
            {
                LastHit.Initialize();
            }

            /* JUNGLE CLEAR
            if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.JungleClear))
            {
                Jungleclear.ActivatedJungleClear();
            } TODO: IMPLEMENT */

            /* FLEE */
            if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.Flee))
            {
                Flee.FleeActivate();
            }

           Itemactivator.ItemActivator();
        }

    }
}
