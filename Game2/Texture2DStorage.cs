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
			private static Texture2D linkSpriteSheet2;
		private static Texture2D npcSpriteSheet;
 
		    private static Texture2D enemySpriteSheet2;
		   private static Texture2D enemySpriteSheet3;

		private static Texture2D woodenBoomerangSpriteSheet;
        private static Texture2D blueCandleSpriteSheet;
        private static Texture2D bowSpriteSheet;
		private static Texture2D dungeonSpriteSheet;



		//initialize the Texture2D fields
		public static void LoadAllTextures(ContentManager content)
			{
			if (content == null)
			{
				throw new System.ArgumentNullException(nameof(content));
			}
			linkSpriteSheet = content.Load<Texture2D>("link");
			enemySpriteSheet = content.Load<Texture2D>("enemy");
			itemSpriteSheet = content.Load<Texture2D>("item");
			npcSpriteSheet = content.Load<Texture2D>("characters");

			linkSpriteSheet2 = content.Load<Texture2D>("link--final");

			enemySpriteSheet2 = content.Load<Texture2D>("enemy2");
			enemySpriteSheet3 = content.Load<Texture2D>("enemy3");
			bowSpriteSheet = content.Load<Texture2D>("bow");
            woodenBoomerangSpriteSheet = content.Load<Texture2D>("woodenboomerang");
            blueCandleSpriteSheet = content.Load<Texture2D>("candle");
			dungeonSpriteSheet = content.Load<Texture2D>("dugeon");

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

		public static Texture2D GetEnemySpriteSheet3()
		{
			return enemySpriteSheet3;
		}
		public static Texture2D GetBowSpriteSheet()
        {
            return bowSpriteSheet;
        }
        public static Texture2D GetWoodBoomerangSpriteSheet()
        {
            return woodenBoomerangSpriteSheet;
        }
        public static Texture2D GetBlueCandleSpriteSheet()
        {
            return blueCandleSpriteSheet;
        }


        public static Texture2D GetItemSpriteSheet()
			{
				return itemSpriteSheet;
			}

		    public static Texture2D GetLinkSpriteSheet()
		    {
				return linkSpriteSheet;
		    }
			public static Texture2D GetNpcSpriteSheet()
			{
				return npcSpriteSheet;
			}
		public static Texture2D GetLinkSpriteSheet2()
		{
			return linkSpriteSheet2;
		}
		public static Texture2D GetDungeonSpriteSheet()
		{
			return dungeonSpriteSheet;
		}
	}
	
}
