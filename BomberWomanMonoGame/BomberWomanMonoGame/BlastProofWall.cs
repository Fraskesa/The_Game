﻿using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace BomberWomanMonoGame
{
	public class BlastProofWall
	{
		//Attributes
		private Texture2D SpriteStoneWall;


		//Constructer
		public BlastProofWall (Texture2D sprite)
		{
			SpriteStoneWall = sprite;
		}


		public void Initialize(){
		}

		public void Update(GameTime gameTime)
		{
		
		}

		public void Draw(SpriteBatch spriteBatch){
		
			//Draw the walls that cannot be removed
			//The Horisontal border of the game
			for (int i = 50; i < 800; i += 50) 
			{
				spriteBatch.Draw (SpriteStoneWall, new Rectangle (i, 50, 50, 50), Color.White);
				spriteBatch.Draw (SpriteStoneWall, new Rectangle (i,550, 50, 50), Color.White);
			}

			//The vertical border of the game
			for (int j = 100; j < 550; j += 50) 
			{
				spriteBatch.Draw (SpriteStoneWall, new Rectangle (50, j, 50, 50), Color.White);
				spriteBatch.Draw (SpriteStoneWall, new Rectangle (750, j, 50, 50), Color.White);
			}

			//The middlestones of the game.
			for (int i = 150; i < 700; i += 100)
			{
				for (int j = 150; j < 500; j += 100) 
				{
					spriteBatch.Draw (SpriteStoneWall, new Rectangle (i, j, 50, 50), Color.White);
				}
			}  
		}
	}
}

