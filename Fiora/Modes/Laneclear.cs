﻿using HesaEngine.SDK;
using System;
using HesaEngine.SDK;
using HesaEngine.SDK.GameObjects;
using static Fiora.MenuLoader;
using static Fiora.SpellLoader;

namespace Fiora.Modes
{
    public static class Laneclear
    {
        public static void ActivatedLaneClear()
        {



            
            var q = LaneClearMenu.Get<MenuCheckbox>("useQLC").Checked && Q.IsReady() && Q.IsLearned;
            var e = LaneClearMenu.Get<MenuCheckbox>("useELC").Checked && E.IsReady() && E.IsLearned;
            var w = LaneClearMenu.Get<MenuCheckbox>("useWLC").Checked && W.IsReady() && E.IsLearned;

            var minion = MinionManager.GetMinions(Q.Range);

            foreach (var m in minion)
            {
                if (q && m.IsValidTarget() && m.IsMinion)
                {
                    Q.Cast(m);
                }

                if (e && m.IsMinion && m.IsValidTarget() && !m.Position.IsUnderEnemyTurret())
                {
                    

                    }
                    else
                    {

                        E.Cast(m.Position);
                    }
                }

               
            }
        }
    }
