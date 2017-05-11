using HesaEngine.SDK;
using static Kassadin.SpellLoader;
namespace Kassadin.Modes
{
    public class Flee


    {
        public static void FleeActivate()
        {


            var Mpos = Game.CursorPosition;

            if (R.IsReady())
        {

            R.Cast(Mpos);
        }
    }
    }
}