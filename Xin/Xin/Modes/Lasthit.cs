using System;
using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.GameObjects;
using static Xin.SpellLoader;
using static Xin.MenuLoader;

namespace Xin.Modes

{
    public class Lasthit
    
    {
        
        static float GetUnitTotalAD(Obj_AI_Base unit)
        {
            return unit.BaseAttackDamage + unit.FlatBaseAttackDamageMod;
        }
        
        static double GetWdmg(Obj_AI_Base target)
        {
            int qedmg = 0;
            if (ObjectManager.Player.GetSpell(SpellSlot.Q).Level == 1)
            {
                qedmg = 30;
            }
            if (ObjectManager.Player.GetSpell(SpellSlot.Q).Level == 2)
            {
                qedmg = 50;
            }
            if (ObjectManager.Player.GetSpell(SpellSlot.Q).Level == 3)
            {
                qedmg = 70;
            }
            if (ObjectManager.Player.GetSpell(SpellSlot.Q).Level == 4)
            {
                qedmg = 90;
            }
            if (ObjectManager.Player.GetSpell(SpellSlot.Q).Level == 5)
            {
                qedmg = 100;

            }
            double calc = GetUnitTotalAD(ObjectManager.Me) * 1.0;
            double full = calc + qedmg;
            double damage = ObjectManager.Player.CalcDamage(target, Damage.DamageType.Physical, full);
            return damage;

        }
        private static Obj_AI_Base _LastMinion;
        private static Obj_AI_Base _GetMinionQ(Spell daSpell)
        {
            var _Minions = MinionManager.GetMinions(daSpell.Range, MinionTypes.All, MinionTeam.Enemy).OrderBy(x => x.Health);
            if (!_Minions.IsEmpty())
            {
                var Temp = _Minions.FirstOrDefault();
                if (Temp != null && Temp.IsValidTarget(daSpell.Range) && !Temp.IsDead)
                {
                    if (Temp.Equals(_LastMinion))
                    {
                        if (_Minions.Count() > 1) { Temp = _Minions.Skip(1).First(); } else { return null; }
                    }

                    if (daSpell.GetDamage(Temp) >= MinionHealthPrediction.GetHealthPrediction(Temp, Game.GameTimeTickCount, (int)Math.Ceiling(daSpell.Delay)))
                    {
                        _LastMinion = Temp;
                        return Temp;
                    }
                }
            }
            return null;
        }
        
       public static Obj_AI_Base _GetMinionW(Spell daSpell)
        {
            var _Minions = MinionManager.GetMinions(daSpell.Range, MinionTypes.All, MinionTeam.Enemy).OrderBy(x => x.Health);
            if (!_Minions.IsEmpty())
            {
                var Temp = _Minions.FirstOrDefault();
                if (Temp != null && Temp.IsValidTarget(daSpell.Range) && !Temp.IsDead)
                {
                    if (Temp.Equals(_LastMinion))
                    {
                        if (_Minions.Count() > 1) { Temp = _Minions.Skip(1).First(); } else { return null; }
                    }

                    if (GetWdmg(Temp) >= MinionHealthPrediction.GetHealthPrediction(Temp, Game.GameTimeTickCount, (int)Math.Ceiling(daSpell.Delay)))
                    {
                        _LastMinion = Temp;
                        return Temp;
                    }
                }
            }
            return null;
        }
        public static void Initialize()
        {
            if (MenuLoader.LastHitMenu.Get<MenuCheckbox>("useQLH").Checked)
            {
                if (Q.IsReady())
                {

                    var Target = _GetMinionW(SpellLoader.Q);
                    if (Target != null && Target.IsValid())
                    {
                        Core.DelayAction(() => SpellLoader.Q.Cast(), 1);
                        Core.Orbwalker.ForceTarget(Target);
                    }
                }
            }
            
        }
    }
}