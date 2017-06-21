using HesaEngine.SDK;
using static Xin.SpellLoader;
namespace Xin.Modes
{
    public class Flee


    {
        public static void FleeActivate()
        {
            var wtarget = TargetSelector.GetTarget(W.Range);


            if (W.IsReady())
        {

            W.Cast(wtarget);
        }
    }
    }
}