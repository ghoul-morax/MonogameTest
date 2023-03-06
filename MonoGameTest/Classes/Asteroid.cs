using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace MonoGameSpaceWar.Classes
{
    public class Asteroid
    {
        private Vector2 position;
        private Texture2D texture;
        private Rectangle collision;
        private bool isAlive;
        public bool IsAlive { get { return isAlive; } set { isAlive = value; } }
        public Rectangle Collision { get { return collision; } }

        public int Width
        {
            get
            {
                return texture.Width;
            }
        }
        public int Height
        {
            get
            {
                return texture.Height;
            }
        }

        public Vector2 Position
        {
            set
            {
                position= value;
            }
            get
            {
                return position;
            }
        }
        public Asteroid()
        {
            texture = null;
            position=  Vector2.Zero;

        }


        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("asteroid");
        }
        public void Update()
        {
            position.Y += 2;
            collision = new Rectangle((int)position.X, (int)position.Y, Width, Height);
        }
        public void Draw(SpriteBatch spriteBatch)
            {
                spriteBatch.Draw(texture, position, Color.White);
                
            }
        public Asteroid(Vector2 position)
        {
            texture = null;
            this.position = position;
        }

    }
}
