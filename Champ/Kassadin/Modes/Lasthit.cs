﻿using System;
using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.GameObjects;

namespace Kassadin.Modes

{
    public class Lasthit
    {
        private static Obj_AI_Base _LastMinion;

        private static Obj_AI_Base _GetMinion(Spell daSpell)
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

        public static void Initialize()
        {
            if (MenuLoader.LastHitMenu.Get<MenuCheckbox>("useWLH").Checked)
            {
                if (Functions.CanUseSpell(SpellSlot.W))
                {
                    var Target = _GetMinion(SpellLoader.W);
                    if (Target != null && Target.IsValid())
                    {
                        Core.DelayAction(() => SpellLoader.W.Cast(Target),1);
                    }
                }
            }
        }
    }
}