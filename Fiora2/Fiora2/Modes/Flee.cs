
using HesaEngine.SDK;
using static Fiora2.MenuLoader;
using static Fiora2.SpellLoader;

namespace Fiora2.Modes
{
    public static class Flee
    {
        public static void FleeActivate()
        {


            var w = FleeMenu.Get<MenuCheckbox>("useWFlee").Checked && Q.IsReady();
            ;


            var Mpos = Game.CursorPosition;

            if (w)
            {

                Q.Cast(Mpos);
            }
        }
    }
}
