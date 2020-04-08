﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Sprint2
{
	public static class Sound
	{

		private static Song mainBgm;
		private static Song room;
		private static ContentManager contentManager;
		private static SoundEffect linkDemage;
		private static SoundEffect itemCollision;

		public static void LoadBGM(ContentManager content)
		{
			contentManager = content;
			mainBgm = contentManager.Load<Song>("bgm");
			room = contentManager.Load<Song>("room");
			linkDemage = contentManager.Load<SoundEffect>("collision");
			itemCollision = contentManager.Load<SoundEffect>("itemCollision");
			

		}

		public static void PlayMainSong()
		{
			MediaPlayer.Play(mainBgm);
			MediaPlayer.MediaStateChanged += MediaPlayer_MediaStateChangedMainBGM;
		}
		public static void PlayRoom()
		{
			MediaPlayer.Play(room);
			MediaPlayer.MediaStateChanged += MediaPlayer_MediaStateChangedRoom;
		}
		public static void PlayLinkDemage()
		{
			linkDemage.Play();
		}

		public static void PlayItemCollision()
		{
			itemCollision.Play();
		}
		static void MediaPlayer_MediaStateChangedMainBGM(object sender, System.
										   EventArgs e)
		{
			MediaPlayer.Play(mainBgm);
		}
		static void MediaPlayer_MediaStateChangedRoom(object sender, System.
										   EventArgs e)
		{
			MediaPlayer.Play(room);
		}

	}

}