using System;
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.Args;
using Xin.Modes;
using SharpDX;
using static HesaEngine.SDK.Logger;
using static Xin.MenuLoader;
using static Xin.SpellLoader;
using static Xin.Modes.Combo;
using static Xin.Modes.Functions;

// >> FUCK THIS!

namespace Xin

{
    public class Initialization : IScript
    {



        public string Name => "XinZhao";

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
            if (ObjectManager.Me.Hero == Champion.XinZhao)
            {

                LoadMenu();
                LoadSpells();
               
                
                
                Game.OnTick += Game_OnTick;

                Orbwalker.AfterAttack += AfterAttack;
                
                Chat.Print("\r\n" +
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

        public static void AfterAttack(AttackableUnit sender, AttackableUnit ArgsTarget)
        {
            if (ComboMenu.Get<MenuCheckbox>("item").Checked)
            {
                var ttarget = TargetSelector.GetTarget(385);
                var rtarget = TargetSelector.GetTarget(385);
                var tiamattarget = TargetSelector.GetTarget(385);
                THydra = new Item(3748, 385);
                RHydra = new Item(3074, 385);
                Tiamat = new Item(3077, 385);
                if (!sender.IsMe || ObjectManager.Me.IsDead)
                    return;

                if (ArgsTarget == null || ArgsTarget.IsDead || ArgsTarget.Health <= 0)
                    return;

                if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.Combo))
                {
                    var target = ArgsTarget as AIHeroClient;

                    if (target != null && !target.IsDead)
                    {

                        if (THydra.IsOwned() && THydra.IsReady())
                        {
                            THydra.Cast(ttarget);
                            
                        }
                        if (RHydra.IsOwned() && RHydra.IsReady())
                        {
                            RHydra.Cast(rtarget);
                        }
                        if (Tiamat.IsOwned() && Tiamat.IsReady())
                        {
                            Tiamat.Cast(tiamattarget);
                        }
                    }
                }
            }

                if (!sender.IsMe || ObjectManager.Me.IsDead)
                    return;

                if (ArgsTarget == null || ArgsTarget.IsDead || ArgsTarget.Health <= 0)
                    return;

                if (Orb.ActiveMode.Equals(Orbwalker.OrbwalkingMode.Combo) &&
                    ComboMenu.Get<MenuCheckbox>("useQA").Checked)
                {
                    var target = ArgsTarget as AIHeroClient;

                    if (target != null && !target.IsDead)
                    {

                        if (Q.IsReady() && target.IsValid())
                        {
                            Q.Cast();
                            Orbwalker.ResetAutoAttackTimer();

                        }

                    }
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