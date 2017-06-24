using System;
using System.Linq;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using HesaEngine.SDK.GameObjects;
using static Nasus.SpellLoader;
using static Nasus.MenuLoader;

namespace Nasus.Modes

{
    public class Lasthit

    {

        
        private static Obj_AI_Base _LastMinion;

        private static Obj_AI_Base _GetMinion(Spell daSpell)
        {
            Logger.Log("_GetMinion");
            var _Minions = MinionManager.GetMinions(daSpell.Range, MinionTypes.All, MinionTeam.Enemy)
                .OrderBy(x => x.Health);
            if (!_Minions.IsEmpty())
            {
                var Temp = _Minions.FirstOrDefault();
                if (Temp != null && Temp.IsValidTarget(daSpell.Range) && !Temp.IsDead)
                {
                    if (Temp.Equals(_LastMinion))
                    {
                        if (_Minions.Count() > 1)
                        {
                            Temp = _Minions.Skip(1).First();
                        }
                        else
                        {
                            return null;
                        }
                    }

                    if ( >= MinionHealthPrediction.GetHealthPrediction(Temp, Game.GameTimeTickCount,
                            (int) Math.Ceiling(daSpell.Delay)))
                    {
                        Logger.Log("GetWdmg");
                        _LastMinion = Temp;
                        return Temp;
                    }
                }
            }
            return null;
        }

        public static void Initialize()
        {
            if (Q.IsLearned && MenuLoader.LastHitMenu.Get<MenuCheckbox>("useQLH").Checked)
            {
                Logger.Log("Initialize");
                if (Functions.CanUseSpell(SpellSlot.Q))
                {
                    var Target = _GetMinion(SpellLoader.Q);
                    if (Target != null && Target.IsValid())
                    {
                        Core.DelayAction(() => SpellLoader.Q.Cast(), 1);
                        
                    }
                }
            }
        }
    }
}