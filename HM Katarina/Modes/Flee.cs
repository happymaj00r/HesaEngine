
using HesaEngine.SDK;
using static HMKatarina.MenuLoader;
using static HMKatarina.SpellLoader;

namespace HMKatarina.Modes
{
    public static class Flee
    {
        public static void FleeActivate()
        {


            var w = FleeMenu.Get<MenuCheckbox>("useWFlee").Checked && W.IsReady();
            var e = FleeMenu.Get<MenuCheckbox>("useEFlee").Checked && E.IsReady();

            if (w)
            {
                W.Cast();

            }

            var Mpos = Game.CursorPosition;

            if (e)
            {

                E.Cast(Mpos);
            }
        }
    }
}
