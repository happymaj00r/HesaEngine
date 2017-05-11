using System;
using System.Security.Cryptography.X509Certificates;
using HesaEngine.SDK;
using HesaEngine.SDK.Enums;
using static HesaEngine.SDK.Item;
using static Kassadin.Initialization;
using static Kassadin.MenuLoader;
using HesaEngine.SDK.GameObjects;
using static Kassadin.SpellLoader;

namespace Kassadin.Modes
{
    public class Item
    {

        public static void Activator()
        {







            if (ItemActivatorMenu.Get<MenuCheckbox>("useG").Checked)
            {
                var _HealBuffs = Functions.MyHero.HasBuff("regenerationpotion")
                                 || Functions.MyHero.HasBuff("itemminiregenpotion")
                                 || Functions.MyHero.HasBuff("itemcrystalflask")
                                 || Functions.MyHero.HasBuff("itemdarkcrystalflask")
                                 || Functions.MyHero.HasBuff("itemcrystalflaskjungle")
                                 || Functions.MyHero.InFountain();

                if (!_HealBuffs)
                {
                    if (CanUseItem(ItemId.Health_Potion))
                    {
                        if (ItemActivatorMenu.Get<MenuCheckbox>("useG").Checked)
                        {
                            if (Functions.MyHero.HasBuffOfType(BuffType.Damage) ||
                                Functions.MyHero.HasBuffOfType(BuffType.Poison))
                            {
                                UseItem(ItemId.Health_Potion);
                            }
                        }
                        else if (Functions.MyHero.HealthPercent < 20)
                        {
                            UseItem(ItemId.Health_Potion);
                        }
                    }
                }



            }




        }









    }
}
































































