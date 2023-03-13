using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MonoGameSpaceWar.Classes
{
    internal class Explosion
    {
        private Texture2D texture;
        private Vector2 position;
        private int frameNumber = 1;
        private int frameWidth = 117;
        private int frameHeight = 117;

        private double timeTotalSeconds = 0;
        private double duration = 0.04;
        private bool isLoop = true;

        private Rectangle sourceRectangle; // нужно для рисования области текстуры
        public Explosion(Vector2 position)
        {
            texture = null;
            this.position = position;
            
        }
        public void LoadContent (ContentManager manager)
        {
            texture = manager.Load<Texture2D>("explosion3");
        }

        public void Draw (SpriteBatch spriteBatch) 
        {
            spriteBatch.Draw(texture, position, sourceRectangle, Color.White);

        }

        public void Update(GameTime gameTime)
        {
            timeTotalSeconds += gameTime.ElapsedGameTime.TotalSeconds;
            if (timeTotalSeconds > duration)
            {
                frameNumber++;
                timeTotalSeconds= 0;
            }
            if(frameNumber == 17 && isLoop)
            {
                frameNumber= 0;
            }
            sourceRectangle = new Rectangle(frameNumber * frameWidth, 0, frameWidth, frameHeight);
            Debug.WriteLine("Time: " + gameTime.ElapsedGameTime.Milliseconds);
        }
    }
}
