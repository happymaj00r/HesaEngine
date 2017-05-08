
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

            if (w)
            {
                W.Cast();

            }


        }
    }
}
