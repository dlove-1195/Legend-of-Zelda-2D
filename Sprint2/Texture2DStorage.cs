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
<<<<<<< HEAD
<<<<<<< HEAD
			private static Texture2D npcSpriteSheet;
=======
		    private static Texture2D enemySpriteSheet2;
>>>>>>> ba55c543995b85dd56b6950a590507da5c4f25a7
=======
		    private static Texture2D enemySpriteSheet2;
>>>>>>> ba55c543995b85dd56b6950a590507da5c4f25a7

		//initialize the Texture2D fields
		public static void LoadAllTextures(ContentManager content)
			{

			linkSpriteSheet = content.Load<Texture2D>("link");
			enemySpriteSheet = content.Load<Texture2D>("enemy");
			itemSpriteSheet = content.Load<Texture2D>("item");
<<<<<<< HEAD
<<<<<<< HEAD
			npcSpriteSheet = content.Load<Texture2D>("characters");


=======
			enemySpriteSheet2 = content.Load<Texture2D>("enemy2");
>>>>>>> ba55c543995b85dd56b6950a590507da5c4f25a7
=======
			enemySpriteSheet2 = content.Load<Texture2D>("enemy2");
>>>>>>> ba55c543995b85dd56b6950a590507da5c4f25a7
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
			public static Texture2D GetNpcSpriteSheet()
			{
				return npcSpriteSheet;
			}


	}
	
}
