using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using StardewValley.Menus;
using Microsoft.Xna.Framework.Graphics;

namespace catGifts
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            TimeEvents.AfterDayStarted += this.AfterDayStarted;
        }

        public void AfterDayStarted(object sender, EventArgs e)
        {            
            Game1.getLocationFromName("Farm").dropObject(new StardewValley.Object(393, 1, false, -1, 0), new Vector2(64, 16) * 64f, Game1.viewport, true, (Farmer)null);
            this.Monitor.Log("Object dropped!");
        }

    }
}
