using System;
using HesaEngine.SDK;
using SharpDX;
using static Fiora2.MenuLoader;
using static Fiora2.SpellLoader;

namespace Fiora2
{
    public static class DrawingsLoader
    {
        public static void LoadDrawings()
        {
            Drawing.OnDraw += Drawing_OnDraw;
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            if (DrawingMenu.Get<MenuCheckbox>("EnableDrawings").Checked == false) return;

            if (DrawingMenu.Get<MenuCheckbox>("useQDraw").Checked == true && Q.IsReady())
            {
                Drawing.DrawCircle(ObjectManager.Player.Position, Q.Range, Color.Green);
            }


            if (DrawingMenu.Get<MenuCheckbox>("useWDraw").Checked == true && W.IsReady() && W.IsLearned)
            {
                Drawing.DrawCircle(ObjectManager.Player.Position, W.Range, Color.Blue);
            }



            if (DrawingMenu.Get<MenuCheckbox>("useEDraw").Checked == true && E.IsReady() && E.IsLearned)
            {
                Drawing.DrawCircle(ObjectManager.Player.Position, E.Range, Color.Blue);
            }

            if (DrawingMenu.Get<MenuCheckbox>("useRDraw").Checked == true && R.IsReady() && R.IsLearned)
            {
                Drawing.DrawCircle(ObjectManager.Player.Position, 590f, Color.Purple);
            }

        }
    }
}