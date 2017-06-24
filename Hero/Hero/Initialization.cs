using System;
using Hero.Modes;
using static Hero.SpellLoader;
using static Hero.MenuLoader;
using static Hero.DrawingsLoader;
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.Args;
using static HesaEngine.SDK.Logger;
using static Hero.Itemactivator;
// >> FUCK THIS!

namespace Hero

{
    public class Initialization : IScript
    {



        public string Name => "Pantheon";

        public string Version => "1.4.1";

        public string Author => "HappyMajor";

        public static Orbwalker.OrbwalkerInstance Orb => Core.Orbwalker;

        public static AIHeroClient Player = ObjectManager.Player;

       

        public static bool Rult;

        public void OnInitialize()


        {

            Game.OnGameLoaded += () =>
            {
                Game_OnGameLoaded();
            };

        }

        private void Game_OnGameLoaded()
        {
            if (ObjectManager.Me.Hero == Champion.Pantheon)
            {

              LoadMenu();
              LoadSpells();
              LoadDrawings();

                Game.OnTick += Game_OnTick;
                Obj_AI_Base.OnBuffGained += OnBuffGain;
                Obj_AI_Base.OnBuffLost += OnBuffLose;


              Chat.Print(
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
            if (args.Buff.Name.ToLower() == "pantheonesound" ||  _isChannelingImportantSpell || args.Buff.Name.ToLower() == "pantheonhitsound" )
            {

               Logger.Log("1");
                Orbwalker.Move = false;
                Orbwalker.Attack = false;
                _isUlting = true;



            }
        }

       public static void OnBuffLose(Obj_AI_Base sender, Obj_AI_BaseBuffLostEventArgs args)
        {
            if (args.Buff.Name.ToLower() == "pantheonesound"   || args.Buff.Name.ToLower() == "pantheonhitsound" )
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
           
           Itemactivator.ItemActivator();
        }

    }
}
