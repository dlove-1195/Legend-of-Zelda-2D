using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Sprint2
{
  public static class Texture2DStorage
		{
			// Note that we are not using Game1's ContentLoader here (outside the scope of class methods) since it has not been instantiated yet
			private static Texture2D enemySpriteSheet;
			private static Texture2D itemSpriteSheet;
		    private static Texture2D linkSpriteSheet;
		    private static Texture2D enemySpriteSheet2;

		//initialize the Texture2D fields
		public static void LoadAllTextures(ContentManager content)
			{

			linkSpriteSheet = content.Load<Texture2D>("link");
			enemySpriteSheet = content.Load<Texture2D>("enemy");
			itemSpriteSheet = content.Load<Texture2D>("item");
			enemySpriteSheet2 = content.Load<Texture2D>("enemy2");
		}

		   public static void UnloadAllTextures()
			{
			// unload all the Texture2Ds - not needed for the scope of this project
		
			}

			public static Texture2D GetEnemySpriteSheet()
			{
				return enemySpriteSheet;
			}

		public static Texture2D GetEnemySpriteSheet2()
		{
			return enemySpriteSheet2;
		}


		public static Texture2D GetItemSpriteSheet()
			{
				return itemSpriteSheet;
			}

		    public static Texture2D GetLinkSpriteSheet()
		    {
			return linkSpriteSheet;
		    }

	}
	
}
