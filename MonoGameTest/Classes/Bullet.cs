using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace MonoGameSpaceWar.Classes
{
    public class Bullet
    {
        private Texture2D texture;
        private Rectangle destinationRectangle;
        private Color color;
        public Bullet(Vector2 position)
        {
            texture = null;
            destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 20, 50);
        }
        public void LoadContent(ContentManager manager)
        {
            texture = manager.Load<Texture2D>("asteroid");
        }
        public void Update()
        {
            destinationRectangle.Y -= 3;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, destinationRectangle,Color.Red);
        }
    }
}
