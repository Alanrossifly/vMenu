using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitizenFX.Core;
using CitizenFX.Core.Native;

using ScaleformUI.Elements;
using ScaleformUI.Menu;

using vMenu.Client.Functions;
using vMenu.Client.Settings;

using static CitizenFX.Core.Native.API;

namespace vMenu.Client.Menus
{
    public class VehicleOptionsMenu
    {
        public static MenuFunctions MenuFunctions = new MenuFunctions();

        private static UIMenu vehicleRelatedOptions = null;

        public VehicleOptionsMenu()
        {
            vehicleRelatedOptions = new Objects.vMenu("Vehicle Options").Create();

            UIMenuSeparatorItem button = new UIMenuSeparatorItem("Under Construction!", false)
            {
                MainColor = MenuSettings.Colours.Spacers.BackgroundColor,
                HighlightColor = MenuSettings.Colours.Spacers.HighlightColor,
                HighlightedTextColor = MenuSettings.Colours.Spacers.HighlightedTextColor,
                TextColor = MenuSettings.Colours.Spacers.TextColor
            };

            vehicleRelatedOptions.AddItem(button);

            Main.Menus.Add(vehicleRelatedOptions);
        }

        public static UIMenu Menu()
        {
            return vehicleRelatedOptions;
        }
    }
}