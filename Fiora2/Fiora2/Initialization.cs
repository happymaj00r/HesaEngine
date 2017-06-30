using System;
using Fiora2.Modes;
using static Fiora2.SpellLoader;
using static Fiora2.MenuLoader;
using static Fiora2.DrawingsLoader;
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.Args;
using static HesaEngine.SDK.Logger;
using static Fiora2.Itemactivator;
// >> FUCK THIS!

namespace Fiora2

{
    public class Initialization : IScript
    {



        public string Name => "HM Fiora";

        public string Version => "0.1.0";

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
            if (ObjectManager.Me.Hero == Champion.Fiora)
            {

              LoadMenu();
              LoadSpells();
              LoadDrawings();
                
                Game.OnTick += Game_OnTick;
                
                Obj_AI_Base.OnBuffLost += OnBuffLose;
               
                
                Orbwalker.AfterAttack += AfterAttack;


              Chat.Print(
                         "Thanks for using my Script in love HappyMajor " + Version);
            }
            else
            {
              Chat.Print("I dont Support "+ObjectManager.Me.Hero);
            }
        }
        
        public static Item THydra;
        public static Item RHydra;
        public static Item Tiamat;
        
      
        public static void OnBuffLose(Obj_AI_Base sender, Obj_AI_BaseBuffLostEventArgs args)

        {
            if (args.Buff.Name.ToLower() == "FioraE" || args.Buff.Name.ToLower() == "fiorae" && Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.Combo))
            {
               
                var items = ItemActivatorMenu.Get<MenuCheckbox>("useG").Checked;
                var ttarget = TargetSelector.GetTarget(385);
                var rtarget = TargetSelector.GetTarget(385);
                var tiamattarget = TargetSelector.GetTarget(385);
                THydra = new Item(3748, 385);
                RHydra = new Item(3074, 385);
                Tiamat = new Item(3077, 385);

                if (THydra.IsOwned() && THydra.IsReady() && items)
                {
                    Orbwalker.ResetAutoAttackTimer();
                    THydra.Cast(ttarget);
                   
                }
                if (RHydra.IsOwned() && RHydra.IsReady() && items)
                {
                    RHydra.Cast();
                   
                }
                if (Tiamat.IsOwned() && Tiamat.IsReady() && items)
                {
                    Tiamat.Cast(tiamattarget);
                }
               
              



            }
        }

        
        public static void AfterAttack(AttackableUnit sender, AttackableUnit ArgsTarget)
        {
           
               
                if (!sender.IsMe || ObjectManager.Me.IsDead)
                    return;

                if (ArgsTarget == null || ArgsTarget.IsDead || ArgsTarget.Health <= 0)
                    return;

                if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.Combo) && ComboMenu.Get<MenuCheckbox>("useE").Checked )
                {
                    var target = ArgsTarget as AIHeroClient;

                    if (target != null && !target.IsDead)
                    {


                        if (E.IsReady() && target.IsValid())
                        {
                            E.Cast();
                            Orbwalker.ResetAutoAttackTimer();
                            
                        }

                        
                    }
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
